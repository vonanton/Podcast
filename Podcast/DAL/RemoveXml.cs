using System.Linq;
using System.Xml.Linq;

namespace Podcast.DAL
{
    class RemoveXml
    {
        public void RemovePodcast(string url, string kategori, string frekvens)
        {
            XDocument doc = XDocument.Load("Poddar.xml");
            var items = from node in doc.Descendants("Podcast")
                    let Url = node.Element("Url")
                    let Kategori = node.Element("Kategori")
                    let Frekvens = node.Element("Frekvens")
                    where Url != null && Url.Value == url
                    where Kategori != null && Kategori.Value == kategori
                    where Frekvens != null && Frekvens.Value == frekvens
                    select node;
            items.ToList().ForEach(xml => xml.Remove());
            doc.Save("Poddar.xml");
        }
    }
}
