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
using Podcast.DAL;

namespace Podcast
{
    public partial class Form1 : Form
    {
        PodcastFeed PodcastFeed = new PodcastFeed();
        Category Category = new Category();
        
        List<string> Urls { get; set; }
        public Dictionary<string, List<Timer>> Timer { get; set; }

        public Form1()
        {
            InitializeComponent();
            Urls = new List<string>();
            Timer = new Dictionary<string, List<Timer>>();
        }

        private void UpdateComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var category in Category.ListOfCategorys)
            {
                comboBox.Items.Add(category);
            }
        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            string newUrl = tbUrl.Text;
            Urls.Add(newUrl);
            string frequence = cbUpdate.GetItemText(cbUpdate.SelectedItem);
            string category = cbChangeCategory.GetItemText(cbChangeCategory.SelectedItem);
            PodcastFeed.Add(lvPodcast, newUrl, frequence, category);
            
            setTimer();
        }

        private void setTimer()
        {
            int setInterval = 0;
            if(cbUpdate.SelectedItem.ToString() == "5 Minutes")
            {
                setInterval = 10000;
                    //300000;
            }
            if(cbUpdate.SelectedItem.ToString() == "10 Minutes")
            {
                setInterval = 20000;
                    //600000;
            }
            if (cbUpdate.SelectedItem.ToString() == "15 Minutes")
            {
                setInterval = 900000;
            }


            Timer timers = new Timer
            {
                Interval = setInterval,
                Enabled = true
            };

            timers.Tag = tbUrl.Text;
            
            timers.Tick += new EventHandler(timer1_Tick);
            //Timer.Add(tbUrl.Text, new List<Timer>());
            //Timer[tbUrl.Text].Add(timers);
            timers.Start();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category.Add(lvCategory, tbCategories);
            UpdateComboBox(cbChangeCategory);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            Category.Remove(lvCategory);
            UpdateComboBox(cbChangeCategory);
        }

        private void btnDeletePodcast_Click(object sender, EventArgs e)
        {
            tbEpisodeSummary.Clear();
            PodcastFeed.Remove(lvPodcast);
        }


        private void lvPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPodcast.Text = "";
            lblPodcastEpisode.Text = "";
            tbEpisodeSummary.Clear();

            lvPodcastEpisodes.Items.Clear();
            if (lvPodcast.SelectedItems.Count > 0)
            {
                PodcastFeed.ListEpisodes(lvPodcastEpisodes, lvPodcast);
                lblPodcast.Text = lvPodcast.SelectedItems[0].SubItems[1].Text;
            }

        }

        private void lvPodcastEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPodcastEpisode.Text = "";
            tbEpisodeSummary.Clear();

            if (lvPodcastEpisodes.SelectedItems.Count > 0)
            {
                PodcastFeed.ListEpisodeSummary(lvPodcastEpisodes, tbEpisodeSummary);
                lblPodcastEpisode.Text = lvPodcastEpisodes.SelectedItems[0].Text;
            }
        }

        private void btnSaveCategoryChanges_Click(object sender, EventArgs e)
        {
            Category.SaveChanges(lvCategory, lvPodcast, tbCategories);
            UpdateComboBox(cbChangeCategory);
        }

        private void btnSavePodChanges_Click(object sender, EventArgs e)
        {
            PodcastFeed.SaveChanges(lvPodcast, cbUpdate, cbChangeCategory);
            setTimer();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            //ReadRss readRss = new ReadRss();

            //var newUrl = "";
            /*foreach(var url in Urls)
            {
                foreach(var kv in Timer)
                {
                    if(kv.Key == url)
                    {*/
            
            Timer timer = (Timer)sender;
            if (timer.Tag != null)
            {
                string newUrl = (string)timer.Tag;
                
                await PodcastFeed.readRss.LoadRss(newUrl);
                //then do some DB stuff to get the contact details use contactID
            }
            
                        
                        //PodcastFeed.Add(lvPodcast, newUrl, frequence, category);
                    /*}
                }          
            }*/
        }
    }
}
