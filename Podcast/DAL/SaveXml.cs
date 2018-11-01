﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.ListViewItem;

namespace Podcast.DAL
{
    class SaveXml
    {
        XDocument document;

        public void SavePodcast(ListView listView)
        {
            document = new XDocument(new XElement("Podcast",
            from item in listView.Items.Cast<ListViewItem>()
            select new XElement("Podcast",
                item.SubItems.Cast<ListViewSubItem>()
                    .Select((subItem, i) => new XAttribute(
                        listView.Columns[i].Text.ToLower(),
                        subItem.Text)))));
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

        public void SaveEpisodes(Dictionary<string, List<string>> dic)
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
            /*document = new XDocument(new XElement("Podcast",
                from kv in dic
                select new XElement("AvsnittNyckel",
                   kv.Key,
                   new XElement("AvsnittValue"),
                   kv.Value)));*/
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
            /*document = new XDocument(new XElement("Podcast",
                from kv in dic
                select new XElement("AvsnittNyckel",
                   kv.Key,
                   new XElement("AvsnittValue"),
                   kv.Value)));*/
            document.Save("Summary.xml");
        }
    }
}
