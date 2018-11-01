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
        public Dictionary<string, Timer> Timer { get; set; }

        public Form1()
        {
            InitializeComponent();
            Urls = new List<string>();
            Timer = new Dictionary<string, Timer>();
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

            Timer timers = new Timer();
            timers.Interval = setInterval;
            timers.Enabled = true;

            timers.Tag = tbUrl.Text;
            
            timers.Tick += new EventHandler(timer1_Tick);
            Timer.Add(tbUrl.Text, timers);
            
            timers.Start();
        }

        public void ChangeTimer()
        {
            int setInterval = 0;
            if (cbUpdate.SelectedItem.ToString() == "5 Minutes")
            {
                setInterval = 10000;
                //300000;
            }
            if (cbUpdate.SelectedItem.ToString() == "10 Minutes")
            {
                setInterval = 20000;
                //600000;
            }
            if (cbUpdate.SelectedItem.ToString() == "15 Minutes")
            {
                setInterval = 900000;
            }

            string URL = lvPodcast.SelectedItems[0].Tag.ToString();
                foreach(var kv in Timer)
                {
                    if(kv.Key == URL)
                    {
                        kv.Value.Interval = setInterval;
                        kv.Value.Enabled = true;
                        kv.Value.Tick += new EventHandler(timer1_Tick);
                        kv.Value.Start();
                    }
                }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category.Add(lvCategory, tbCategories.Text);
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
            ChangeTimer();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {   
            Timer timer = (Timer)sender;
            if (timer.Tag != null)
            {
                string newUrl = (string)timer.Tag;
                SaveXml saveXml = new SaveXml();
                saveXml.SavePodcast(lvPodcast);
                PodcastFeed.testaDicToXml();
                await PodcastFeed.readRss.LoadRss(newUrl);
                //PodcastFeed.UpdateCount(lvPodcast, newUrl);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UpdateComboBox(cbChangeCategory);
            cbUpdate.SelectedIndex = 0;
        }
    }
}
