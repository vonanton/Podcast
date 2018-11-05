using Podcast.DAL;
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
        public List<string> ListOfCategorys = new List<string>();
        SaveXml saveXml = new SaveXml();


        public override void Add(ListView listView, string categoryText)
        {
            string Category = categoryText;
            ListOfCategorys.Add(Category);
            saveXml.SaveCategory(ListOfCategorys);
            base.Add(listView, Category);
        }

        public void AddCategoryXml(ListView listView, string categoryText)
        {
            string Category = categoryText;
            ListOfCategorys.Add(Category);
            
            base.Add(listView, Category);
        }

        public override void SaveChanges(ListView lvCategory, ListView lvPodcast, TextBox categoryText)
        {
            string newCategory = categoryText.Text;
            
            ListOfCategorys.Remove(lvCategory.SelectedItems[0].Text);
            ListOfCategorys.Add(newCategory);
            base.SaveChanges(lvCategory, lvPodcast, categoryText);
        }

        public override void Remove(ListView listView)
        {
            ListOfCategorys.Remove(listView.SelectedItems[0].Text);
            base.Remove(listView);
        }
    }
}
