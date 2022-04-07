using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace I4_Janečka_Dinh_Skupinovka
{
    public partial class NovaPolozka : Form
    {
        public NovaPolozka()
        {
            InitializeComponent();
        }
        bool texty, pravak;
        SqlConnection connectionCommand = new SqlConnection(I4_Janečka_Dinh_Skupinovka.Menu.connectionString);
        private void NovaPolozka_Load(object sender, EventArgs e)
        {
            dtpDatumNarozeni.MaxDate = new DateTime(DateTime.Now.Year - 15, DateTime.Now.Month, DateTime.Now.Day);
            // Klub
            ComboBoxy("KlubID", cmbKlub);
            // LigaKlubu
            ComboBoxy("LigaID", cmbLigaKlubu);
            // ZemeNarozeni
            ComboBoxy("ZemeID", cmbZemeNarozeni);
            // ZemeKlubu
            ComboBoxy("ZemeID", cmbZemeKlubu);
            // Pozice
            ComboBoxy("PoziceID", cmbPozice);

            cmbKlub.SelectedIndex = cmbLigaKlubu.SelectedIndex = cmbZemeKlubu.SelectedIndex = cmbZemeNarozeni.SelectedIndex = cmbPozice.SelectedIndex = 0;
        }

        private void ComboBoxy(string nazevTabulky, ComboBox cmb)
        {
            string Prikaz = "SELECT * FROM" + " [" + nazevTabulky + "]"; ;
            connectionCommand.Open();
            SqlCommand prikaz = new SqlCommand(Prikaz, connectionCommand);
            SqlDataReader zaznamy = prikaz.ExecuteReader();
            while (zaznamy.Read())
            {
                cmb.Items.Add(zaznamy[1].ToString());
            }
            connectionCommand.Close();
        }

        private void NovaPolozka_TextChanged(object sender, EventArgs e) // hlídá, aby byl text v boxech
        {
            // tbJmeno.Text.Trim
            if (tbJmeno.Text.Length >= 2 && tbPrijmeni.Text.Length >= 2)
            {
                texty = true;
            }
            else
            {
                texty = false;
            }
            Podmínky();
        }

        private void rbPravak_CheckedChanged(object sender, EventArgs e) // hlídá, aby uživatel vybral jakou má hráč silnější nohu
        {
            if (rbLevak.Checked == false && rbPravak.Checked == false)
            {
                pravak = false;
            }
            else
            {
                pravak = true;
            }
            Podmínky();
        }

        private void Podmínky() // podmínka, aby uživatel musel vyplňit nejdřívě vše a poté až vybral portrét
        {
            if (pravak == true && texty == true)
            {
                btPridat.Enabled = true;
            }
            else
            {
                btPridat.Enabled = false;
            }
        }

        private void btPridat_Click(object sender, EventArgs e)
        {
            // kvůli tomu abychom viděli celý commandString, tak když jsme dali enter, tak se tam přidali pluska sami (+)
            string commandString = "INSERT INTO [Fotbalista] " +
            "(Jmeno, Prijmeni, DatumNarozeni, ZemeNarozeni, Vyska, Vaha, PravaNoha, Pozice, ZemeKlubu, LigaKlubu, Klub, CisloDresu, ZlatyMic, ZlataKopacka) " +
            "VALUES" +
            "(@jmeno, @prijmeni, @datumNarozeni, @zemeNarozeni, @vyska, @vaha, @pravaNoha, @pozice, @zemeKlubu, @ligaKlubu, @klub, @cisloDresu, @zlatyMic, @zlataKopacka)";
            connectionCommand.Open();
            SqlCommand selectionCommand = new SqlCommand(commandString, connectionCommand);
            selectionCommand.Parameters.AddWithValue("@jmeno", tbJmeno.Text);
            selectionCommand.Parameters.AddWithValue("@prijmeni", tbPrijmeni.Text);
            selectionCommand.Parameters.AddWithValue("@datumNarozeni", dtpDatumNarozeni.Value);
            selectionCommand.Parameters.AddWithValue("@zemeNarozeni", cmbZemeNarozeni.SelectedIndex + 1);
            selectionCommand.Parameters.AddWithValue("@vyska", numVyska.Value);
            selectionCommand.Parameters.AddWithValue("@vaha", numVaha.Value);
            selectionCommand.Parameters.AddWithValue("@pravaNoha", rbPravak.Checked);
            selectionCommand.Parameters.AddWithValue("@pozice", cmbPozice.SelectedIndex + 1);
            selectionCommand.Parameters.AddWithValue("@zemeKlubu", cmbZemeKlubu.SelectedIndex + 1);
            selectionCommand.Parameters.AddWithValue("@ligaKlubu", cmbLigaKlubu.SelectedIndex + 1);
            selectionCommand.Parameters.AddWithValue("@klub", cmbKlub.SelectedIndex + 3);
            selectionCommand.Parameters.AddWithValue("@cisloDresu", numCisloDresu.Value);
            selectionCommand.Parameters.AddWithValue("@zlatyMic", cbZlatyMic.Checked);
            selectionCommand.Parameters.AddWithValue("@zlataKopacka", cbZlataKopacka.Checked);
            selectionCommand.ExecuteNonQuery();
            connectionCommand.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
