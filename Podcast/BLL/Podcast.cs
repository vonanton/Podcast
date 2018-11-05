using Podcast.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.BLL
{
    public abstract class Podcast
    {
       
        public virtual void Add(ListView listView, string episodeCount, string podTitle, string frekvens, string category, string url)
        {
            var listViewItem = new ListViewItem(new[] {
                episodeCount,
                podTitle,
                frekvens,
                category
            });
            listView.Items.Add(listViewItem);
            listViewItem.Tag = url;
        }

        public virtual void Add(ListView listView, string item)
        {
            var listViewItem = new ListViewItem(new[] {
                item,
            });
            listView.Items.Add(listViewItem);  
        }

        public virtual void SaveChanges(ListView lvCategory, ListView lvPodcast, TextBox textBox)
        {
            lvCategory.SelectedItems[0].Text = textBox.Text;
        }

        public virtual void SaveChanges(ListView listView, ComboBox frequence, ComboBox category)
        {
            listView.SelectedItems[0].SubItems[2].Text = frequence.GetItemText(frequence.SelectedItem);
            listView.SelectedItems[0].SubItems[3].Text = category.GetItemText(category.SelectedItem);
        }

        public virtual void Remove(ListView listView)
        {
            listView.SelectedItems[0].Remove();
        }
    }
}
