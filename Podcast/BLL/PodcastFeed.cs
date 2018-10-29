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
using System.IO;

namespace Podcast.BLL
{
    [Serializable]
    public class PodcastFeed : Podcast, IProperties
    {
        ReadRss readRss = new ReadRss();
        
        public string Episodes { get; set; }
        public string Title { get; set; }

        public async void Add(ListView listView, TextBox url)
        {
            await readRss.LoadRss(url);
            Episodes = readRss.Episodes;
            Title = readRss.Title;
            
            base.Add(listView, Episodes, Title);
            
        }

        public override void SaveChanges()
        {

        }

        public override void Remove()
        {

        }
    }
}
