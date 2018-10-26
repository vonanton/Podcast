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
        List<string> Episodes { get; set; }
        string EpisodeCount { get; set; }
        string Title { get; set; }
    }
}
