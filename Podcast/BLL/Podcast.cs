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

        public abstract void Add(ListView listView, TextBox textUrl);

        public abstract void SaveChanges();

        public abstract void Remove();
    }
}
