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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UCKanban uc = new UCKanban();
            FoPanel.Controls.Clear();
            FoPanel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnKanban_Click(object sender, EventArgs e)
        {
            UCKanban uc = new UCKanban();
            FoPanel.Controls.Clear();
            FoPanel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnJelentes_Click(object sender, EventArgs e)
        {
            UCJelentes uc = new UCJelentes();
            FoPanel.Controls.Clear();
            FoPanel.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
