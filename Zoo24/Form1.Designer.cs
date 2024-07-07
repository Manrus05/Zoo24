namespace Zoo24
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDelete = new Button();
            btnNeu = new Button();
            btnSpeichern = new Button();
            tbKontName = new TextBox();
            tbKontNr = new TextBox();
            libKontinente = new ListBox();
            tabPage2 = new TabPage();
            btnGehegeLoeschen = new Button();
            btnGehegeNeu = new Button();
            btnGehSpeichern = new Button();
            cbKontinente = new ComboBox();
            tbGehegeGroesse = new TextBox();
            tbGehegeName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbGehegeNr = new TextBox();
            libGehege = new ListBox();
            tabPage3 = new TabPage();
            pbTier = new PictureBox();
            libTiere = new ListBox();
            rbWeiblich = new RadioButton();
            rbMaennlich = new RadioButton();
            cbTierart = new ComboBox();
            cbTiergehege = new ComboBox();
            cbHerkunft = new ComboBox();
            dtpGebDat = new DateTimePicker();
            tbTiername = new TextBox();
            btnTierSpeichern = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbTiernr = new TextBox();
            groupBox1 = new GroupBox();
            libTierart = new ListBox();
            tbTierartName = new TextBox();
            btnTASpeichern = new Button();
            tabPage4 = new TabPage();
            dgvUebersicht = new DataGridView();
            TierNrCol = new DataGridViewTextBoxColumn();
            TierNameCol = new DataGridViewTextBoxColumn();
            TierARtCol = new DataGridViewTextBoxColumn();
            GebDatCol = new DataGridViewTextBoxColumn();
            gehegeCol = new DataGridViewTextBoxColumn();
            tabPage5 = new TabPage();
            dataGridView1 = new DataGridView();
            TNameCol = new DataGridViewTextBoxColumn();
            TArtCol = new DataGridViewTextBoxColumn();
            TBildCol = new DataGridViewImageColumn();
            label10 = new Label();
            comboBox1 = new ComboBox();
            tabPage6 = new TabPage();
            dataGridView2 = new DataGridView();
            TNrCol = new DataGridViewTextBoxColumn();
            TNameCol2 = new DataGridViewTextBoxColumn();
            TierGeddatCol = new DataGridViewTextBoxColumn();
            comboBox2 = new ComboBox();
            label11 = new Label();
            tabPage7 = new TabPage();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTier).BeginInit();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUebersicht).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(31, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(724, 355);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnNeu);
            tabPage1.Controls.Add(btnSpeichern);
            tabPage1.Controls.Add(tbKontName);
            tabPage1.Controls.Add(tbKontNr);
            tabPage1.Controls.Add(libKontinente);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(716, 327);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kontinente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(86, 287);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 25);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Löschen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNeu
            // 
            btnNeu.Location = new Point(240, 243);
            btnNeu.Name = "btnNeu";
            btnNeu.Size = new Size(66, 29);
            btnNeu.TabIndex = 4;
            btnNeu.Text = "Neu";
            btnNeu.UseVisualStyleBackColor = true;
            btnNeu.Click += btnNeu_Click;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(86, 243);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(109, 29);
            btnSpeichern.TabIndex = 3;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // tbKontName
            // 
            tbKontName.Location = new Point(86, 101);
            tbKontName.Name = "tbKontName";
            tbKontName.Size = new Size(187, 23);
            tbKontName.TabIndex = 2;
            // 
            // tbKontNr
            // 
            tbKontNr.Location = new Point(86, 56);
            tbKontNr.Name = "tbKontNr";
            tbKontNr.ReadOnly = true;
            tbKontNr.Size = new Size(76, 23);
            tbKontNr.TabIndex = 1;
            tbKontNr.Visible = false;
            // 
            // libKontinente
            // 
            libKontinente.FormattingEnabled = true;
            libKontinente.ItemHeight = 15;
            libKontinente.Location = new Point(408, 28);
            libKontinente.Name = "libKontinente";
            libKontinente.Size = new Size(182, 244);
            libKontinente.TabIndex = 0;
            libKontinente.SelectedIndexChanged += libKontinente_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnGehegeLoeschen);
            tabPage2.Controls.Add(btnGehegeNeu);
            tabPage2.Controls.Add(btnGehSpeichern);
            tabPage2.Controls.Add(cbKontinente);
            tabPage2.Controls.Add(tbGehegeGroesse);
            tabPage2.Controls.Add(tbGehegeName);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(tbGehegeNr);
            tabPage2.Controls.Add(libGehege);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(716, 327);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gehege";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGehegeLoeschen
            // 
            btnGehegeLoeschen.Location = new Point(52, 275);
            btnGehegeLoeschen.Name = "btnGehegeLoeschen";
            btnGehegeLoeschen.Size = new Size(109, 25);
            btnGehegeLoeschen.TabIndex = 10;
            btnGehegeLoeschen.Text = "Löschen";
            btnGehegeLoeschen.UseVisualStyleBackColor = true;
            btnGehegeLoeschen.Click += btnGehegeLoeschen_Click;
            // 
            // btnGehegeNeu
            // 
            btnGehegeNeu.Location = new Point(206, 231);
            btnGehegeNeu.Name = "btnGehegeNeu";
            btnGehegeNeu.Size = new Size(66, 29);
            btnGehegeNeu.TabIndex = 9;
            btnGehegeNeu.Text = "Neu";
            btnGehegeNeu.UseVisualStyleBackColor = true;
            btnGehegeNeu.Click += btnGehegeNeu_Click;
            // 
            // btnGehSpeichern
            // 
            btnGehSpeichern.Location = new Point(52, 231);
            btnGehSpeichern.Name = "btnGehSpeichern";
            btnGehSpeichern.Size = new Size(109, 29);
            btnGehSpeichern.TabIndex = 8;
            btnGehSpeichern.Text = "Speichern";
            btnGehSpeichern.UseVisualStyleBackColor = true;
            btnGehSpeichern.Click += btnGehSpeichern_Click;
            // 
            // cbKontinente
            // 
            cbKontinente.FormattingEnabled = true;
            cbKontinente.Location = new Point(143, 172);
            cbKontinente.Name = "cbKontinente";
            cbKontinente.Size = new Size(129, 23);
            cbKontinente.TabIndex = 7;
            // 
            // tbGehegeGroesse
            // 
            tbGehegeGroesse.Location = new Point(145, 129);
            tbGehegeGroesse.Name = "tbGehegeGroesse";
            tbGehegeGroesse.Size = new Size(127, 23);
            tbGehegeGroesse.TabIndex = 6;
            // 
            // tbGehegeName
            // 
            tbGehegeName.Location = new Point(145, 86);
            tbGehegeName.Name = "tbGehegeName";
            tbGehegeName.Size = new Size(127, 23);
            tbGehegeName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 178);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "GehegeKontinent:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 132);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "GehegeGroesse:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 89);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "GehegeName:";
            // 
            // tbGehegeNr
            // 
            tbGehegeNr.Location = new Point(143, 29);
            tbGehegeNr.Name = "tbGehegeNr";
            tbGehegeNr.ReadOnly = true;
            tbGehegeNr.Size = new Size(83, 23);
            tbGehegeNr.TabIndex = 1;
            // 
            // libGehege
            // 
            libGehege.FormattingEnabled = true;
            libGehege.ItemHeight = 15;
            libGehege.Location = new Point(466, 29);
            libGehege.Name = "libGehege";
            libGehege.Size = new Size(182, 274);
            libGehege.TabIndex = 0;
            libGehege.SelectedIndexChanged += libGehege_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(pbTier);
            tabPage3.Controls.Add(libTiere);
            tabPage3.Controls.Add(rbWeiblich);
            tabPage3.Controls.Add(rbMaennlich);
            tabPage3.Controls.Add(cbTierart);
            tabPage3.Controls.Add(cbTiergehege);
            tabPage3.Controls.Add(cbHerkunft);
            tabPage3.Controls.Add(dtpGebDat);
            tabPage3.Controls.Add(tbTiername);
            tabPage3.Controls.Add(btnTierSpeichern);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(tbTiernr);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(716, 327);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Tiere";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.DragEnter += tabPage3_DragEnter;
            // 
            // pbTier
            // 
            pbTier.Location = new Point(24, 262);
            pbTier.Name = "pbTier";
            pbTier.Size = new Size(67, 53);
            pbTier.SizeMode = PictureBoxSizeMode.Zoom;
            pbTier.TabIndex = 20;
            pbTier.TabStop = false;
            // 
            // libTiere
            // 
            libTiere.FormattingEnabled = true;
            libTiere.ItemHeight = 15;
            libTiere.Location = new Point(313, 57);
            libTiere.Name = "libTiere";
            libTiere.Size = new Size(166, 244);
            libTiere.TabIndex = 19;
            libTiere.SelectedIndexChanged += libTiere_SelectedIndexChanged;
            // 
            // rbWeiblich
            // 
            rbWeiblich.AutoSize = true;
            rbWeiblich.Location = new Point(233, 234);
            rbWeiblich.Name = "rbWeiblich";
            rbWeiblich.Size = new Size(36, 19);
            rbWeiblich.TabIndex = 18;
            rbWeiblich.TabStop = true;
            rbWeiblich.Text = "W";
            rbWeiblich.UseVisualStyleBackColor = true;
            // 
            // rbMaennlich
            // 
            rbMaennlich.AutoSize = true;
            rbMaennlich.Location = new Point(137, 234);
            rbMaennlich.Name = "rbMaennlich";
            rbMaennlich.Size = new Size(36, 19);
            rbMaennlich.TabIndex = 17;
            rbMaennlich.TabStop = true;
            rbMaennlich.Text = "M";
            rbMaennlich.UseVisualStyleBackColor = true;
            // 
            // cbTierart
            // 
            cbTierart.FormattingEnabled = true;
            cbTierart.Location = new Point(139, 189);
            cbTierart.Name = "cbTierart";
            cbTierart.Size = new Size(130, 23);
            cbTierart.TabIndex = 16;
            // 
            // cbTiergehege
            // 
            cbTiergehege.FormattingEnabled = true;
            cbTiergehege.Location = new Point(139, 147);
            cbTiergehege.Name = "cbTiergehege";
            cbTiergehege.Size = new Size(130, 23);
            cbTiergehege.TabIndex = 15;
            // 
            // cbHerkunft
            // 
            cbHerkunft.FormattingEnabled = true;
            cbHerkunft.Items.AddRange(new object[] { "Wildnis", "Zoo", "Eigenzucht" });
            cbHerkunft.Location = new Point(139, 105);
            cbHerkunft.Name = "cbHerkunft";
            cbHerkunft.Size = new Size(130, 23);
            cbHerkunft.TabIndex = 14;
            // 
            // dtpGebDat
            // 
            dtpGebDat.Format = DateTimePickerFormat.Short;
            dtpGebDat.Location = new Point(140, 60);
            dtpGebDat.Name = "dtpGebDat";
            dtpGebDat.Size = new Size(129, 23);
            dtpGebDat.TabIndex = 13;
            // 
            // tbTiername
            // 
            tbTiername.Location = new Point(139, 21);
            tbTiername.Name = "tbTiername";
            tbTiername.Size = new Size(130, 23);
            tbTiername.TabIndex = 12;
            // 
            // btnTierSpeichern
            // 
            btnTierSpeichern.Location = new Point(185, 280);
            btnTierSpeichern.Name = "btnTierSpeichern";
            btnTierSpeichern.Size = new Size(84, 24);
            btnTierSpeichern.TabIndex = 11;
            btnTierSpeichern.Text = "Speichern";
            btnTierSpeichern.UseVisualStyleBackColor = true;
            btnTierSpeichern.Click += btnTierSpeichern_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 234);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 10;
            label9.Text = "Geschlecht:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 192);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 9;
            label8.Text = "Tierart:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 150);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 8;
            label7.Text = "TierGehege:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 108);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 7;
            label6.Text = "TierHerkunft:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 66);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "TierGebDat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 24);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 5;
            label4.Text = "Tiername:";
            // 
            // tbTiernr
            // 
            tbTiernr.Location = new Point(396, 18);
            tbTiernr.Name = "tbTiernr";
            tbTiernr.ReadOnly = true;
            tbTiernr.Size = new Size(81, 23);
            tbTiernr.TabIndex = 4;
            tbTiernr.TextChanged += tbTiernr_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(libTierart);
            groupBox1.Controls.Add(tbTierartName);
            groupBox1.Controls.Add(btnTASpeichern);
            groupBox1.Location = new Point(498, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 303);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tierart";
            // 
            // libTierart
            // 
            libTierart.FormattingEnabled = true;
            libTierart.ItemHeight = 15;
            libTierart.Location = new Point(17, 87);
            libTierart.Name = "libTierart";
            libTierart.Size = new Size(180, 199);
            libTierart.TabIndex = 0;
            // 
            // tbTierartName
            // 
            tbTierartName.Location = new Point(17, 26);
            tbTierartName.Name = "tbTierartName";
            tbTierartName.Size = new Size(180, 23);
            tbTierartName.TabIndex = 1;
            // 
            // btnTASpeichern
            // 
            btnTASpeichern.Location = new Point(18, 53);
            btnTASpeichern.Name = "btnTASpeichern";
            btnTASpeichern.Size = new Size(179, 27);
            btnTASpeichern.TabIndex = 2;
            btnTASpeichern.Text = "Speichern";
            btnTASpeichern.UseVisualStyleBackColor = true;
            btnTASpeichern.Click += btnTASpeichern_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvUebersicht);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(716, 327);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Übersicht";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvUebersicht
            // 
            dgvUebersicht.AllowUserToAddRows = false;
            dgvUebersicht.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvUebersicht.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUebersicht.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUebersicht.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUebersicht.Columns.AddRange(new DataGridViewColumn[] { TierNrCol, TierNameCol, TierARtCol, GebDatCol, gehegeCol });
            dgvUebersicht.Location = new Point(66, 35);
            dgvUebersicht.MultiSelect = false;
            dgvUebersicht.Name = "dgvUebersicht";
            dgvUebersicht.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUebersicht.Size = new Size(603, 251);
            dgvUebersicht.TabIndex = 0;
            dgvUebersicht.SelectionChanged += dgvUebersicht_SelectionChanged;
            // 
            // TierNrCol
            // 
            TierNrCol.HeaderText = "TierNr";
            TierNrCol.Name = "TierNrCol";
            TierNrCol.Visible = false;
            // 
            // TierNameCol
            // 
            TierNameCol.HeaderText = "Tiername";
            TierNameCol.Name = "TierNameCol";
            // 
            // TierARtCol
            // 
            TierARtCol.HeaderText = "Tierart";
            TierARtCol.Name = "TierARtCol";
            // 
            // GebDatCol
            // 
            GebDatCol.HeaderText = "gebDatum";
            GebDatCol.Name = "GebDatCol";
            // 
            // gehegeCol
            // 
            gehegeCol.HeaderText = "Gehege";
            gehegeCol.Name = "gehegeCol";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridView1);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(comboBox1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(716, 327);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "GehegeBelegung";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TNameCol, TArtCol, TBildCol });
            dataGridView1.Location = new Point(166, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(382, 203);
            dataGridView1.TabIndex = 2;
            // 
            // TNameCol
            // 
            TNameCol.HeaderText = "Tiername";
            TNameCol.Name = "TNameCol";
            // 
            // TArtCol
            // 
            TArtCol.HeaderText = "Tierart";
            TArtCol.Name = "TArtCol";
            // 
            // TBildCol
            // 
            TBildCol.HeaderText = "";
            TBildCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            TBildCol.Name = "TBildCol";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 32);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 1;
            label10.Text = "Gehege:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dataGridView2);
            tabPage6.Controls.Add(comboBox2);
            tabPage6.Controls.Add(label11);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(716, 327);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "TierartTiere";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { TNrCol, TNameCol2, TierGeddatCol });
            dataGridView2.Location = new Point(132, 116);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(432, 149);
            dataGridView2.TabIndex = 2;
            // 
            // TNrCol
            // 
            TNrCol.HeaderText = "TierNr";
            TNrCol.Name = "TNrCol";
            TNrCol.ReadOnly = true;
            // 
            // TNameCol2
            // 
            TNameCol2.HeaderText = "Tiername";
            TNameCol2.Name = "TNameCol2";
            TNameCol2.ReadOnly = true;
            // 
            // TierGeddatCol
            // 
            TierGeddatCol.HeaderText = "Geboren am";
            TierGeddatCol.Name = "TierGeddatCol";
            TierGeddatCol.ReadOnly = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(215, 39);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(150, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(130, 41);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 0;
            label11.Text = "Tierart:";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(listBox2);
            tabPage7.Controls.Add(listBox1);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(716, 327);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "GehegeTiere";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(239, 202);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(385, 109);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(239, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(385, 169);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(103, 279);
            button1.Name = "button1";
            button1.Size = new Size(47, 26);
            button1.TabIndex = 21;
            button1.Text = "Neu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTier).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUebersicht).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox libKontinente;
        private TextBox tbKontName;
        private TextBox tbKontNr;
        private Button btnSpeichern;
        private Button btnNeu;
        private Button btnDelete;
        private TextBox tbGehegeNr;
        private ListBox libGehege;
        private ComboBox cbKontinente;
        private TextBox tbGehegeGroesse;
        private TextBox tbGehegeName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGehegeLoeschen;
        private Button btnGehegeNeu;
        private Button btnGehSpeichern;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private Button btnTASpeichern;
        private TextBox tbTierartName;
        private ListBox libTierart;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbTiernr;
        private DateTimePicker dtpGebDat;
        private TextBox tbTiername;
        private Button btnTierSpeichern;
        private ComboBox cbHerkunft;
        private ComboBox cbTiergehege;
        private RadioButton rbWeiblich;
        private RadioButton rbMaennlich;
        private ComboBox cbTierart;
        private ListBox libTiere;
        private PictureBox pbTier;
        private TabPage tabPage4;
        private DataGridView dgvUebersicht;
        private DataGridViewTextBoxColumn TierNrCol;
        private DataGridViewTextBoxColumn TierNameCol;
        private DataGridViewTextBoxColumn TierARtCol;
        private DataGridViewTextBoxColumn GebDatCol;
        private DataGridViewTextBoxColumn gehegeCol;
        private TabPage tabPage5;
        private DataGridView dataGridView1;
        private Label label10;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn TNameCol;
        private DataGridViewTextBoxColumn TArtCol;
        private DataGridViewImageColumn TBildCol;
        private TabPage tabPage6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn TNrCol;
        private DataGridViewTextBoxColumn TNameCol2;
        private DataGridViewTextBoxColumn TierGeddatCol;
        private ComboBox comboBox2;
        private Label label11;
        private TabPage tabPage7;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
    }
}
