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
        public Dictionary<string, Timer> Timers { get; set; }

        public Form1()
        {
            InitializeComponent();
            Urls = new List<string>();
            Timers = new Dictionary<string, Timer>();
            lblPodcastEpisode.Text = "";
            lblPodcast.Text = "";
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
            Timers.Add(tbUrl.Text, timers);
            
            timers.Start();
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
            string url = lvPodcast.SelectedItems[0].Tag.ToString();
            Timers.Remove(url);
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
                tbUrl.Text = lvPodcast.SelectedItems[0].Tag.ToString();
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
            // lvPodcast,
            Category.SaveChanges(lvCategory, tbCategories);
            UpdateComboBox(cbChangeCategory);
        }

        private void btnSavePodChanges_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text;
            PodcastFeed.SaveChanges(lvPodcast, cbUpdate, cbChangeCategory, url);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            if (timer.Tag != null)
            {
                string newUrl = (string)timer.Tag;
                await PodcastFeed.readRss.LoadRss(newUrl);
            }
        }

        private void setTimerOnLoad()
        {
            int setInterval = 0;

            Invoke(new Action(() =>
            {
                foreach (ListViewItem item in lvPodcast.Items)
                {
                    if (item.SubItems[2].Text == "5 Minutes")
                    {
                        setInterval = 10000;
                        //300000;
                    }
                    if (item.SubItems[2].Text == "10 Minutes")
                    {
                        setInterval = 20000;
                        //600000;
                    }
                    if (item.SubItems[2].Text == "15 Minutes")
                    {
                        setInterval = 900000;
                    }
             

                    Timer timers = new Timer();
                    timers.Interval = setInterval;
                    timers.Enabled = true;

                    timers.Tag = item.Tag.ToString();

                    timers.Tick += new EventHandler(timer1_Tick);
                    Timers.Add(item.Tag.ToString(), timers);

                    timers.Start();
                }
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Category.AddCategoryXml(lvCategory);
            UpdateComboBox(cbChangeCategory);
            PodcastFeed.AddPodXml(lvPodcast);
            Task.Delay(5000).ContinueWith(t => setTimerOnLoad());
        }
    }
}
