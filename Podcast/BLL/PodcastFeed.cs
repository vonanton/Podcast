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
        ReadRss readRss = new ReadRss();

        public List<string> Episodes { get; set; }
        public string EpisodeCount { get; set; }
        public string Title { get; set; }

        public async void Add(ListView listView, TextBox url)
        {
            await readRss.LoadRss(url);
            EpisodeCount = readRss.EpisodeCount;
            Title = readRss.Title;
            
            base.Add(listView, EpisodeCount, Title);
        }

        public void ListEpisodes(ListView lvPodcastEpisodes, ListView lvPodcast)
        {

            Episodes = readRss.Episodes;

            foreach (var episodes in Episodes)
            {
                if (lvPodcast.SelectedItems.Count > 0)
                {
                    textBox1.Text = Episodes[lvPodcast.SelectedItems[0].Index];
                    base.Add(lvPodcastEpisodes, episodes);
                }                   
            }   
        }

        public override void SaveChanges()
        {

        }

        public override void Remove(ListView listView)
        {
            base.Remove(listView);
        }
    }
}
