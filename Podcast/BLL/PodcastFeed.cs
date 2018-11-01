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
            SaveFeed(listView, url, frekvens, category);
            base.Add(listView, EpisodeCount, PodTitle, frekvens, category);
            
        }
        public void SaveFeed(ListView listView, string url, string frekvens, string category)
        {
            const string path = "feed.xml";

            if (!File.Exists(path)) {
                using (XmlTextWriter SaveFeeds = new XmlTextWriter(path, Encoding.UTF8))
                {
                    EpisodeCount = readRss.EpisodeCount;
                    PodTitle = readRss.PodTitle;
                    string urls = listView.Tag.ToString();
                    
                    
                    foreach (ListViewItem list in listView.Items)
                    {
                        SaveFeeds.WriteStartElement(list.ToString());
                        SaveFeeds.WriteEndElement();
                        SaveFeeds.Close();
                    }
                }
            }
           
            
                
            }
         
        
            //    XmlSerializer SaveFile = new XmlSerializer(typeof(ListViewItem));

                //using (FileStream stream = File.OpenWrite(path))
            //   {
            //        SaveFile.Serialize(stream, listView.Items);
            //    }
            //    //foreach (ListViewItem item in listView.Items)
            //    //{
            //    //    SaveFile.WriteLine(item);
            //    //}


            //    //SaveFile.Close();
        

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
