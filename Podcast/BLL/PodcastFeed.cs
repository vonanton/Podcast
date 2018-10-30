using Podcast.DAL;
using Podcast.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Podcast.BLL
{
    public class PodcastFeed : Podcast, IProperties
    {
        public ReadRss readRss = new ReadRss();

        public Dictionary<string, List<string>> Episodes { get; set; }
        public Dictionary<string, List<string>> EpisodeSummary { get; set; }
        public string EpisodeCount { get; set; }
        public string PodTitle { get; set; }
        

        public async void Add(ListView listView, string url, string frekvens, string category)
        {
            await readRss.LoadRss(url);
            EpisodeCount = readRss.EpisodeCount;
            PodTitle = readRss.PodTitle;

            base.Add(listView, EpisodeCount, PodTitle, frekvens, category);
            SavePodcast(listView, EpisodeCount, PodTitle);
        }

        public void ListEpisodes(ListView lvPodcastEpisodes, ListView lvPodcast)
        {
            
            Episodes = readRss.Episodes;
            string podTitle = lvPodcast.SelectedItems[0].SubItems[1].Text;
            foreach (var episodes in Episodes)
            {
                    foreach (var value in episodes.Value)
                    {
                        if (podTitle == episodes.Key)
                        {
                            base.Add(lvPodcastEpisodes, value);
                        }
                    } 
            }
        }
        public void ListEpisodeSummary(ListView lvPodcastEpisode, TextBox summaryText)
        {
            
            EpisodeSummary = readRss.EpisodeSummary;
            string episodeTitle = lvPodcastEpisode.SelectedItems[0].Text;
            foreach (var summary in EpisodeSummary)
            {
                foreach (var summaryValue in summary.Value)
                {
                    if (episodeTitle == summary.Key)
                    {
                        summaryText.Text = summaryValue;
                    }
                }
            }
        }

        public void SavePodcast(ListView listView, String EpisodeCount, String PodTitle)
        {
            const string sPath = "nyfilPod.xml";

            TextWriter SaveFile = new StreamWriter(sPath);

            foreach (ListViewItem item in listView.Items)
            {
                SaveFile.WriteLine(EpisodeCount, PodTitle);
            }


            SaveFile.Close();
        }

        public override void SaveChanges(ListView lvPodcast, ComboBox frequence, ComboBox changeCategory)
        {
            base.SaveChanges(lvPodcast, frequence, changeCategory);
        }

        public override void Remove(ListView listView)
        {
            Episodes.Remove(listView.SelectedItems[0].SubItems[1].Text);
            base.Remove(listView);
        }
    }
}
