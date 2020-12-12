using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_scheduler.Entities
{
    public class TaskField : Button
    {
        int ox, oy;
        bool moving = false;

        public TaskField()
        {
            Height = 90;
            Width = 190;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;
            FlatStyle = FlatStyle.Flat;
            BackColor = ColorTranslator.FromHtml("#fff7f5");

            MouseDown += TaskField_MouseDown;
            MouseMove += TaskField_MouseMove;
            MouseUp += TaskField_MouseUp;
        }


        private void TaskField_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void TaskField_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Top += e.Y - oy;
                Left += e.X - ox;
            }
        }

        private void TaskField_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            ox = e.X;
            oy = e.Y;

            if (e.Clicks == 2)
            {
                FUserStory fus = new FUserStory();
                /*DialogResult result = */
                fus.ShowDialog();
            }
        }
    }


}
