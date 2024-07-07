using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo24
{
    public class Gehege
    {
        private int gehegeNr;
        private string gehegeName;
        private int gehegeGroesse;
        private int gehegeKontinentNr;
        public int GehegeNr { get => gehegeNr; set => gehegeNr = value; }
        public string GehegeName { get => gehegeName; set => gehegeName = value; }
        public int GehegeGroesse { get => gehegeGroesse; set => gehegeGroesse = value; }
        public int GehegeKontinentNr { get => gehegeKontinentNr; set => gehegeKontinentNr = value; }

        public Gehege( int geNr, string geName, int geGroesse, int geKontinentNr)
        {
            GehegeNr = geNr;
            GehegeName = geName;
            GehegeGroesse = geGroesse;
            GehegeKontinentNr = geKontinentNr;
        }
    }
}
