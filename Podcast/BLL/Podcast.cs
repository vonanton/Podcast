using Podcast.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Podcast.BLL
{
    [Serializable]
    public abstract class Podcast
    {
        

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
            SaveFile(listView);

            
        }
        public void SaveFile(ListView listView)
        {
            const string sPath = "savers.txt";

            TextWriter SaveFile = new StreamWriter(sPath);

            foreach (ListViewItem item in listView.Items)
            {
                SaveFile.WriteLine(item.Text);
            }


            SaveFile.Close();
        }


        public abstract void SaveChanges();

        public abstract void Remove();
    }
}
