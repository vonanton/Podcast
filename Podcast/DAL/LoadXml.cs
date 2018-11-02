using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Podcast.DAL
{
    class LoadXml
    {
        

        public void LoadCategory(List<string> kategorier)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Kategorier.xml");

            var kategoriEl = doc.GetElementsByTagName("Kategori");
            
            for(int i = 0; i < kategoriEl.Count; i++)
            {
                kategorier.Add(kategoriEl[i].InnerText);
            }
                
        }

        public void LoadPodcast(List<ListViewItem> test)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("Poddar.xml");

            var urlEl = doc.GetElementsByTagName("Url");
            var frekvensEl = doc.GetElementsByTagName("Frekvens");
            var kategoriEl = doc.GetElementsByTagName("Kategori");


            for(int i = 0; i < urlEl.Count; i++)
            {
                var listViewItem = new ListViewItem(new[] {
                urlEl[i].InnerText,
                frekvensEl[i].InnerText,
                kategoriEl[i].InnerText
            });
                test.Add(listViewItem);
            }
        }
    }
}
