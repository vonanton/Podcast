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

        public virtual void Add(ListView listView, string episodeCount, string title)
        {
            var listViewItem = new ListViewItem(new[] {
                episodeCount,
                title,
            });
            listView.Items.Add(listViewItem);
        }

        public virtual void Add(ListView listView, string item)
        {
            var listViewItem = new ListViewItem(new[] {
                item,
            });
            listView.Items.Add(listViewItem);
        }

        public abstract void SaveChanges();

        public virtual void Remove(ListView listView)
        {
            listView.SelectedItems[0].Remove();
        }
    }
}
