using Podcast.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.BLL
{
    public abstract class Podcast: IProperties
    {
        public string Category { get; set; }
        public string Episodes { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //public abstract ListViewItem ToListViewItem();

        public abstract void Add(ListView listView, TextBox textUrl);

        public abstract void SaveChanges();

        public abstract void Remove();
    }
}
