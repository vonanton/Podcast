using Podcast.DAL;
using Podcast.Interfaces;
using System;
using System.Collections.Generic;
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
        

        public PodcastFeed()
        {
            Episodes = readRss.Episodes;
            EpisodeSummary = readRss.EpisodeSummary;
        }
        public void testaDicToXml()
        {
            SaveXml saveXml = new SaveXml();
            saveXml.SaveEpisodes(Episodes);
            saveXml.SaveSummary(EpisodeSummary);
        }

        public async void Add(ListView listView, string url, string frekvens, string category)
        {
            await readRss.LoadRss(url);
            EpisodeCount = readRss.EpisodeCount;
            PodTitle = readRss.PodTitle;

            base.Add(listView, EpisodeCount, PodTitle, frekvens, category);
        }

        /*SKIT FÅ DEN ATT KÖRA PÅ ENSKILD RAD INTE ALLA
        public void UpdateCount(ListView listView, string url)
        {
            string updateCount = readRss.numberOfItems(url).ToString();
            for(int i = 0; i < listView.Items.Count; i++)
            {
                string count = listView.Items[i].SubItems[0].Text;
                if(updateCount != count)
                {
                    listView.Items[i].SubItems[0].Text = updateCount;
                }
            }
            
        }*/

        public void ListEpisodes(ListView lvPodcastEpisodes, ListView lvPodcast)
        {
            //Episodes = readRss.Episodes;
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
            //EpisodeSummary = readRss.EpisodeSummary;
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
