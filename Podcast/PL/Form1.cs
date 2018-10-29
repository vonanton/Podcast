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

namespace Podcast
{
    public partial class Form1 : Form
    {
        PodcastFeed podcastFeed = new PodcastFeed();
        Category category = new Category();
        
        

        public Form1()
        {
            InitializeComponent();
            ReadFile();
            ReadXml();


        }
        private void ReadFile(){
            try
            {
                string minText = "nyfil.xml";
                using (var ReadFile = new StreamReader(minText))
                {
                    string line;
                    while ((line = ReadFile.ReadLine()) != null)
                    {
                        foreach(string text in line.Split())
                        {
                            lvCategory.Items.Add(text);
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
        private void ReadXml()
        {
            try
            {
                string minText = "blah.xml";
                using (var ReadFile = new StreamReader(minText))
                {
                    string line;
                    while ((line = ReadFile.ReadLine()) != null)
                    {
                        foreach (string text in line.Split())
                        {
                            lvPodcast.Items.Add(text);
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


        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text;
            var xml = SaveToXml(url);
            File.WriteAllText("blah.xml", xml);
            podcastFeed.Add(lvPodcast, tbUrl);
            
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            category.Add(lvCategory, tbCategories);
            cbChangeCategory.Items.Add(tbCategories.Text);
        }
        public static string SaveToXml(string url)
        {

            string text;
            using (var client = new WebClient())
            {
                text = client.DownloadString(url);
            }
            return text;
        }

    }
    
}
