using Podcast.DAL;
using Podcast.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public string Episodes { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        /*public override ListViewItem ToListViewItem()
        {

            return null;
        }*/

        public override void Add(ListView listView, TextBox url)
        {
            readRss.LoadRss(url);
            Episodes = readRss.Episodes;
            Title = readRss.Title;
            Summary = readRss.Summary;
            for(int i = 0; i<5; i++)
            {
                var listViewItem = new ListViewItem(new[] {
                Episodes,
                Title,
                Summary
            });

                listView.Items.Add(listViewItem);
            }
            
            
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
