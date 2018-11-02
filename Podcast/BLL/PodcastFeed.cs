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


        public async void Add(ListView listView, string url, string frekvens, string category)
        {
            SaveXml saveXml = new SaveXml();
            await readRss.LoadRss(url);
            saveXml.SavePodcast(url, frekvens, category);
            EpisodeCount = readRss.EpisodeCount;
            PodTitle = readRss.PodTitle;

            base.Add(listView, EpisodeCount, PodTitle, frekvens, category, url);
        }

        public async void AddPodXml(ListView listView)
        {
            List<ListViewItem> testLista = new List<ListViewItem>();
            LoadXml loadXml = new LoadXml();
            loadXml.LoadPodcast(testLista);

            foreach(var item in testLista)
            {
                var url = item.SubItems[0].Text;
                var frekvens = item.SubItems[1].Text;
                var category = item.SubItems[2].Text;
                await readRss.LoadRss(url);
                EpisodeCount = readRss.EpisodeCount;
                PodTitle = readRss.PodTitle;
                base.Add(listView, EpisodeCount, PodTitle, frekvens, category, url);
            }
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

        public void SaveChanges(ListView lvPodcast, ComboBox frequence, ComboBox changeCategory, string url)
        {
            string frekvens = frequence.GetItemText(frequence.SelectedItem);
            string kategori = changeCategory.GetItemText(changeCategory.SelectedItem);
            //base.SaveChanges(lvPodcast, frequence, changeCategory);
            Remove(lvPodcast);
            
            Add(lvPodcast, url, frekvens, kategori);
        }

        public override void Remove(ListView listView)
        {
            Episodes.Remove(listView.SelectedItems[0].SubItems[1].Text);
            
            base.Remove(listView);
        }
    }
}
