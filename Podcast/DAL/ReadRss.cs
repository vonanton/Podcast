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
        public string Episodes { get; set; }
        public string Title { get; set; }

        public async Task LoadRss(TextBox url)
        {
            await Task.Run(() =>
            {
                string rssUrl = url.Text;
                //HttpClient client = new HttpClient();
                //var rsstring = await client.GetStringAsync(rssUrl);
                //string url = "http://www.keithandthegirl.com/rss";

                XmlReader reader = XmlReader.Create(rssUrl);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                Episodes = numberOfItems(rssUrl).ToString();
                Title = feed.Title.Text;
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
