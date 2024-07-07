using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo24
{
    public class GehegeTiere
    {
        private string gehegeName;
        private int tierAnzahl;

        public string GehegeName { get => gehegeName; set => gehegeName = value; }
        public int TierAnzahl { get => tierAnzahl; set => tierAnzahl = value; }

        public GehegeTiere(string gname, int anz) 
        { 
            GehegeName = gname;
            tierAnzahl = anz; 
        }
    }
}
