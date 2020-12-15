using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_scheduler
{
    public partial class FUserStory : Form
    {
        KanbanDatabaseEntities context = new KanbanDatabaseEntities();
        int current_ID = 0;

        public FUserStory(int ID)
        {
            InitializeComponent();

            GetCurrentUserStory(ID);

        }

        private void GetCurrentUserStory(int ID)
        {
            var people_list = from x in context.People select x.NAME;
            cb_Tulajdonos.DataSource = people_list.ToList();

            var period_list = from x in context.PERIODs select x.PERIOD_NAME;
            cb_Idoszak.DataSource = period_list.ToList();

            if (ID != 0)
            {
                var current_item = from u in context.USERSTORies
                                   join p in context.PERIODs on u.PERIOD_FK equals p.PERIOD_SK
                                   join pr in context.People on u.PERSON_FK equals pr.PERSON_SK
                                   where u.USERSTORY_SK == ID
                                   select new { u.USERSTORY_SK, u.TASK, u.PERSON_FK, pr.NAME, u.PERIOD_FK, p.PERIOD_NAME, u.STATUS, u.PRIORITY };

                foreach (var item in current_item)
                {
                    current_ID = item.USERSTORY_SK;
                    textBox1.Text = item.TASK;
                    cb_Tulajdonos.SelectedItem = item.NAME;
                    cb_Idoszak.SelectedItem = item.PERIOD_NAME;
                    cb_Allapot.SelectedItem = item.STATUS;
                    cb_Fontossag.SelectedItem = item.PRIORITY;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && cb_Tulajdonos.SelectedItem != null && cb_Idoszak.SelectedItem != null && cb_Allapot.SelectedItem != null && cb_Fontossag.SelectedItem != null)
            {
                int person_FK = cb_Tulajdonos.SelectedIndex + 1;
                int period_FK = cb_Idoszak.SelectedIndex + 1;
                var current_person = from p in context.People
                                     where p.NAME == cb_Tulajdonos.SelectedItem.ToString()
                                     select p.PERSON_SK;

                if (current_ID != 0)
                {
                    var current_item = from u in context.USERSTORies
                                       where u.USERSTORY_SK == current_ID
                                       select u;

                    foreach (var item in current_item)
                    {
                        item.TASK = textBox1.Text.ToString();
                        item.PERSON_FK = person_FK;
                        item.PERIOD_FK = period_FK;
                        item.STATUS = cb_Allapot.SelectedItem.ToString();
                        item.PRIORITY = cb_Fontossag.SelectedItem.ToString();
                    }
                }
                else
                {
                    USERSTORY us = new USERSTORY();
                    us.TASK = textBox1.Text.ToString();
                    us.PERSON_FK = person_FK;
                    us.PERIOD_FK = period_FK;
                    us.STATUS = cb_Allapot.SelectedItem.ToString();
                    us.PRIORITY = cb_Fontossag.SelectedItem.ToString();
                    context.USERSTORies.Add(us);
                }
                try
                {
                    context.SaveChanges();
                    this.Close();
                    UCKanban uck = new UCKanban();

                    if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).FoPanel.Controls.Clear();
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).FoPanel.Controls.Add(uck);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Töltsön ki minden mezőt!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current_ID != 0)
            {
                var current_item = from u in context.USERSTORies
                                   where u.USERSTORY_SK == current_ID
                                   select u;
                context.USERSTORies.Remove(current_item.FirstOrDefault());

                try
                {
                    context.SaveChanges();
                    this.Close();
                    UCKanban uck = new UCKanban();

                    if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).FoPanel.Controls.Clear();
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).FoPanel.Controls.Add(uck);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy létező elemet!");
            }
        }
    }
}
