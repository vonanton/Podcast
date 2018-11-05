using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace Podcast.BLL
{
    class ValidateException
    {
        ValidateMessages message = new ValidateMessages();

        public bool UrlNotEmpty(TextBox textBox)
        {
            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                message.UrlEmpty();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CategoryNotEmpty(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                message.CategoryEmpty();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ListViewNotSelected(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                return true;
            }
            else
            {
                message.ItemNotSelected();
                return false;
            }
        }
        
        public bool ComboBoxEmpty(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
            {
                message.FrekvensEmpty();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidRssUrl(string url)
        {
            try
            {
                XmlReader reader = XmlReader.Create(url);
                Rss20FeedFormatter formatter = new Rss20FeedFormatter();
                formatter.ReadFrom(reader);
                reader.Close();
                return true;
            }
            catch (Exception)
            {
                message.ValidUrl();
                return false;
            }
        }

        public bool UrlExists(Dictionary<string, Timer> timer, string url)
        {
            foreach (var item in timer)
            {
                if(item.Key == url)
                {
                    message.DuplicateUrl();
                    return false;
                }
            }
            return true;
        }
    }
}