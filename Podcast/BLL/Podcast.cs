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

        //public abstract ListViewItem ToListViewItem();

        //public abstract void Add(TextBox category);

        

        public virtual void Add(ListView listView, string episodes, string title)
        {
            var listViewItem = new ListViewItem(new[] {
                episodes,
                title,
            });
            listView.Items.Add(listViewItem);
        }

        public virtual void Add(ListView listView, string category)
        {
            var listViewItem = new ListViewItem(new[] {
                category,
            });
            listView.Items.Add(listViewItem);
        }

        public abstract void SaveChanges();

        public abstract void Remove();
    }
}
