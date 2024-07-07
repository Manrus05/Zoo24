using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo24
{
    public class Kontinent
    {
        private int kontNr;
        private string kontName;
        public int KontNr { get => kontNr; set => kontNr = value; }
        public string KontName { get => kontName; set => kontName = value; }
        public Kontinent( int knr, string kn)
        {
            kontNr = knr;
            kontName = kn;
        }
    }
}
