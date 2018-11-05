using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Podcast.BLL
{
    public class ValidateMessages
    {
        public void ItemNotSelected()
        {
            MessageBox.Show("Du måste markera den du vill ändra/ta bort.");
        }
        public void UrlEmpty()
        {
            MessageBox.Show("URL-fältet är tomt.");
        }
        public void CategoryEmpty()
        {
            MessageBox.Show("Kategori-fältet är tomt.");
        }
        public void FrekvensEmpty()
        {
            MessageBox.Show("Du måste ange ett uppdateringsintervall.");
        }
        public void ValidUrl()
        {
            MessageBox.Show("Du måste ha en giltig RSS-URL.");
        }
        public void DuplicateUrl()
        {
            MessageBox.Show("Du har redan lagt in denna podcast med denna url.");
        }

    }
}
