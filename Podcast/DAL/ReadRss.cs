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
    class ReadRss : IProperties
    {
        public List<string> Episodes { get; set; }
        public string EpisodeCount { get; set; }
        public string Title { get; set; }

        public ReadRss()
        {
            Episodes = new List<string>();
        }

        public async Task LoadRss(TextBox url)
        {
            await Task.Run(() =>
            {
                string rssUrl = url.Text;
                //string url = "http://www.keithandthegirl.com/rss";

                XmlReader reader = XmlReader.Create(rssUrl);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                EpisodeCount = numberOfItems(rssUrl).ToString();
                Title = feed.Title.Text;
                foreach(SyndicationItem episodes in feed.Items)
                {
                    Episodes.Add(episodes.Title.Text);
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
