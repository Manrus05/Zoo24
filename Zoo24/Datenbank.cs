using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo24
{
    public class Datenbank
    {
        private MySqlConnection con;

        public Datenbank()
        {
            string conStr = "SERVER=localhost;DATABASE=Zoo;" +
                "UID=root;PASSWORD=''";
            con = new MySqlConnection(conStr);
        }
        private void oeffnen()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void schliessen()
        {
            if(con != null)
            {
                con.Close();
            }
        }
        public int getTiereInGehege( int gnr )
        {
            int anz = 0;

            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM tiere " +
                "WHERE TGehege = " + gnr + ";";
             
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                anz = dr.IsDBNull(0) ? 0 : dr.GetInt32(0);            
            }
            dr.Close();
            schliessen();
            return anz;
        }
        public List<GehegeTiere> getAnzTiere()
        {
            List<GehegeTiere> lige = new List<GehegeTiere>();

            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText =
                "SELECT gename, COUNT(TNr) " +
                "FROM tiere RIGHT JOIN gehege " +
                "ON genr= tgehege " +
                "GROUP BY gename " +
                "ORDER BY gename;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                lige.Add(
                    new GehegeTiere(
                        dr.IsDBNull(0) ? "" : dr.GetString(0),   //Tiername
                        dr.IsDBNull(1) ? 0 : dr.GetInt32(1)    //Tierart
                        )
                    );
            }
            dr.Close();
            schliessen();
            return lige;
        }
        public List<GehegeTier> GetGehegeTier(int genr) 
        {
            List<GehegeTier> ligeti = new List<GehegeTier>();

            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = 
                "SELECT * FROM gehegetier WHERE genr="+genr.ToString()+";";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                ligeti.Add(
                    new GehegeTier(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),    //TierNr
                        dr.IsDBNull(1) ? "" : dr.GetString(1),   //Tiername
                        dr.IsDBNull(2) ? "" : dr.GetString(2)    //Tierart
                        )
                    );
            }
            dr.Close();
            schliessen();

            return ligeti;
        }
        public void saveTier(Tier tier)
        {
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            string s;
            string dat = tier.TierGebDat.Year.ToString() // 2024
                + "-" + tier.TierGebDat.Month.ToString() // -06
                + "-" + tier.TierGebDat.Day.ToString();  // -01

            s = string.Format("INSERT INTO tiere " +
                "VALUES( NULL, '{0}', '{1}','{2}', {3}, {4}, {5});", 
                    tier.TierName, dat, tier.TierHerkunft,
                    tier.TierGehege, tier.TierTierart,
                    tier.TierGeschlecht);

            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            schliessen();
        }
        public List<Tier> getTiere()
        {
            List<Tier> liti = new List<Tier>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM tiere;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string s = dr.IsDBNull(2) ? "" : dr.GetDateTime(2).Day + 
                                                   "." + dr.GetDateTime(2).Month +
                                                   "." + dr.GetDateTime(2).Year;
                liti.Add(
                    new Tier(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),    //TierNr
                        dr.IsDBNull(1) ? "" : dr.GetString(1),   //Tiername
                        Convert.ToDateTime(s),                                       //GebDat
                        dr.IsDBNull(3) ? "" : dr.GetString(3),   //Herkunft
                        dr.IsDBNull(4) ? -1 : dr.GetInt32(4),    //GehegeNr
                        dr.IsDBNull(5) ? -1 : dr.GetInt32(5),    //Tierart
                        dr.IsDBNull(6) ? true : dr.GetBoolean(6) //Geschlecht
                        )
                    );
            }
            dr.Close();
            schliessen();

            return liti;
        }
        public List<Tierart> getTierarten() 
        {
            List<Tierart> liTiA = new List<Tierart>();

            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM tierart;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liTiA.Add(
                    new Tierart(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1)
                        )
                    );
            }
            dr.Close();
            schliessen();

            return liTiA;
        }
        public void saveTierart( string taname )
        {
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            string s;
            
            s = string.Format("INSERT INTO tierart " +
                "VALUES( NULL, '{0}');", taname);
            
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            schliessen();
        }
        public void delGehege(string gnr )
        {
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            string s;

            s = string.Format("DELETE FROM gehege " +
                "WHERE GeNr = {0};", gnr);
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            schliessen();
        }
        public void saveGehege( Gehege gehege)
        {
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            string s;
            if (gehege.GehegeNr != -1)
            {
                s = string.Format("UPDATE gehege " +
                                        "SET gename = '{0}', " +
                                        "gegroesse = {1}, " +
                                        "gekontnr = {2} " +
                                        "WHERE geNr = {3};",
                                        gehege.GehegeName,
                                        gehege.GehegeGroesse,
                                        gehege.GehegeKontinentNr,
                                        gehege.GehegeNr);
            }
            else
            {
                s = string.Format("INSERT INTO gehege " +
                    "VALUES( NULL, '{0}', {1}, {2});", 
                    gehege.GehegeName,
                    gehege.GehegeGroesse,
                    gehege.GehegeKontinentNr);
            }
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            schliessen();
        }    
        public List<Gehege> getGehege()
        {
            List<Gehege> liGe = new List<Gehege>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM gehege;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liGe.Add(
                    new Gehege(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? -1 : dr.GetInt32(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                        )
                    );
            }
            dr.Close();
            schliessen();

            return liGe;
        }
        public List<Kontinent> getKontinente()
        {
            List<Kontinent> liKo = new List<Kontinent>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM kontinent;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liKo.Add(
                    new Kontinent(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1)
                        )
                    );
            }
            dr.Close();
            schliessen();
            return liKo;
        }
        public void delKontinent( string knr)
        {
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            string s;

            s = string.Format("DELETE FROM kontinent " +
                "WHERE kontNr = {0};", knr);                                 
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            schliessen();
        }
        public void saveKontinent(string knr, string kname)
        {
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            string s;
            if (knr != "")
            {
                s = string.Format("UPDATE kontinent " +
                                        "SET kontname = '{0}' " +
                                        "WHERE kontNr = {1};",
                                        kname, knr);
            }
            else
            {
                s = string.Format("INSERT INTO kontinent " +
                    "VALUES( NULL, '{0}');", kname);
            }
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            schliessen();
        }
    }
}
