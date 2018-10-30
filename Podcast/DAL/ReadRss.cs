using Podcast.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Podcast.DAL
{
    class ReadRss : IProperties
    {
        public string Episodes { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void LoadRss(TextBox url)
        {
            string newUrl = url.Text;
            //string url = "http://www.keithandthegirl.com/rss";
            XmlReader reader = XmlReader.Create(newUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            Episodes = numberOfItems(newUrl).ToString();
            Title = feed.Title.Text;
            Description = feed.Description.Text;
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
