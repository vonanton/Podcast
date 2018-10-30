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
    
    public abstract class Podcast
    {
        

        public virtual void Add(ListView listView, string episodeCount, string podTitle, string frekvens, string category)
        {
            var listViewItem = new ListViewItem(new[] {
                episodeCount,
                podTitle,
                frekvens,
                category
            });
            listView.Items.Add(listViewItem);
           

        }

        public virtual void Add(ListView listView, string item)
        {
            var listViewItem = new ListViewItem(new[] {
                item,
            });
            listView.Items.Add(listViewItem);
            SaveCategory(listView);

            
        }
        public void SaveCategory(ListView listView)
        {
            const string sPath = "nyfil.xml";

            TextWriter SaveFile = new StreamWriter(sPath);

            foreach (ListViewItem item in listView.Items)
            {
                SaveFile.WriteLine(item.Text);
            }


            SaveFile.Close();
        }
        //public void SaveRSS(ListView listView)
        //{
        //    const string path = "RSS.xml";

        //    XmlSerializer SaveFile = new XmlSerializer(typeof(ListViewItem));

        //    using (FileStream stream = File.OpenWrite(path))
        //    {
        //        SaveFile.Serialize(stream, listView.Items);
        //    }
        //    //foreach (ListViewItem item in listView.Items)
        //    //{
        //    //    SaveFile.WriteLine(item);
        //    //}


        //    //SaveFile.Close();
        //}

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
