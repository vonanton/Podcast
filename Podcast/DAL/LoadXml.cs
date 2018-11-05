using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

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

        public void LoadPodcast(List<ListViewItem> XmlPodList)
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
                XmlPodList.Add(listViewItem);
            }
        }
    }
}
