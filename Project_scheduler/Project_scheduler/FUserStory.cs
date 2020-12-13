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

        int current_ID;
        public FUserStory(int ID)
        {
            InitializeComponent();

            var people_list = from x in context.People select x.NAME;
            cb_Tulajdonos.DataSource = people_list.ToList();

            var period_list = from x in context.PERIODs select x.PERIOD_NAME;
            cb_Idoszak.DataSource = period_list.ToList();

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
                cb_Tulajdonos.SelectedIndex = item.PERSON_FK;
                cb_Idoszak.SelectedItem = item.PERIOD_NAME;
                cb_Idoszak.SelectedIndex = item.PERSON_FK;
                cb_Allapot.SelectedItem = item.STATUS;
                cb_Fontossag.SelectedItem = item.PRIORITY;
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var current_item = from u in context.USERSTORies
                               join p in context.PERIODs on u.PERIOD_FK equals p.PERIOD_SK
                               join pr in context.People on u.PERSON_FK equals pr.PERSON_SK
                               where u.USERSTORY_SK == current_ID
                               select new { u.USERSTORY_SK, u.TASK, pr.NAME, p.PERIOD_NAME, u.STATUS, u.PRIORITY };

            foreach (var item in current_item)
            {
                item.TASK = textBox1.Text.ToString();
                cb_Tulajdonos.SelectedItem = item.NAME;
                cb_Idoszak.SelectedItem = item.PERIOD_NAME;
                cb_Allapot.SelectedItem = item.STATUS;
                cb_Fontossag.SelectedItem = item.PRIORITY;
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
    }
}
