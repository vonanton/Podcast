using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.Xml;
using System.ServiceModel.Syndication;

namespace Podcast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void AddItem()
        {
            string url = "http://25minstosurrender.podomatic.com/rss2.xml";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
                string subject = item.Title.Text;
                string a = item.Summary.Text;
                string b = item.Categories.ToString();
                var listViewItem = new ListViewItem(b);
                lvFeed.Items.Add(b);
                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
