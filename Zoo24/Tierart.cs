using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo24
{
    public class Tierart
    {
        private int tierartNr;
        private string tierartName;
        public int TierartNr { get => tierartNr; set => tierartNr = value; }
        public string TierartName { get => tierartName; set => tierartName = value; }

        public Tierart( int nr, string name)
        {
            tierartNr = nr;
            tierartName = name;
        }
    }
}
