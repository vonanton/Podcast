using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Podcast.DAL
{
    class SaveXml
    {
        XDocument document;
        
        public void SavePodcast(string url, string Frekvens, string Kategori)
        { 
            //var url = "";
            //var Frekvens = "";
            //var Kategori = "";
            //XElement outElm = new XElement("Podcast");
            //XElement test = new XElement("Podcast");
            /*foreach (ListViewItem item in listView.Items)
            {
                url = item.Tag.ToString();
                Frekvens = item.SubItems[2].Text;
                Kategori = item.SubItems[3].Text;
            
                XElement tag = new XElement("Url", url);
                XElement frek = new XElement("Frekvens", Frekvens);
                XElement cat = new XElement("Kategori", Kategori);
                test.Add(tag, frek, cat);
                outElm.Add(test);    
            }*/
            /*document = new XDocument(new XElement("Podcast",
            from item in listView.Items.Cast<ListViewItem>()
            select new XElement("Podcast" + url,
                item.SubItems.Cast<ListViewSubItem>()
                .Select((subItem, i) => new XAttribute(

                        listView.Columns[i].Text, 
                        subItem.Text

                        )))));*/
            
            //test.Add(URL, frek, cat);
            
           
            //outElm.Add(test);
            //document.Element("Podcast").Add(outElm);
            //document.Add(outElm);

            document = new XDocument();
            if(File.Exists("Poddar.xml"))
            {
                document = XDocument.Load("Poddar.xml");
            }else
            {
                MessageBox.Show("No such file Exists'");
            }

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
            XElement outElm = new XElement("Kategorier");

            foreach(var cat in category)
            {
                outElm.Add(new XElement("Kategori", cat));
            }

            document.Add(outElm);
            document.Save("Kategorier.xml");
        }

        /*public void SaveEpisodes(Dictionary<string, List<string>> dic)
        {

            document = new XDocument();
            XElement outElm = new XElement("Podcast");
            
            foreach (var kv in dic)
            {
                outElm.Add(new XElement("AvsnittKey", kv.Key));
                for(int i = 0; i < kv.Value.Count; i++)
                {
                    outElm.Add(new XElement("AvsnittValue", kv.Value[i]));
                }
            }
            document.Add(outElm);
           
            document.Save("Avsnitt.xml");
        }

        public void SaveSummary(Dictionary<string, List<string>> dic)
        {

            document = new XDocument();
            XElement outElm = new XElement("Podcast");

            foreach (var kv in dic)
            {
                outElm.Add(new XElement("SummaryKey", kv.Key));
                for (int i = 0; i < kv.Value.Count; i++)
                {
                    outElm.Add(new XElement("SummaryValue", kv.Value[i]));
                }
            }
            document.Add(outElm);
            document.Save("Summary.xml");
        }*/
    }
}
