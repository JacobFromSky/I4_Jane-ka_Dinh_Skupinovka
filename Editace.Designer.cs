namespace I4_Janečka_Dinh_Skupinovka
{
    partial class Editace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numVaha = new System.Windows.Forms.NumericUpDown();
            this.cmbPozice = new System.Windows.Forms.ComboBox();
            this.numCisloDresu = new System.Windows.Forms.NumericUpDown();
            this.cbZlataKopacka = new System.Windows.Forms.CheckBox();
            this.cbZlatyMic = new System.Windows.Forms.CheckBox();
            this.lbCisloDresu = new System.Windows.Forms.Label();
            this.lbKlub = new System.Windows.Forms.Label();
            this.lbLigaKlubu = new System.Windows.Forms.Label();
            this.lbZemeKlubu = new System.Windows.Forms.Label();
            this.lbPozice = new System.Windows.Forms.Label();
            this.lbVaha = new System.Windows.Forms.Label();
            this.tbZemeKlubu = new System.Windows.Forms.TextBox();
            this.tbLigaKlubu = new System.Windows.Forms.TextBox();
            this.tbKlub = new System.Windows.Forms.TextBox();
            this.btUlozit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numVaha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisloDresu)).BeginInit();
            this.SuspendLayout();
            // 
            // numVaha
            // 
            this.numVaha.Location = new System.Drawing.Point(130, 25);
            this.numVaha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numVaha.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numVaha.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numVaha.Name = "numVaha";
            this.numVaha.Size = new System.Drawing.Size(180, 24);
            this.numVaha.TabIndex = 74;
            this.numVaha.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cmbPozice
            // 
            this.cmbPozice.FormattingEnabled = true;
            this.cmbPozice.Items.AddRange(new object[] {
            "Brankář",
            "Obránce",
            "Záložník",
            "Útočník"});
            this.cmbPozice.Location = new System.Drawing.Point(130, 89);
            this.cmbPozice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPozice.Name = "cmbPozice";
            this.cmbPozice.Size = new System.Drawing.Size(180, 26);
            this.cmbPozice.TabIndex = 73;
            // 
            // numCisloDresu
            // 
            this.numCisloDresu.Location = new System.Drawing.Point(130, 159);
            this.numCisloDresu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCisloDresu.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numCisloDresu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCisloDresu.Name = "numCisloDresu";
            this.numCisloDresu.Size = new System.Drawing.Size(180, 24);
            this.numCisloDresu.TabIndex = 72;
            this.numCisloDresu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbZlataKopacka
            // 
            this.cbZlataKopacka.AutoSize = true;
            this.cbZlataKopacka.Location = new System.Drawing.Point(666, 219);
            this.cbZlataKopacka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbZlataKopacka.Name = "cbZlataKopacka";
            this.cbZlataKopacka.Size = new System.Drawing.Size(120, 22);
            this.cbZlataKopacka.TabIndex = 71;
            this.cbZlataKopacka.Text = "Zlatá kopačka";
            this.cbZlataKopacka.UseVisualStyleBackColor = true;
            // 
            // cbZlatyMic
            // 
            this.cbZlatyMic.AutoSize = true;
            this.cbZlatyMic.Location = new System.Drawing.Point(130, 219);
            this.cbZlatyMic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbZlatyMic.Name = "cbZlatyMic";
            this.cbZlatyMic.Size = new System.Drawing.Size(86, 22);
            this.cbZlatyMic.TabIndex = 70;
            this.cbZlatyMic.Text = "Zlatý míč";
            this.cbZlatyMic.UseVisualStyleBackColor = true;
            // 
            // lbCisloDresu
            // 
            this.lbCisloDresu.AutoSize = true;
            this.lbCisloDresu.Location = new System.Drawing.Point(27, 162);
            this.lbCisloDresu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCisloDresu.Name = "lbCisloDresu";
            this.lbCisloDresu.Size = new System.Drawing.Size(87, 18);
            this.lbCisloDresu.TabIndex = 69;
            this.lbCisloDresu.Text = "Číslo dresu:";
            // 
            // lbKlub
            // 
            this.lbKlub.AutoSize = true;
            this.lbKlub.Location = new System.Drawing.Point(558, 166);
            this.lbKlub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKlub.Name = "lbKlub";
            this.lbKlub.Size = new System.Drawing.Size(41, 18);
            this.lbKlub.TabIndex = 68;
            this.lbKlub.Text = "Klub:";
            // 
            // lbLigaKlubu
            // 
            this.lbLigaKlubu.AutoSize = true;
            this.lbLigaKlubu.Location = new System.Drawing.Point(558, 97);
            this.lbLigaKlubu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLigaKlubu.Name = "lbLigaKlubu";
            this.lbLigaKlubu.Size = new System.Drawing.Size(78, 18);
            this.lbLigaKlubu.TabIndex = 67;
            this.lbLigaKlubu.Text = "Liga klubu:";
            // 
            // lbZemeKlubu
            // 
            this.lbZemeKlubu.AutoSize = true;
            this.lbZemeKlubu.Location = new System.Drawing.Point(558, 32);
            this.lbZemeKlubu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbZemeKlubu.Name = "lbZemeKlubu";
            this.lbZemeKlubu.Size = new System.Drawing.Size(89, 18);
            this.lbZemeKlubu.TabIndex = 66;
            this.lbZemeKlubu.Text = "Země klubu:";
            // 
            // lbPozice
            // 
            this.lbPozice.AutoSize = true;
            this.lbPozice.Location = new System.Drawing.Point(27, 93);
            this.lbPozice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPozice.Name = "lbPozice";
            this.lbPozice.Size = new System.Drawing.Size(58, 18);
            this.lbPozice.TabIndex = 65;
            this.lbPozice.Text = "Pozice:";
            // 
            // lbVaha
            // 
            this.lbVaha.AutoSize = true;
            this.lbVaha.Location = new System.Drawing.Point(27, 28);
            this.lbVaha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVaha.Name = "lbVaha";
            this.lbVaha.Size = new System.Drawing.Size(71, 18);
            this.lbVaha.TabIndex = 64;
            this.lbVaha.Text = "Váha(kg):";
            // 
            // tbZemeKlubu
            // 
            this.tbZemeKlubu.Location = new System.Drawing.Point(666, 28);
            this.tbZemeKlubu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbZemeKlubu.Name = "tbZemeKlubu";
            this.tbZemeKlubu.Size = new System.Drawing.Size(223, 24);
            this.tbZemeKlubu.TabIndex = 63;
            // 
            // tbLigaKlubu
            // 
            this.tbLigaKlubu.Location = new System.Drawing.Point(666, 93);
            this.tbLigaKlubu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLigaKlubu.Name = "tbLigaKlubu";
            this.tbLigaKlubu.Size = new System.Drawing.Size(223, 24);
            this.tbLigaKlubu.TabIndex = 62;
            // 
            // tbKlub
            // 
            this.tbKlub.Location = new System.Drawing.Point(666, 162);
            this.tbKlub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKlub.Name = "tbKlub";
            this.tbKlub.Size = new System.Drawing.Size(223, 24);
            this.tbKlub.TabIndex = 61;
            // 
            // btUlozit
            // 
            this.btUlozit.Location = new System.Drawing.Point(282, 263);
            this.btUlozit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUlozit.Name = "btUlozit";
            this.btUlozit.Size = new System.Drawing.Size(354, 69);
            this.btUlozit.TabIndex = 60;
            this.btUlozit.Text = "Uložit";
            this.btUlozit.UseVisualStyleBackColor = true;
            // 
            // Editace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 359);
            this.ControlBox = false;
            this.Controls.Add(this.numVaha);
            this.Controls.Add(this.cmbPozice);
            this.Controls.Add(this.numCisloDresu);
            this.Controls.Add(this.cbZlataKopacka);
            this.Controls.Add(this.cbZlatyMic);
            this.Controls.Add(this.lbCisloDresu);
            this.Controls.Add(this.lbKlub);
            this.Controls.Add(this.lbLigaKlubu);
            this.Controls.Add(this.lbZemeKlubu);
            this.Controls.Add(this.lbPozice);
            this.Controls.Add(this.lbVaha);
            this.Controls.Add(this.tbZemeKlubu);
            this.Controls.Add(this.tbLigaKlubu);
            this.Controls.Add(this.tbKlub);
            this.Controls.Add(this.btUlozit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Editace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editace";
            ((System.ComponentModel.ISupportInitialize)(this.numVaha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCisloDresu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numVaha;
        private System.Windows.Forms.ComboBox cmbPozice;
        private System.Windows.Forms.NumericUpDown numCisloDresu;
        private System.Windows.Forms.CheckBox cbZlataKopacka;
        private System.Windows.Forms.CheckBox cbZlatyMic;
        private System.Windows.Forms.Label lbCisloDresu;
        private System.Windows.Forms.Label lbKlub;
        private System.Windows.Forms.Label lbLigaKlubu;
        private System.Windows.Forms.Label lbZemeKlubu;
        private System.Windows.Forms.Label lbPozice;
        private System.Windows.Forms.Label lbVaha;
        private System.Windows.Forms.TextBox tbZemeKlubu;
        private System.Windows.Forms.TextBox tbLigaKlubu;
        private System.Windows.Forms.TextBox tbKlub;
        private System.Windows.Forms.Button btUlozit;
    }
}