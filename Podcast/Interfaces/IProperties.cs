using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Interfaces
{
    interface IProperties
    {
        string Episodes { get; set; }
        string Title { get; set; }
    }
}
