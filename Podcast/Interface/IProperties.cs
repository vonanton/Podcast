﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podcast.Interface
{
    interface IProperties
    {
        string Episodes { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        //public abstract ListViewItem ToListViewItem();
    }
}
