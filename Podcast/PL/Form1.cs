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
using System.IO;
using System.Net;
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
            ReadFile();
            ReadFeed();
            //ReadXml();
        }
            
        private void ReadFile(){
            try
            {
                string minTex = "nyfil.xml";
                using (var ReadFile = new StreamReader(minTex))
                {
                    string line;
                    while ((line = ReadFile.ReadLine()) != null)
                    {
                        foreach(string text in line.Split())
                        {
                            lvCategory.Items.Add(text);
                            cbChangeCategory.Items.Add(text);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Filen kunde inte hittas!");
                MessageBox.Show("Något fel");
            }
        }
        private void ReadFeed()
        {
            try
            {
                string minTex = "feed.xml";
                using (var ReadFile = new StreamReader(minTex))
                {
                    string line;
                    while ((line = ReadFile.ReadLine()) != null)
                    {
                        foreach (string text in line.Split())
                        {
                            lvPodcast.Items.Add(text);
                           // cbChangeCategory.Items.Add(text);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Filen kunde inte hittas!");
                MessageBox.Show("Något fel");
            }
        }
                //private void ReadFeed()
                //{
                //    try
                //    {
                //        string minText = "blah.xml";
                //        using (var ReadFile = new StreamReader(minText))
                //        {
                //            string line;
                //            while ((line = ReadFile.ReadLine()) != null)
                //            {
                //                foreach (string text in line.Split())
                //                {
                //                    lvPodcast.Items.Add(text);
                //                }
                //            }
                //        }
                //    }
                //    catch (Exception)
                //    {
                //        Console.WriteLine("Filen kunde inte hittas!");
                //        MessageBox.Show("Något fel");
                //    }
                //}
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

            
            //var xml = SaveToXml(newUrl);
            //File.WriteAllText("blah.xml", xml);
            
        }

        private void setTimer()
        {
            Timer timers = new Timer
            {
                Interval = 4000,
                Enabled = true
            };
            timers.Tick += new EventHandler(timer1_Tick);
            Timer.Add(tbUrl.Text, new List<Timer>());
            Timer[tbUrl.Text].Add(timers);
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
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            //ReadRss readRss = new ReadRss();
            string frequence = cbUpdate.GetItemText(cbUpdate.SelectedItem);
            string category = cbChangeCategory.GetItemText(cbChangeCategory.SelectedItem);
            //var newUrl = "";
            foreach(var url in Urls)
            {
                foreach(var kv in Timer)
                {
                    if(kv.Key == url)
                    {
                        string newUrl = url;
                        await PodcastFeed.readRss.LoadRss(newUrl);
                        //PodcastFeed.Add(lvPodcast, newUrl, frequence, category);
                    }
                }          
            }
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public static string SaveToXml(string url)
        //{

        //    string text;
        //    using (var client = new WebClient())
        //    {
        //        text = client.DownloadString(url);
        //    }
        //    return text;
        //}

    }
    
}
