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
            List<ListViewItem> XmlPodList = new List<ListViewItem>();
            LoadXml loadXml = new LoadXml();
            loadXml.LoadPodcast(XmlPodList);

            foreach(var item in XmlPodList)
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
            
            Remove(lvPodcast);
            
            Add(lvPodcast, url, frekvens, kategori);
        }

        public override void Remove(ListView listView)
        {
            RemoveXml removeXml = new RemoveXml();
            string url = listView.SelectedItems[0].Tag.ToString();
            string frekvens = listView.SelectedItems[0].SubItems[2].Text;
            string kategori = listView.SelectedItems[0].SubItems[3].Text;
            
            removeXml.RemovePodcast(url, kategori, frekvens);

            Episodes.Remove(listView.SelectedItems[0].SubItems[1].Text);
            base.Remove(listView);
        }
    }
}
