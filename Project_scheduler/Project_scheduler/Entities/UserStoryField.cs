using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_scheduler.Entities
{
    public class UserStoryField : Button
    {
        int ox, oy;
        bool moving = false;

        public int ID { get; set; }

        private Priority _priority;

        public Priority Priority
        {
            get { return _priority; }
            set 
            { 
                _priority = value;
                if (_priority == Priority.Alacsony)
                {
                    BackColor = ColorTranslator.FromHtml("#8b9476");
                    FlatAppearance.MouseOverBackColor = this.BackColor;
                }
                else if (_priority == Priority.Közepes)
                {
                    BackColor = ColorTranslator.FromHtml("#fff7f5");
                    FlatAppearance.MouseOverBackColor = this.BackColor;
                }
                else if (_priority == Priority.Magas)
                {
                    BackColor = ColorTranslator.FromHtml("#c75266");
                    FlatAppearance.MouseOverBackColor = this.BackColor;
                }
            }
        }


        public UserStoryField()
        {
            Height = 80;
            Width = 190;
            Font = new Font(Font.FontFamily, 9);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;
            BackColor = ColorTranslator.FromHtml("#fff7f5");
            FlatAppearance.MouseOverBackColor = this.BackColor;
            FlatStyle = FlatStyle.Flat;
            
            MouseDown += UserStoryField_MouseDown;
            MouseMove += UserStoryField_MouseMove;
            MouseUp += UserStoryField_MouseUp;
        }

        private void UserStoryField_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;

            int oszlop = 635;
            int o_korabbi_poz = 635;
            int o_pozicio;

            int sor = 450;
            int s_korabbi_poz = 450;
            int s_pozicio;

            for (int i = 5; i <= 635; i += 210)
            {
                o_pozicio = Math.Abs((this.Left += e.X - ox) - i);
                if (o_pozicio < o_korabbi_poz)
                {
                    o_korabbi_poz = o_pozicio;
                    oszlop = i;
                }
            }

            for (int j = 0; j < 450; j += 90)
            {
                s_pozicio = Math.Abs((this.Top += e.Y - oy) - j);
                if (s_pozicio < s_korabbi_poz)
                {
                    s_korabbi_poz = s_pozicio;
                    sor = j;
                }
            }

            this.Left = oszlop;
            this.Top = sor;
        }

        private void UserStoryField_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Top += e.Y - oy;
                Left += e.X - ox;
            }
        }

        private void UserStoryField_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            ox = e.X;
            oy = e.Y;

            if (e.Clicks == 2)
            {
                moving = false;
                FUserStory fus = new FUserStory(ID);
                fus.Show();
            }
        }


    }


}
