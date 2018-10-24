using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Syndication;
using System.Xml;
using Podcast.BLL;

namespace Podcast
{
    public partial class Form1 : Form
    {
        PodcastFeed pod = new PodcastFeed();
        public Form1()
        {
            InitializeComponent();
            
        }

        /*public void ReadRssFeed()
        {
            string url = "http://www.keithandthegirl.com/rss";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            string Episodes = numberOfItems(url).ToString();
            string Title = feed.Title.Text;
            string Description = feed.Description.Text;
            
            var listViewItem = new ListViewItem(new[] {
                Episodes,
                Title,
                Description
            });
            lvPodcast.Items.Add(listViewItem);
        }

        private int numberOfItems(string feedUrl)
        {
            using (XmlReader reader = XmlReader.Create(feedUrl))
            {
                return SyndicationFeed.Load(reader).Items.Count();
            }
        }*/

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            pod.Add(lvPodcast, tbUrl);
        }
    }
}
