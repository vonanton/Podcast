using Podcast.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Podcast.DAL
{
    public class ReadRss : IProperties
    {
        public Dictionary<string, List<string>> Episodes { get; set; }
        public Dictionary<string, List<string>> EpisodeSummary { get; set; }
        public string EpisodeCount { get; set; }
        public string PodTitle { get; set; }
        public string EpisodeTitle { get; set; }

        public ReadRss()
        {
            Episodes = new Dictionary<string, List<string>>();
            EpisodeSummary = new Dictionary<string, List<string>>();
        }

        public async Task LoadRss(string rssUrl)
        {
            await Task.Run(() =>
            {
                try
                {
                    XmlReader reader = XmlReader.Create(rssUrl);
                    SyndicationFeed feed = SyndicationFeed.Load(reader);
                    reader.Close();

                    EpisodeCount = numberOfItems(rssUrl).ToString();
                    PodTitle = feed.Title.Text;
                
                    foreach (SyndicationItem episodes in feed.Items)
                    {
                        EpisodeTitle = episodes.Title.Text;
                        string Summary = episodes.Summary.Text;

                        if(!EpisodeSummary.ContainsKey(EpisodeTitle))
                        {
                            EpisodeSummary.Add(EpisodeTitle, new List<string>());
                            EpisodeSummary[EpisodeTitle].Add(Summary);
                        }
                        if(!Episodes.ContainsKey(PodTitle))
                        {
                            Episodes.Add(PodTitle, new List<string>());
                            Episodes[PodTitle].Add(EpisodeTitle);
                        }
                        else
                        {
                            bool EpisodeExists = Episodes.Values.Any(value => value.Contains(EpisodeTitle));
                            bool SummaryExists = EpisodeSummary.Values.Any(value => value.Contains(Summary));
                            if (!EpisodeExists)
                            {
                                Episodes[PodTitle].Add(EpisodeTitle);
                            }   
                            if(!SummaryExists)
                            {
                                EpisodeSummary[EpisodeTitle].Add(Summary);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Något gick fel. Har du rätt podcast?");
                }
            });            
        }

        private int numberOfItems(string feedUrl)
        {
            using (XmlReader reader = XmlReader.Create(feedUrl))
            { 
                return SyndicationFeed.Load(reader).Items.Count();
            }
        }
    }
}