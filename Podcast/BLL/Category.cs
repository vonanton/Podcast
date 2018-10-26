using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.BLL
{
    class Category : Podcast
    {
        public void Add(ListView listView, TextBox categoryText)
        {
            string Category = categoryText.Text;
            base.Add(listView, Category);
        }

        public override void SaveChanges()
        {

        }

        public override void Remove(ListView listView)
        {
            base.Remove(listView);
        }

    }
}
