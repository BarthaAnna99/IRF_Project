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
    public partial class UCKanban : UserControl
    {
        public UCKanban()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    UserStoryField us = new UserStoryField();
                    us.Top = j * 80 + j * 10;
                    us.Left = 5 + i * 190 + i * 20;
                    panel_All.Controls.Add(us);

                    us.MouseUp += Us_MouseUp;
                }
            }
        }

        private void Us_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (UserStoryField item in panel_All.Controls)
            {
                int szamlalo = 0;

                foreach (UserStoryField current_item in panel_All.Controls)
                {
                    if (item.Left == current_item.Left && item.Top == current_item.Top)
                    {
                        szamlalo++;
                    }
                }

                if (szamlalo == 2)
                {
                    foreach (UserStoryField other_item in panel_All.Controls)
                    {
                        if (other_item.Left == item.Left && other_item.Top >= item.Top)
                        {
                            other_item.Top += 90;
                        }
                    }
                }
            }

            for (int i = 5; i <= 635; i += 210)
            {
                int szamlalo = 0;
                foreach (UserStoryField row_item in panel_All.Controls.OfType<UserStoryField>().Where(j => j.Left == i).OrderBy(j => j.Top))
                {
                    row_item.Top = szamlalo * 80 + szamlalo * 10;
                    szamlalo++;
                }
            }
        }
    }
}
