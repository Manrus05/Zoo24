using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo24
{
    public class Tier
    {
        private int tierNr;
        private string tierName;
        private DateTime tierGebDat;
        private string tierHerkunft;
        private int tierGehege;
        private int tierTierart;
        private Boolean tierGeschlecht;
        public int TierNr { get => tierNr; set => tierNr = value; }
        public string TierName { get => tierName; set => tierName = value; }
        public DateTime TierGebDat { get => tierGebDat; set => tierGebDat = value; }
        public string TierHerkunft { get => tierHerkunft; set => tierHerkunft = value; }
        public int TierGehege { get => tierGehege; set => tierGehege = value; }
        public int TierTierart { get => tierTierart; set => tierTierart = value; }
        public bool TierGeschlecht { get => tierGeschlecht; set => tierGeschlecht = value; }
        public Tier(int tNr, string tName, DateTime tGebDat, 
            string tHerkunft, int tGehege, int tTierart, bool tGeschlecht)
        {
            TierNr = tNr;
            TierName = tName;
            TierGebDat = tGebDat;
            TierHerkunft = tHerkunft;
            TierGehege = tGehege;
            TierTierart = tTierart;
            TierGeschlecht = tGeschlecht;
        }
    }
}
