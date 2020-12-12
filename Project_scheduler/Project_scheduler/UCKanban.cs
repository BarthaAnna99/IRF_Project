using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_scheduler.Entities;

namespace Project_scheduler
{
    //22 - 283 - 544 - 805
    public partial class UCKanban : UserControl
    {
        public UCKanban()
        {
            InitializeComponent();

            TaskField tf = new TaskField();
            panel_All.Controls.Add(tf);
        }
    }
}
