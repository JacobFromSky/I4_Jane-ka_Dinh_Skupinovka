namespace I4_Janečka_Dinh_Skupinovka
{
    partial class Menu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btVybrat = new System.Windows.Forms.Button();
            this.cbOceneni = new System.Windows.Forms.CheckBox();
            this.rbFiltrLeva = new System.Windows.Forms.RadioButton();
            this.rbFiltrPrava = new System.Windows.Forms.RadioButton();
            this.lbFiltrKlub = new System.Windows.Forms.Label();
            this.cmbFiltraceKlub = new System.Windows.Forms.ComboBox();
            this.cmbFiltraceLigaKlubu = new System.Windows.Forms.ComboBox();
            this.lbFiltrLigaKlubu = new System.Windows.Forms.Label();
            this.cmbFiltraceZemeKLubu = new System.Windows.Forms.ComboBox();
            this.lbFiltrZemeKlubu = new System.Windows.Forms.Label();
            this.lbFiltrMaxVyska = new System.Windows.Forms.Label();
            this.lbFiltrMaxVaha = new System.Windows.Forms.Label();
            this.numMaxVaha = new System.Windows.Forms.NumericUpDown();
            this.numMaxVyska = new System.Windows.Forms.NumericUpDown();
            this.lbFiltrMinVaha = new System.Windows.Forms.Label();
            this.lbFiltrMinVyska = new System.Windows.Forms.Label();
            this.numMinVaha = new System.Windows.Forms.NumericUpDown();
            this.cbFiltrZlataKopacka = new System.Windows.Forms.CheckBox();
            this.cbFiltrZlatyMic = new System.Windows.Forms.CheckBox();
            this.lbFiltrPozice = new System.Windows.Forms.Label();
            this.cbFiltrNoha = new System.Windows.Forms.CheckBox();
            this.numMinVyska = new System.Windows.Forms.NumericUpDown();
            this.btUlozitFiltr = new System.Windows.Forms.Button();
            this.btResetovat = new System.Windows.Forms.Button();
            this.btPouzit = new System.Windows.Forms.Button();
            this.lbZlataKopacka = new System.Windows.Forms.Label();
            this.lbZlatyMic = new System.Windows.Forms.Label();
            this.lbNoha = new System.Windows.Forms.Label();
            this.lbCisloDresu = new System.Windows.Forms.Label();
            this.lbPozice = new System.Windows.Forms.Label();
            this.lbKlub = new System.Windows.Forms.Label();
            this.lbLigaKlubu = new System.Windows.Forms.Label();
            this.lbZemeKlubu = new System.Windows.Forms.Label();
            this.lbVaha = new System.Windows.Forms.Label();
            this.lbVyska = new System.Windows.Forms.Label();
            this.lbZemeNarozeni = new System.Windows.Forms.Label();
            this.lbDatumNarozeni = new System.Windows.Forms.Label();
            this.cmbFiltrPozice = new System.Windows.Forms.ComboBox();
            this.cbFiltrace = new System.Windows.Forms.CheckBox();
            this.btUlozit = new System.Windows.Forms.Button();
            this.btNovaPolozka = new System.Windows.Forms.Button();
            this.btUpravit = new System.Windows.Forms.Button();
            this.btSmazat = new System.Windows.Forms.Button();
            this.lboxFiltr = new System.Windows.Forms.ListBox();
            this.lboxPolozky = new System.Windows.Forms.ListBox();
            this.btKonec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVaha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVyska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVaha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVyska)).BeginInit();
            this.SuspendLayout();
            // 
            // sfd
            // 
            this.sfd.Filter = "(.csv)|*.csv|(.txt)|*.txt";
            // 
            // btVybrat
            // 
            this.btVybrat.Enabled = false;
            this.btVybrat.Location = new System.Drawing.Point(1054, 604);
            this.btVybrat.Name = "btVybrat";
            this.btVybrat.Size = new System.Drawing.Size(192, 62);
            this.btVybrat.TabIndex = 106;
            this.btVybrat.Text = "Vybrat informace";
            this.btVybrat.UseVisualStyleBackColor = true;
            // 
            // cbOceneni
            // 
            this.cbOceneni.AutoSize = true;
            this.cbOceneni.Enabled = false;
            this.cbOceneni.Location = new System.Drawing.Point(1054, 416);
            this.cbOceneni.Name = "cbOceneni";
            this.cbOceneni.Size = new System.Drawing.Size(82, 22);
            this.cbOceneni.TabIndex = 105;
            this.cbOceneni.Text = "Ocenění";
            this.cbOceneni.UseVisualStyleBackColor = true;
            // 
            // rbFiltrLeva
            // 
            this.rbFiltrLeva.AutoSize = true;
            this.rbFiltrLeva.Enabled = false;
            this.rbFiltrLeva.Location = new System.Drawing.Point(1145, 387);
            this.rbFiltrLeva.Name = "rbFiltrLeva";
            this.rbFiltrLeva.Size = new System.Drawing.Size(57, 22);
            this.rbFiltrLeva.TabIndex = 104;
            this.rbFiltrLeva.TabStop = true;
            this.rbFiltrLeva.Text = "Levá";
            this.rbFiltrLeva.UseVisualStyleBackColor = true;
            // 
            // rbFiltrPrava
            // 
            this.rbFiltrPrava.AutoSize = true;
            this.rbFiltrPrava.Enabled = false;
            this.rbFiltrPrava.Location = new System.Drawing.Point(1054, 387);
            this.rbFiltrPrava.Name = "rbFiltrPrava";
            this.rbFiltrPrava.Size = new System.Drawing.Size(64, 22);
            this.rbFiltrPrava.TabIndex = 103;
            this.rbFiltrPrava.TabStop = true;
            this.rbFiltrPrava.Text = "Pravá";
            this.rbFiltrPrava.UseVisualStyleBackColor = true;
            // 
            // lbFiltrKlub
            // 
            this.lbFiltrKlub.AutoSize = true;
            this.lbFiltrKlub.Location = new System.Drawing.Point(853, 448);
            this.lbFiltrKlub.Name = "lbFiltrKlub";
            this.lbFiltrKlub.Size = new System.Drawing.Size(41, 18);
            this.lbFiltrKlub.TabIndex = 102;
            this.lbFiltrKlub.Text = "Klub:";
            // 
            // cmbFiltraceKlub
            // 
            this.cmbFiltraceKlub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltraceKlub.Enabled = false;
            this.cmbFiltraceKlub.FormattingEnabled = true;
            this.cmbFiltraceKlub.Location = new System.Drawing.Point(949, 445);
            this.cmbFiltraceKlub.Name = "cmbFiltraceKlub";
            this.cmbFiltraceKlub.Size = new System.Drawing.Size(88, 26);
            this.cmbFiltraceKlub.TabIndex = 101;
            // 
            // cmbFiltraceLigaKlubu
            // 
            this.cmbFiltraceLigaKlubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltraceLigaKlubu.Enabled = false;
            this.cmbFiltraceLigaKlubu.FormattingEnabled = true;
            this.cmbFiltraceLigaKlubu.Location = new System.Drawing.Point(949, 414);
            this.cmbFiltraceLigaKlubu.Name = "cmbFiltraceLigaKlubu";
            this.cmbFiltraceLigaKlubu.Size = new System.Drawing.Size(88, 26);
            this.cmbFiltraceLigaKlubu.TabIndex = 100;
            // 
            // lbFiltrLigaKlubu
            // 
            this.lbFiltrLigaKlubu.AutoSize = true;
            this.lbFiltrLigaKlubu.Location = new System.Drawing.Point(850, 417);
            this.lbFiltrLigaKlubu.Name = "lbFiltrLigaKlubu";
            this.lbFiltrLigaKlubu.Size = new System.Drawing.Size(78, 18);
            this.lbFiltrLigaKlubu.TabIndex = 99;
            this.lbFiltrLigaKlubu.Text = "Liga klubu:";
            // 
            // cmbFiltraceZemeKLubu
            // 
            this.cmbFiltraceZemeKLubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltraceZemeKLubu.Enabled = false;
            this.cmbFiltraceZemeKLubu.FormattingEnabled = true;
            this.cmbFiltraceZemeKLubu.Location = new System.Drawing.Point(948, 382);
            this.cmbFiltraceZemeKLubu.Name = "cmbFiltraceZemeKLubu";
            this.cmbFiltraceZemeKLubu.Size = new System.Drawing.Size(88, 26);
            this.cmbFiltraceZemeKLubu.TabIndex = 98;
            // 
            // lbFiltrZemeKlubu
            // 
            this.lbFiltrZemeKlubu.AutoSize = true;
            this.lbFiltrZemeKlubu.Location = new System.Drawing.Point(853, 385);
            this.lbFiltrZemeKlubu.Name = "lbFiltrZemeKlubu";
            this.lbFiltrZemeKlubu.Size = new System.Drawing.Size(89, 18);
            this.lbFiltrZemeKlubu.TabIndex = 97;
            this.lbFiltrZemeKlubu.Text = "Země klubu:";
            // 
            // lbFiltrMaxVyska
            // 
            this.lbFiltrMaxVyska.AutoSize = true;
            this.lbFiltrMaxVyska.Location = new System.Drawing.Point(1051, 480);
            this.lbFiltrMaxVyska.Name = "lbFiltrMaxVyska";
            this.lbFiltrMaxVyska.Size = new System.Drawing.Size(86, 18);
            this.lbFiltrMaxVyska.TabIndex = 96;
            this.lbFiltrMaxVyska.Text = "Max. výška:";
            // 
            // lbFiltrMaxVaha
            // 
            this.lbFiltrMaxVaha.AutoSize = true;
            this.lbFiltrMaxVaha.Location = new System.Drawing.Point(1051, 509);
            this.lbFiltrMaxVaha.Name = "lbFiltrMaxVaha";
            this.lbFiltrMaxVaha.Size = new System.Drawing.Size(79, 18);
            this.lbFiltrMaxVaha.TabIndex = 95;
            this.lbFiltrMaxVaha.Text = "Max. váha:";
            // 
            // numMaxVaha
            // 
            this.numMaxVaha.Enabled = false;
            this.numMaxVaha.Location = new System.Drawing.Point(1158, 507);
            this.numMaxVaha.Name = "numMaxVaha";
            this.numMaxVaha.Size = new System.Drawing.Size(88, 24);
            this.numMaxVaha.TabIndex = 94;
            this.numMaxVaha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numMaxVyska
            // 
            this.numMaxVyska.Enabled = false;
            this.numMaxVyska.Location = new System.Drawing.Point(1158, 477);
            this.numMaxVyska.Name = "numMaxVyska";
            this.numMaxVyska.Size = new System.Drawing.Size(88, 24);
            this.numMaxVyska.TabIndex = 93;
            this.numMaxVyska.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbFiltrMinVaha
            // 
            this.lbFiltrMinVaha.AutoSize = true;
            this.lbFiltrMinVaha.Location = new System.Drawing.Point(853, 509);
            this.lbFiltrMinVaha.Name = "lbFiltrMinVaha";
            this.lbFiltrMinVaha.Size = new System.Drawing.Size(75, 18);
            this.lbFiltrMinVaha.TabIndex = 92;
            this.lbFiltrMinVaha.Text = "Min. váha:";
            // 
            // lbFiltrMinVyska
            // 
            this.lbFiltrMinVyska.AutoSize = true;
            this.lbFiltrMinVyska.Location = new System.Drawing.Point(853, 480);
            this.lbFiltrMinVyska.Name = "lbFiltrMinVyska";
            this.lbFiltrMinVyska.Size = new System.Drawing.Size(82, 18);
            this.lbFiltrMinVyska.TabIndex = 91;
            this.lbFiltrMinVyska.Text = "Min. výška:";
            // 
            // numMinVaha
            // 
            this.numMinVaha.Enabled = false;
            this.numMinVaha.Location = new System.Drawing.Point(949, 507);
            this.numMinVaha.Name = "numMinVaha";
            this.numMinVaha.Size = new System.Drawing.Size(88, 24);
            this.numMinVaha.TabIndex = 90;
            this.numMinVaha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbFiltrZlataKopacka
            // 
            this.cbFiltrZlataKopacka.AutoSize = true;
            this.cbFiltrZlataKopacka.Enabled = false;
            this.cbFiltrZlataKopacka.Location = new System.Drawing.Point(1145, 447);
            this.cbFiltrZlataKopacka.Name = "cbFiltrZlataKopacka";
            this.cbFiltrZlataKopacka.Size = new System.Drawing.Size(120, 22);
            this.cbFiltrZlataKopacka.TabIndex = 89;
            this.cbFiltrZlataKopacka.Text = "Zlatá kopačka";
            this.cbFiltrZlataKopacka.UseVisualStyleBackColor = true;
            // 
            // cbFiltrZlatyMic
            // 
            this.cbFiltrZlatyMic.AutoSize = true;
            this.cbFiltrZlatyMic.Enabled = false;
            this.cbFiltrZlatyMic.Location = new System.Drawing.Point(1054, 447);
            this.cbFiltrZlatyMic.Name = "cbFiltrZlatyMic";
            this.cbFiltrZlatyMic.Size = new System.Drawing.Size(86, 22);
            this.cbFiltrZlatyMic.TabIndex = 88;
            this.cbFiltrZlatyMic.Text = "Zlatý míč";
            this.cbFiltrZlatyMic.UseVisualStyleBackColor = true;
            // 
            // lbFiltrPozice
            // 
            this.lbFiltrPozice.AutoSize = true;
            this.lbFiltrPozice.Location = new System.Drawing.Point(853, 353);
            this.lbFiltrPozice.Name = "lbFiltrPozice";
            this.lbFiltrPozice.Size = new System.Drawing.Size(58, 18);
            this.lbFiltrPozice.TabIndex = 87;
            this.lbFiltrPozice.Text = "Pozice:";
            // 
            // cbFiltrNoha
            // 
            this.cbFiltrNoha.AutoSize = true;
            this.cbFiltrNoha.Enabled = false;
            this.cbFiltrNoha.Location = new System.Drawing.Point(1054, 352);
            this.cbFiltrNoha.Name = "cbFiltrNoha";
            this.cbFiltrNoha.Size = new System.Drawing.Size(144, 22);
            this.cbFiltrNoha.TabIndex = 86;
            this.cbFiltrNoha.Text = "Preferovaná noha";
            this.cbFiltrNoha.UseVisualStyleBackColor = true;
            // 
            // numMinVyska
            // 
            this.numMinVyska.Enabled = false;
            this.numMinVyska.Location = new System.Drawing.Point(949, 477);
            this.numMinVyska.Name = "numMinVyska";
            this.numMinVyska.Size = new System.Drawing.Size(88, 24);
            this.numMinVyska.TabIndex = 85;
            this.numMinVyska.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btUlozitFiltr
            // 
            this.btUlozitFiltr.Enabled = false;
            this.btUlozitFiltr.Location = new System.Drawing.Point(856, 604);
            this.btUlozitFiltr.Name = "btUlozitFiltr";
            this.btUlozitFiltr.Size = new System.Drawing.Size(180, 62);
            this.btUlozitFiltr.TabIndex = 84;
            this.btUlozitFiltr.Text = "Uložit filtr";
            this.btUlozitFiltr.UseVisualStyleBackColor = true;
            // 
            // btResetovat
            // 
            this.btResetovat.Enabled = false;
            this.btResetovat.Location = new System.Drawing.Point(1054, 537);
            this.btResetovat.Name = "btResetovat";
            this.btResetovat.Size = new System.Drawing.Size(192, 62);
            this.btResetovat.TabIndex = 83;
            this.btResetovat.Text = "Resetovat";
            this.btResetovat.UseVisualStyleBackColor = true;
            // 
            // btPouzit
            // 
            this.btPouzit.Enabled = false;
            this.btPouzit.Location = new System.Drawing.Point(856, 536);
            this.btPouzit.Name = "btPouzit";
            this.btPouzit.Size = new System.Drawing.Size(180, 62);
            this.btPouzit.TabIndex = 82;
            this.btPouzit.Text = "Použít";
            this.btPouzit.UseVisualStyleBackColor = true;
            // 
            // lbZlataKopacka
            // 
            this.lbZlataKopacka.AutoSize = true;
            this.lbZlataKopacka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZlataKopacka.Location = new System.Drawing.Point(682, 219);
            this.lbZlataKopacka.Name = "lbZlataKopacka";
            this.lbZlataKopacka.Size = new System.Drawing.Size(126, 20);
            this.lbZlataKopacka.TabIndex = 77;
            this.lbZlataKopacka.Text = "Zlatá kopačka: ?";
            // 
            // lbZlatyMic
            // 
            this.lbZlatyMic.AutoSize = true;
            this.lbZlatyMic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZlatyMic.Location = new System.Drawing.Point(682, 194);
            this.lbZlatyMic.Name = "lbZlatyMic";
            this.lbZlatyMic.Size = new System.Drawing.Size(88, 20);
            this.lbZlatyMic.TabIndex = 76;
            this.lbZlatyMic.Text = "Zlatý míč: ?";
            // 
            // lbNoha
            // 
            this.lbNoha.AutoSize = true;
            this.lbNoha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNoha.Location = new System.Drawing.Point(396, 194);
            this.lbNoha.Name = "lbNoha";
            this.lbNoha.Size = new System.Drawing.Size(138, 20);
            this.lbNoha.TabIndex = 75;
            this.lbNoha.Text = "Pravá/levá noha: ?";
            // 
            // lbCisloDresu
            // 
            this.lbCisloDresu.AutoSize = true;
            this.lbCisloDresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCisloDresu.Location = new System.Drawing.Point(682, 169);
            this.lbCisloDresu.Name = "lbCisloDresu";
            this.lbCisloDresu.Size = new System.Drawing.Size(104, 20);
            this.lbCisloDresu.TabIndex = 74;
            this.lbCisloDresu.Text = "Číslo dresu: ?";
            // 
            // lbPozice
            // 
            this.lbPozice.AutoSize = true;
            this.lbPozice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPozice.Location = new System.Drawing.Point(396, 219);
            this.lbPozice.Name = "lbPozice";
            this.lbPozice.Size = new System.Drawing.Size(73, 20);
            this.lbPozice.TabIndex = 73;
            this.lbPozice.Text = "Pozice: ?";
            // 
            // lbKlub
            // 
            this.lbKlub.AutoSize = true;
            this.lbKlub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKlub.Location = new System.Drawing.Point(682, 144);
            this.lbKlub.Name = "lbKlub";
            this.lbKlub.Size = new System.Drawing.Size(57, 20);
            this.lbKlub.TabIndex = 72;
            this.lbKlub.Text = "Klub: ?";
            // 
            // lbLigaKlubu
            // 
            this.lbLigaKlubu.AutoSize = true;
            this.lbLigaKlubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLigaKlubu.Location = new System.Drawing.Point(682, 119);
            this.lbLigaKlubu.Name = "lbLigaKlubu";
            this.lbLigaKlubu.Size = new System.Drawing.Size(98, 20);
            this.lbLigaKlubu.TabIndex = 71;
            this.lbLigaKlubu.Text = "Liga klubu: ?";
            // 
            // lbZemeKlubu
            // 
            this.lbZemeKlubu.AutoSize = true;
            this.lbZemeKlubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZemeKlubu.Location = new System.Drawing.Point(682, 94);
            this.lbZemeKlubu.Name = "lbZemeKlubu";
            this.lbZemeKlubu.Size = new System.Drawing.Size(109, 20);
            this.lbZemeKlubu.TabIndex = 70;
            this.lbZemeKlubu.Text = "Země klubu: ?";
            // 
            // lbVaha
            // 
            this.lbVaha.AutoSize = true;
            this.lbVaha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbVaha.Location = new System.Drawing.Point(396, 169);
            this.lbVaha.Name = "lbVaha";
            this.lbVaha.Size = new System.Drawing.Size(91, 20);
            this.lbVaha.TabIndex = 69;
            this.lbVaha.Text = "Váha(kg): ?";
            // 
            // lbVyska
            // 
            this.lbVyska.AutoSize = true;
            this.lbVyska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbVyska.Location = new System.Drawing.Point(396, 144);
            this.lbVyska.Name = "lbVyska";
            this.lbVyska.Size = new System.Drawing.Size(100, 20);
            this.lbVyska.TabIndex = 68;
            this.lbVyska.Text = "Výška(cm): ?";
            // 
            // lbZemeNarozeni
            // 
            this.lbZemeNarozeni.AutoSize = true;
            this.lbZemeNarozeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZemeNarozeni.Location = new System.Drawing.Point(396, 119);
            this.lbZemeNarozeni.Name = "lbZemeNarozeni";
            this.lbZemeNarozeni.Size = new System.Drawing.Size(132, 20);
            this.lbZemeNarozeni.TabIndex = 67;
            this.lbZemeNarozeni.Text = "Země narození: ?";
            // 
            // lbDatumNarozeni
            // 
            this.lbDatumNarozeni.AutoSize = true;
            this.lbDatumNarozeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDatumNarozeni.Location = new System.Drawing.Point(396, 94);
            this.lbDatumNarozeni.Name = "lbDatumNarozeni";
            this.lbDatumNarozeni.Size = new System.Drawing.Size(139, 20);
            this.lbDatumNarozeni.TabIndex = 66;
            this.lbDatumNarozeni.Text = "Datum narození: ?";
            // 
            // cmbFiltrPozice
            // 
            this.cmbFiltrPozice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrPozice.Enabled = false;
            this.cmbFiltrPozice.FormattingEnabled = true;
            this.cmbFiltrPozice.Items.AddRange(new object[] {
            "brankář",
            "obránce",
            "záložník",
            "útočník"});
            this.cmbFiltrPozice.Location = new System.Drawing.Point(949, 350);
            this.cmbFiltrPozice.Name = "cmbFiltrPozice";
            this.cmbFiltrPozice.Size = new System.Drawing.Size(88, 26);
            this.cmbFiltrPozice.TabIndex = 65;
            // 
            // cbFiltrace
            // 
            this.cbFiltrace.AutoSize = true;
            this.cbFiltrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFiltrace.Location = new System.Drawing.Point(108, 569);
            this.cbFiltrace.Name = "cbFiltrace";
            this.cbFiltrace.Size = new System.Drawing.Size(199, 59);
            this.cbFiltrace.TabIndex = 64;
            this.cbFiltrace.Text = "Filtrace";
            this.cbFiltrace.UseVisualStyleBackColor = true;
            // 
            // btUlozit
            // 
            this.btUlozit.Location = new System.Drawing.Point(204, 449);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(186, 80);
            this.btUlozit.TabIndex = 63;
            this.btUlozit.Text = "Uložit";
            this.btUlozit.UseVisualStyleBackColor = true;
            // 
            // btNovaPolozka
            // 
            this.btNovaPolozka.Location = new System.Drawing.Point(12, 449);
            this.btNovaPolozka.Name = "btNovaPolozka";
            this.btNovaPolozka.Size = new System.Drawing.Size(186, 80);
            this.btNovaPolozka.TabIndex = 62;
            this.btNovaPolozka.Text = "Nová položka";
            this.btNovaPolozka.UseVisualStyleBackColor = true;
            this.btNovaPolozka.Click += new System.EventHandler(this.btNovaPolozka_Click);
            // 
            // btUpravit
            // 
            this.btUpravit.Enabled = false;
            this.btUpravit.Location = new System.Drawing.Point(204, 353);
            this.btUpravit.Name = "btUpravit";
            this.btUpravit.Size = new System.Drawing.Size(186, 90);
            this.btUpravit.TabIndex = 61;
            this.btUpravit.Text = "Upravit";
            this.btUpravit.UseVisualStyleBackColor = true;
            // 
            // btSmazat
            // 
            this.btSmazat.Enabled = false;
            this.btSmazat.Location = new System.Drawing.Point(12, 353);
            this.btSmazat.Name = "btSmazat";
            this.btSmazat.Size = new System.Drawing.Size(186, 90);
            this.btSmazat.TabIndex = 60;
            this.btSmazat.Text = "Smazat";
            this.btSmazat.UseVisualStyleBackColor = true;
            this.btSmazat.Click += new System.EventHandler(this.btSmazat_Click);
            // 
            // lboxFiltr
            // 
            this.lboxFiltr.Enabled = false;
            this.lboxFiltr.FormattingEnabled = true;
            this.lboxFiltr.ItemHeight = 18;
            this.lboxFiltr.Location = new System.Drawing.Point(856, 12);
            this.lboxFiltr.Name = "lboxFiltr";
            this.lboxFiltr.Size = new System.Drawing.Size(409, 328);
            this.lboxFiltr.TabIndex = 59;
            // 
            // lboxPolozky
            // 
            this.lboxPolozky.FormattingEnabled = true;
            this.lboxPolozky.ItemHeight = 18;
            this.lboxPolozky.Location = new System.Drawing.Point(12, 12);
            this.lboxPolozky.Name = "lboxPolozky";
            this.lboxPolozky.Size = new System.Drawing.Size(378, 328);
            this.lboxPolozky.TabIndex = 58;
            this.lboxPolozky.SelectedIndexChanged += new System.EventHandler(this.lboxPolozky_SelectedIndexChanged);
            // 
            // btKonec
            // 
            this.btKonec.Location = new System.Drawing.Point(539, 574);
            this.btKonec.Name = "btKonec";
            this.btKonec.Size = new System.Drawing.Size(186, 80);
            this.btKonec.TabIndex = 107;
            this.btKonec.Text = "Ukončit Aplikaci";
            this.btKonec.UseVisualStyleBackColor = true;
            this.btKonec.Click += new System.EventHandler(this.btKonec_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 666);
            this.ControlBox = false;
            this.Controls.Add(this.btKonec);
            this.Controls.Add(this.btVybrat);
            this.Controls.Add(this.cbOceneni);
            this.Controls.Add(this.rbFiltrLeva);
            this.Controls.Add(this.rbFiltrPrava);
            this.Controls.Add(this.lbFiltrKlub);
            this.Controls.Add(this.cmbFiltraceKlub);
            this.Controls.Add(this.cmbFiltraceLigaKlubu);
            this.Controls.Add(this.lbFiltrLigaKlubu);
            this.Controls.Add(this.cmbFiltraceZemeKLubu);
            this.Controls.Add(this.lbFiltrZemeKlubu);
            this.Controls.Add(this.lbFiltrMaxVyska);
            this.Controls.Add(this.lbFiltrMaxVaha);
            this.Controls.Add(this.numMaxVaha);
            this.Controls.Add(this.numMaxVyska);
            this.Controls.Add(this.lbFiltrMinVaha);
            this.Controls.Add(this.lbFiltrMinVyska);
            this.Controls.Add(this.numMinVaha);
            this.Controls.Add(this.cbFiltrZlataKopacka);
            this.Controls.Add(this.cbFiltrZlatyMic);
            this.Controls.Add(this.lbFiltrPozice);
            this.Controls.Add(this.cbFiltrNoha);
            this.Controls.Add(this.numMinVyska);
            this.Controls.Add(this.btUlozitFiltr);
            this.Controls.Add(this.btResetovat);
            this.Controls.Add(this.btPouzit);
            this.Controls.Add(this.lbZlataKopacka);
            this.Controls.Add(this.lbZlatyMic);
            this.Controls.Add(this.lbNoha);
            this.Controls.Add(this.lbCisloDresu);
            this.Controls.Add(this.lbPozice);
            this.Controls.Add(this.lbKlub);
            this.Controls.Add(this.lbLigaKlubu);
            this.Controls.Add(this.lbZemeKlubu);
            this.Controls.Add(this.lbVaha);
            this.Controls.Add(this.lbVyska);
            this.Controls.Add(this.lbZemeNarozeni);
            this.Controls.Add(this.lbDatumNarozeni);
            this.Controls.Add(this.cmbFiltrPozice);
            this.Controls.Add(this.cbFiltrace);
            this.Controls.Add(this.btUlozit);
            this.Controls.Add(this.btNovaPolozka);
            this.Controls.Add(this.btUpravit);
            this.Controls.Add(this.btSmazat);
            this.Controls.Add(this.lboxFiltr);
            this.Controls.Add(this.lboxPolozky);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Databáze fotbalistů";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVaha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVyska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVaha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinVyska)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btVybrat;
        private System.Windows.Forms.CheckBox cbOceneni;
        private System.Windows.Forms.RadioButton rbFiltrLeva;
        private System.Windows.Forms.RadioButton rbFiltrPrava;
        private System.Windows.Forms.Label lbFiltrKlub;
        private System.Windows.Forms.ComboBox cmbFiltraceKlub;
        private System.Windows.Forms.ComboBox cmbFiltraceLigaKlubu;
        private System.Windows.Forms.Label lbFiltrLigaKlubu;
        private System.Windows.Forms.ComboBox cmbFiltraceZemeKLubu;
        private System.Windows.Forms.Label lbFiltrZemeKlubu;
        private System.Windows.Forms.Label lbFiltrMaxVyska;
        private System.Windows.Forms.Label lbFiltrMaxVaha;
        private System.Windows.Forms.NumericUpDown numMaxVaha;
        private System.Windows.Forms.NumericUpDown numMaxVyska;
        private System.Windows.Forms.Label lbFiltrMinVaha;
        private System.Windows.Forms.Label lbFiltrMinVyska;
        private System.Windows.Forms.NumericUpDown numMinVaha;
        private System.Windows.Forms.CheckBox cbFiltrZlataKopacka;
        private System.Windows.Forms.CheckBox cbFiltrZlatyMic;
        private System.Windows.Forms.Label lbFiltrPozice;
        private System.Windows.Forms.CheckBox cbFiltrNoha;
        private System.Windows.Forms.NumericUpDown numMinVyska;
        private System.Windows.Forms.Button btUlozitFiltr;
        private System.Windows.Forms.Button btResetovat;
        private System.Windows.Forms.Button btPouzit;
        private System.Windows.Forms.Label lbZlataKopacka;
        private System.Windows.Forms.Label lbZlatyMic;
        private System.Windows.Forms.Label lbNoha;
        private System.Windows.Forms.Label lbCisloDresu;
        private System.Windows.Forms.Label lbPozice;
        private System.Windows.Forms.Label lbKlub;
        private System.Windows.Forms.Label lbLigaKlubu;
        private System.Windows.Forms.Label lbZemeKlubu;
        private System.Windows.Forms.Label lbVaha;
        private System.Windows.Forms.Label lbVyska;
        private System.Windows.Forms.Label lbZemeNarozeni;
        private System.Windows.Forms.Label lbDatumNarozeni;
        private System.Windows.Forms.ComboBox cmbFiltrPozice;
        private System.Windows.Forms.CheckBox cbFiltrace;
        private System.Windows.Forms.Button btUlozit;
        private System.Windows.Forms.Button btNovaPolozka;
        private System.Windows.Forms.Button btUpravit;
        private System.Windows.Forms.Button btSmazat;
        private System.Windows.Forms.ListBox lboxFiltr;
        private System.Windows.Forms.ListBox lboxPolozky;
        private System.Windows.Forms.Button btKonec;
    }
}

