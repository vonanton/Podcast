using System.Collections.Generic;
using System.Xml.Linq;

namespace Podcast.DAL
{
    class SaveXml
    {
        XDocument document;   

        public void SavePodcast(string url, string Frekvens, string Kategori)
        { 
            document = new XDocument();
            document = XDocument.Load("Poddar.xml");

            XElement newPodcast = new XElement("Podcast");
            XElement URL = new XElement("Url", url);
            XElement frek = new XElement("Frekvens", Frekvens);
            XElement cat = new XElement("Kategori", Kategori);

            newPodcast.Add(URL, frek, cat);
            document.Root.Add(newPodcast);
            document.Save("Poddar.xml");
        }

        public void SaveCategory(List<string> category)
        {
            document = new XDocument();
            XElement newCategory = new XElement("Kategorier");

            foreach(var cat in category)
            {
                newCategory.Add(new XElement("Kategori", cat));
            }
            document.Add(newCategory);
            document.Save("Kategorier.xml");
        }
    }
}