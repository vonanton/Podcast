﻿using Podcast.DAL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Podcast.BLL
{
    class Category : Podcast
    {
        public List<string> ListOfCategorys = new List<string>();
        SaveXml saveXml = new SaveXml();
        ValidateMessages validation = new ValidateMessages();

        public override void Add(ListView listView, string categoryText)
        {
            string Category = categoryText;
            ListOfCategorys.Add(Category);
            saveXml.SaveCategory(ListOfCategorys);
            base.Add(listView, Category);
        }

        public void AddCategoryXml(ListView listView)
        {
            LoadXml loadXml = new LoadXml();
            loadXml.LoadCategory(ListOfCategorys);

            foreach(var category in ListOfCategorys)
            {
                base.Add(listView, category);
            }
        }

        public override void SaveChanges(ListView lvCategory, TextBox categoryText)
        {
            string newCategory = categoryText.Text;
            ListOfCategorys.Remove(lvCategory.SelectedItems[0].Text);
            ListOfCategorys.Add(newCategory);
            saveXml.SaveCategory(ListOfCategorys);
            base.SaveChanges(lvCategory, categoryText);
        }

        public override void Remove(ListView listView)
        {
            ListOfCategorys.Remove(listView.SelectedItems[0].Text);
            saveXml.SaveCategory(ListOfCategorys);
            base.Remove(listView);
        }
    }
}