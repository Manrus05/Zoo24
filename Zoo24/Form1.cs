namespace Zoo24
{
    public partial class Form1 : Form
    {
        private List<Kontinent> kontinentList;
        private List<Gehege> gehegeList;
        private List<Tierart> tierartList;
        private List<Tier> tierList;
        private List<GehegeTiere> gehegeTiereList;

        private Datenbank db = new Datenbank();
        public Form1()
        {
            InitializeComponent();

            dispKontinente();
            dispGehege();
            dispTierarten();
            dispTiere();
            dispView();
            dispGehegeAnzTiere();
        }
        private void dispGehegeAnzTiere()
        {
            gehegeTiereList = db.getAnzTiere();
            listBox1.Items.Clear();

            foreach (GehegeTiere gt in gehegeTiereList)
            {
                listBox1.Items.Add(gt.GehegeName.PadRight(30) + gt.TierAnzahl.ToString());
            }

            listBox2.Items.Clear();

            foreach (Gehege g in gehegeList)
            {
                listBox2.Items.Add(g.GehegeName + " " + db.getTiereInGehege(g.GehegeNr));
            }
        }
        private void dispView()
        {
            dgvUebersicht.Rows.Clear();

            foreach (Tier t in tierList)
            {
                string gehege =
                    gehegeList.Find(x => x.GehegeNr == t.TierGehege).GehegeName;
                string tierart =
                tierartList.Find(x => x.TierartNr == t.TierTierart).TierartName;

                dgvUebersicht.Rows.
                    Add(t.TierNr, t.TierName, tierart, t.TierGebDat.ToString("dd.MM.yyyy"), gehege);
            }
        }
        private void dispTiere()
        {
            tierList = db.getTiere();
            libTiere.Items.Clear();

            foreach (Tier tier in tierList)
            {
                libTiere.Items.Add(tier.TierName);
            }
        }
        private void dispTierarten()
        {
            tierartList = db.getTierarten();
            libTierart.Items.Clear();
            comboBox2.Items.Clear();

            foreach (Tierart ta in tierartList)
            {
                libTierart.Items.Add(ta.TierartName);
                cbTierart.Items.Add(ta.TierartName);
                comboBox2.Items.Add(ta.TierartName);
            }
        }
        private void dispGehege()
        {
            gehegeList = db.getGehege();
            libGehege.Items.Clear();
            comboBox1.Items.Clear();

            foreach (Gehege g in gehegeList)
            {
                libGehege.Items.Add(g.GehegeName);
                cbTiergehege.Items.Add(g.GehegeName);
                comboBox1.Items.Add(g.GehegeName);
            }
        }
        private void dispKontinente()
        {
            kontinentList = db.getKontinente();
            libKontinente.Items.Clear();
            cbKontinente.Items.Clear();

            foreach (Kontinent k in kontinentList)
            {
                libKontinente.Items.Add(k.KontName);
                cbKontinente.Items.Add(k.KontName);
            }
        }
        private void libKontinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libKontinente.SelectedIndex != -1)
            {
                tbKontNr.Text =
                    kontinentList[libKontinente.SelectedIndex].
                    KontNr.ToString();
                tbKontName.Text = kontinentList[libKontinente.SelectedIndex].
                    KontName;

            }
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            db.saveKontinent(tbKontNr.Text, tbKontName.Text);
            dispKontinente();
        }
        private void btnNeu_Click(object sender, EventArgs e)
        {
            tbKontNr.Text = "";
            tbKontName.Text = "";
            libKontinente.SelectedIndex = -1;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.delKontinent(tbKontNr.Text);
            dispKontinente();
            tbKontNr.Text = "";
            tbKontName.Text = "";
        }
        private void libGehege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libGehege.SelectedIndex != -1)
            {
                tbGehegeNr.Text =
                    gehegeList[libGehege.SelectedIndex].GehegeNr.ToString();
                tbGehegeName.Text =
                    gehegeList[libGehege.SelectedIndex].GehegeName;
                tbGehegeGroesse.Text =
                    gehegeList[libGehege.SelectedIndex].GehegeGroesse.ToString();

                int index = kontinentList.FindIndex(x => x.KontNr == gehegeList[libGehege.SelectedIndex].GehegeKontinentNr);
                cbKontinente.SelectedIndex = index;



            }
        }
        private void btnGehegeNeu_Click(object sender, EventArgs e)
        {
            tbGehegeNr.Text = "";
            tbGehegeName.Text = "";
            tbGehegeGroesse.Text = "";
            cbKontinente.SelectedIndex = -1;
        }
        private void btnGehSpeichern_Click(object sender, EventArgs e)
        {
            int konr = kontinentList[cbKontinente.SelectedIndex].KontNr;
            int gehegenr = tbGehegeNr.Text == "" ? -1 : Convert.ToInt32(tbGehegeNr.Text);

            Gehege ge = new Gehege(
                    gehegenr,
                    tbGehegeName.Text,
                    Convert.ToInt32(tbGehegeGroesse.Text),
                    konr
                );
            db.saveGehege(ge);
            dispGehege();
        }
        private void btnGehegeLoeschen_Click(object sender, EventArgs e)
        {
            db.delGehege(tbGehegeNr.Text);
            dispGehege();
            clearGehegeBoxen();
        }
        private void clearGehegeBoxen()
        {
            tbGehegeNr.Text = "";
            tbGehegeName.Text = "";
            tbGehegeGroesse.Text = "";
            cbKontinente.SelectedIndex = -1;
        }
        private void btnTASpeichern_Click(object sender, EventArgs e)
        {
            db.saveTierart(tbTierartName.Text);
            dispTierarten();
        }

        private void btnTierSpeichern_Click(object sender, EventArgs e)
        {
            Tier tier = new Tier(
                -1,
                tbTiername.Text,
                dtpGebDat.Value,
                cbHerkunft.Text,
                gehegeList[cbTiergehege.SelectedIndex].GehegeNr,
                tierartList[cbTierart.SelectedIndex].TierartNr,
                rbMaennlich.Checked
                );
            db.saveTier(tier);
            dispTiere();
            dispView();
        }

        private void libTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libTiere.SelectedIndex != -1)
            {
                Tier t = tierList[libTiere.SelectedIndex];

                tbTiernr.Text = t.TierNr.ToString();
                tbTiername.Text = t.TierName;
                dtpGebDat.Value = t.TierGebDat;
                cbHerkunft.Text = t.TierHerkunft;
                cbTiergehege.SelectedIndex =
                    gehegeList.FindIndex(x => x.GehegeNr == t.TierGehege);
                cbTierart.SelectedIndex =
                    tierartList.FindIndex(x => x.TierartNr == t.TierTierart);
                rbMaennlich.Checked = t.TierGeschlecht;
                rbWeiblich.Checked = !rbMaennlich.Checked;

                string pfad = "Images\\" + tbTiernr.Text + ".jpg";
                if (File.Exists(pfad))
                {
                    pbTier.Image = Image.FromFile(pfad);
                }
                else
                    pbTier.Image = null;
            }
        }

        private void dgvUebersicht_SelectionChanged(object sender, EventArgs e)
        {
            //int TierNr = 
            //    Convert.ToInt32(
            //        dgvUebersicht.CurrentRow.Cells[0].Value);

            libTiere.SelectedIndex =
                dgvUebersicht.CurrentRow.Index;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                int gehenr = gehegeList[comboBox1.SelectedIndex].GehegeNr;

                dataGridView1.Rows.Clear();
                List<GehegeTier> ligeti = db.GetGehegeTier(gehenr);

                foreach (GehegeTier gt in ligeti)
                {
                    Image img = null;
                    string path = "Images\\" + gt.Tnr + ".jpg";

                    if (File.Exists(path))
                    {
                        img = Image.FromFile(path);
                    }

                    dataGridView1.Rows.Add(gt.Tname, gt.Taname, img);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                dataGridView2.Rows.Clear();
                int tnr = tierartList[comboBox2.SelectedIndex].TierartNr;

                foreach (Tier t in tierList)
                {
                    if (t.TierTierart == tnr)
                        dataGridView2.Rows.Add(t.TierNr, t.TierName, t.TierGebDat.ToString());
                }
            }
        }

        private void tbTiernr_TextChanged(object sender, EventArgs e)
        {
            if (tbTiernr.Text == "-1"
            || tbTiernr.Text == "")
                tabPage3.AllowDrop = false;
            else
                tabPage3.AllowDrop = true;
        }
        private void tabPage3_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects dde = DragDropEffects.None;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                dde = DragDropEffects.Copy;

            }
            e.Effect = dde;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTiernr.Text = "-1";
        }
    }
}
