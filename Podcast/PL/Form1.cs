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
        Category category = new Category();

        public Form1()
        {
            InitializeComponent();

        }


        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            podcastFeed.Add(lvPodcast, tbUrl);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            category.Add(lvCategory, tbCategories);
            cbChangeCategory.Items.Add(tbCategories.Text);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            category.Remove(lvCategory);
        }

        private void btnDeletePodcast_Click(object sender, EventArgs e)
        {
            podcastFeed.Remove(lvPodcast);
        }

        private void lvPodcast_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            
        }

        private void lvPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvPodcastEpisodes.Clear();
            if (lvPodcast.SelectedItems.Count > 0)
            {
                podcastFeed.ListEpisodes(lvPodcastEpisodes, lvPodcast);
            }
                

        }
    }
}
