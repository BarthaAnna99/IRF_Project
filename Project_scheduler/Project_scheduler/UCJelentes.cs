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
    
    public partial class UCJelentes : UserControl
    {
        KanbanDatabaseEntities context = new KanbanDatabaseEntities();
        List<Jelentes> jelentes = new List<Jelentes>();
        List<Diagram> diagrams = new List<Diagram>();

        public UCJelentes()
        {
            InitializeComponent();


            GetJelentes();
            dataGridView1.DataSource = jelentes.ToList();
            //GetDiagram();
        }

        private void GetDiagram()
        {
            diagrams.Clear();
            string current_name;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                current_name = dataGridView1.FirstDisplayedCell.Value.ToString();
            }
            else
            {
                current_name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            var adatok = from x in jelentes
                         where x.Név == current_name
                         select x;
            foreach (var item in adatok)
            {
                Diagram d = new Diagram();
                d.Tipus = "Backlog";
                d.Érték = item.Backlog;
                diagrams.Add(d);
                Diagram d2 = new Diagram();
                d2.Tipus = "Kiválasztva";
                d2.Érték = item.Kiválasztva;
                diagrams.Add(d2);
                Diagram d3 = new Diagram();
                d3.Tipus = "Folyamatban";
                d3.Érték = item.Folyamatban;
                diagrams.Add(d3);
                Diagram d4 = new Diagram();
                d4.Tipus = "Kész";
                d4.Érték = item.Kész;
                diagrams.Add(d4);
            }
            DiagrambindingSource.DataSource = diagrams.ToList();
            chart1.DataBind();
        }

        private void GetJelentes()
        {
            var adatok = from u in context.USERSTORies
                         group u by u.PERSON_FK into x
                         join pr in context.People on x.Key equals pr.PERSON_SK
                         select new
                         {
                             Név = pr.NAME,
                             Összes = x.Count(),
                             Backlog = x.Where(v => v.STATUS == "Backlog").Count(),
                             Kiválasztva = x.Where(v => v.STATUS == "Kiválasztva").Count(),
                             Folyamatban = x.Where(v => v.STATUS == "Folyamatban").Count(),
                             Kész = x.Where(v => v.STATUS == "Kész").Count(),
                         };
            foreach (var item in adatok.ToList())
            {
                Jelentes j = new Jelentes();
                j.Név = item.Név;
                j.Összesen = item.Összes;
                j.Backlog = item.Backlog;
                j.Kiválasztva = item.Kiválasztva;
                j.Folyamatban = item.Folyamatban;
                j.Kész = item.Kész;
                jelentes.Add(j);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            GetDiagram();
        }

    }
}
