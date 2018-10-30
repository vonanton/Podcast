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
        PodcastFeed podcastFeed = new PodcastFeed();

        public Form1()
        {
            InitializeComponent();
            
        }


        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            podcastFeed.Add(lvPodcast, tbUrl);
        }
    }
}
