using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_scheduler.Entities
{
    public class Jelentes
    {
        public string Név { get; set; }
        public int Összesen { get; set; }
        public int Backlog { get; set; }
        public int Kiválasztva { get; set; }
        public int Folyamatban { get; set; }
        public int Kész { get; set; }
    }
}
