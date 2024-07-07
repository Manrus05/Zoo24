using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo24
{
    public class GehegeTier
    {
        private int tnr;
        private string tname;
        private string taname;
        public int Tnr { get => tnr; set => tnr = value; }
        public string Tname { get => tname; set => tname = value; }
        public string Taname { get => taname; set => taname = value; }
        public GehegeTier(int nr, string tna, string tana ) 
        {
            tnr = nr;
            tname = tna;
            taname = tana;
        }
    }
}
