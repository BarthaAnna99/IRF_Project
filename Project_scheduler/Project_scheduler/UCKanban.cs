﻿using System;
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
        KanbanDatabaseEntities context = new KanbanDatabaseEntities();

        public UCKanban()
        {
            InitializeComponent();
            
            var idoszakok = (from x in context.PERIODs select x.PERIOD_NAME).ToList();
            comboBox1.DataSource = idoszakok;
            comboBox1.SelectedItem = "12.14. - 12.20.";

            GetKanbanField();
        }

        private void UCKanban_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetKanbanField();
        }

        public void GetKanbanField()
        {
            panel_All.Controls.Clear();
            string idoszak = comboBox1.SelectedItem.ToString();

            var idoszak_backlog = from u in context.USERSTORies
                                  join p in context.PERIODs on u.PERIOD_FK equals p.PERIOD_SK
                                  join pr in context.People on u.PERSON_FK equals pr.PERSON_SK
                                  where p.PERIOD_NAME == idoszak && u.STATUS == "Backlog"
                                  select new { u.USERSTORY_SK, u.TASK, pr.NAME, p.PERIOD_NAME, u.STATUS, u.PRIORITY };
            var idoszak_kivalasztva = from u in context.USERSTORies
                                  join p in context.PERIODs on u.PERIOD_FK equals p.PERIOD_SK
                                  join pr in context.People on u.PERSON_FK equals pr.PERSON_SK
                                  where p.PERIOD_NAME == idoszak && u.STATUS == "Kiválasztva"
                                  select new { u.USERSTORY_SK, u.TASK, pr.NAME, p.PERIOD_NAME, u.STATUS, u.PRIORITY };
            var idoszak_folyamatban = from u in context.USERSTORies
                                      join p in context.PERIODs on u.PERIOD_FK equals p.PERIOD_SK
                                      join pr in context.People on u.PERSON_FK equals pr.PERSON_SK
                                      where p.PERIOD_NAME == idoszak && u.STATUS == "Folyamatban"
                                      select new { u.USERSTORY_SK, u.TASK, pr.NAME, p.PERIOD_NAME, u.STATUS, u.PRIORITY };
            var idoszak_kesz = from u in context.USERSTORies
                                     join p in context.PERIODs on u.PERIOD_FK equals p.PERIOD_SK
                                     join pr in context.People on u.PERSON_FK equals pr.PERSON_SK
                                     where p.PERIOD_NAME == idoszak && u.STATUS == "Kész"
                                     select new { u.USERSTORY_SK, u.TASK, pr.NAME, p.PERIOD_NAME, u.STATUS, u.PRIORITY };

            int szamlalo1 = 0;
            foreach (var item in idoszak_backlog)
            {
                UserStoryField us = new UserStoryField();
                us.Top = szamlalo1 * 80 + szamlalo1 * 10;
                us.Left = 5;
                us.ID = item.USERSTORY_SK;
                us.Priority = (Priority)Enum.Parse(typeof(Priority), item.PRIORITY); //(YourEnum) Enum.Parse(typeof(YourEnum), yourString);
                us.Text = item.TASK + "\n" + item.NAME;
                panel_All.Controls.Add(us);

                us.MouseUp += Us_MouseUp;
                szamlalo1++;
            }

            int szamlalo2 = 0;
            foreach (var item in idoszak_kivalasztva)
            {
                UserStoryField us = new UserStoryField();
                us.Top = szamlalo2 * 80 + szamlalo2 * 10;
                us.Left = 5 + 190 + 20;
                us.ID = item.USERSTORY_SK;
                us.Priority = (Priority)Enum.Parse(typeof(Priority), item.PRIORITY);
                us.Text = item.TASK + "\n" + item.NAME;
                panel_All.Controls.Add(us);


                us.MouseUp += Us_MouseUp;
                szamlalo2++;
            }

            int szamlalo3 = 0;
            foreach (var item in idoszak_folyamatban)
            {
                UserStoryField us = new UserStoryField();
                us.Top = szamlalo3 * 80 + szamlalo3 * 10;
                us.Left = 5 + 2 * 190 + 2 * 20;
                us.ID = item.USERSTORY_SK;
                us.Priority = (Priority)Enum.Parse(typeof(Priority), item.PRIORITY);
                us.Text = item.TASK + "\n" + item.NAME;
                panel_All.Controls.Add(us);

                us.MouseUp += Us_MouseUp;
                szamlalo3++;
            }

            int szamlalo4 = 0;
            foreach (var item in idoszak_kesz)
            {
                UserStoryField us = new UserStoryField();
                us.Top = szamlalo4 * 80 + szamlalo4 * 10;
                us.Left = 5 + 3 * 190 + 3 * 20;
                us.ID = item.USERSTORY_SK;
                us.Priority = (Priority)Enum.Parse(typeof(Priority), item.PRIORITY);
                us.Text = item.TASK + "\n" + item.NAME;
                panel_All.Controls.Add(us);

                us.MouseUp += Us_MouseUp;
                szamlalo4++;
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
                    var modositas = from x in context.USERSTORies
                                    where row_item.ID == x.USERSTORY_SK
                                    select x;
                    if (row_item.Left == 5)
                    {
                        foreach (USERSTORY item in modositas)
                        {
                            item.STATUS = "Backlog";
                        }
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (row_item.Left == 215)
                    {
                        foreach (USERSTORY item in modositas)
                        {
                            item.STATUS = "Kiválasztva";
                        }
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (row_item.Left == 425)
                    {
                        foreach (USERSTORY item in modositas)
                        {
                            item.STATUS = "Folyamatban";
                        }
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (row_item.Left == 635)
                    {
                        foreach (USERSTORY item in modositas)
                        {
                            item.STATUS = "Kész";
                        }
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    szamlalo++;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetKanbanField();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FUserStory fus = new FUserStory(0);
            fus.ShowDialog();
        }
    }
}
