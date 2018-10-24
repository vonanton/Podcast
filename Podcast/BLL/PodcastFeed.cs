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
    public class PodcastFeed : Podcast
    {

        /*public override ListViewItem ToListViewItem()
        {

            return null;
        }*/

        public override void Add(ListView listView, TextBox url)
        {
            string newUrl = url.Text;
            //string url = "http://www.keithandthegirl.com/rss";
            XmlReader reader = XmlReader.Create(newUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            Episodes = numberOfItems(newUrl).ToString();
            Title = feed.Title.Text;
            Description = feed.Description.Text;

            var listViewItem = new ListViewItem(new[] {
                Episodes,
                Title,
                Description
            });
            listView.Items.Add(listViewItem);
        }

        private int numberOfItems(string feedUrl)
        {
            using (XmlReader reader = XmlReader.Create(feedUrl))
            {
                return SyndicationFeed.Load(reader).Items.Count();
            }
        }

        public override void SaveChanges()
        {

        }

        public override void Remove()
        {

        }
    }
}
