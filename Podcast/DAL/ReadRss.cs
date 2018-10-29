using Podcast.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Text;
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

        public ReadRss()
        {
            Episodes = new Dictionary<string, List<string>>();
            EpisodeSummary = new Dictionary<string, List<string>>();
        }

        public async Task LoadRss(string rssUrl)
        {
            await Task.Run(() =>
            {
                
                //https://cdn.radioplay.se/data/rss/498.xml
                //https://cdn.radioplay.se/data/rss/490.xml
                //https://cdn.radioplay.se/data/rss/503.xml

                XmlReader reader = XmlReader.Create(rssUrl);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                EpisodeCount = numberOfItems(rssUrl).ToString();
                PodTitle = feed.Title.Text;
               
                foreach (SyndicationItem episodes in feed.Items)
                {
                    string EpisodeTitle = episodes.Title.Text;
                    
                    if(!EpisodeSummary.ContainsKey(EpisodeTitle))
                    {
                        EpisodeSummary.Add(EpisodeTitle, new List<string>());
                        EpisodeSummary[EpisodeTitle].Add(episodes.Summary.Text);
                    }
                    if (!Episodes.ContainsKey(PodTitle))
                    {
                        Episodes.Add(PodTitle, new List<string>());
                        Episodes[PodTitle].Add(EpisodeTitle);
                    }
                    else
                    {
                        foreach (var values in Episodes.Values)
                        {
                            if(!values.Contains(EpisodeTitle))
                            {
                                Episodes[PodTitle].Add(EpisodeTitle);
                                EpisodeSummary[EpisodeTitle].Add(episodes.Summary.Text);
                            }
                        }        
                    }
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
