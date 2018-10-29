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

        public abstract void SaveChanges();

        public abstract void Remove();
    }
}
