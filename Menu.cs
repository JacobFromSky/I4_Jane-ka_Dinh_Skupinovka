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
    public partial class Menu : Form
    {
        public static string connectionString;
        List<Fotbalista> listFotbalistu = new List<Fotbalista>();
        Fotbalista fotbalista;
        public Menu()
        {
            InitializeComponent();
        }

        int index = -1;

        private void Menu_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            listFotbalistu.Clear();
            lboxPolozky.Items.Clear();

            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = H:\JJ_TD_Fotbalisti.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection connectionCommand = new SqlConnection(connectionString);
            string selectionStringFotbalista = "SELECT * FROM [Fotbalista]";
            SqlCommand selectionCommand = new SqlCommand(selectionStringFotbalista, connectionCommand);
            connectionCommand.Open();
            SqlDataReader readCommand = selectionCommand.ExecuteReader();
            //SqlDataReader readCommandKlubID = selectionCommandKlubID.ExecuteReader();
            while (readCommand.Read())
            {
                listFotbalistu.Add(fotbalista = new Fotbalista((string)readCommand["Jmeno"], (string)readCommand["Prijmeni"], (DateTime)readCommand["DatumNarozeni"], (int)readCommand[4], (int)readCommand[5], (int)readCommand[6], (bool)readCommand[7], (int)readCommand[8], (int)readCommand[9], (int)readCommand[10], (int)readCommand[11], (int)readCommand[12], (bool)readCommand[13], (bool)readCommand[14]));
                lboxPolozky.Items.Add(readCommand["Jmeno"] + " " + readCommand["Prijmeni"]);
            }
            connectionCommand.Close();
        }

        private void Blocation() // Vypisuje informace o zvolené položce, pokud položka není vybrána tak vypisuje bez informací, povoluje a zakazuje tlačítka na smazání a editaci
        {
            if (lboxPolozky.SelectedIndex == -1)
            {
                btUpravit.Enabled = false;
                btSmazat.Enabled = false;
                lbDatumNarozeni.Text = "Datum narození: ?";
                lbZemeNarozeni.Text = "Země narození: ?";
                lbVyska.Text = "Výška(cm): ?";
                lbVaha.Text = "Váha(kg): ?";
                lbZemeKlubu.Text = "Země klubu: ?";
                lbLigaKlubu.Text = "Liga klubu: ?";
                lbKlub.Text = "Klub: ?";
                lbPozice.Text = "Pozice: ?";
                lbCisloDresu.Text = "Číslo dresu: ?";
                lbNoha.Text = "Pravá/levá noha: ?";
                lbZlatyMic.Text = "Zlatý míč: ?";
                lbZlataKopacka.Text = "Zlatá kopačka: ?";
            }
            else
            {
                btUpravit.Enabled = true;
                btSmazat.Enabled = true;


                lbDatumNarozeni.Text = "Datum narození: " + listFotbalistu[index].datumNarozeni;
                lbZemeNarozeni.Text = "Země narození: " + listFotbalistu[index].ConvertIndexToData(listFotbalistu[index].zemeNarozeniIndex, "ZemeID");
                lbVyska.Text = "Výška(cm): " + listFotbalistu[index].vyska;
                lbVaha.Text = "Váha(kg): " + listFotbalistu[index].vaha;
                lbZemeKlubu.Text = "Země klubu: " + listFotbalistu[index].ConvertIndexToData(listFotbalistu[index].zemeKlubuIndex, "ZemeID");
                lbLigaKlubu.Text = "Liga klubu: " + listFotbalistu[index].ConvertIndexToData(listFotbalistu[index].ligaKlubuIndex, "LigaID");
                lbKlub.Text = "Klub: " + listFotbalistu[index].ConvertIndexToData(listFotbalistu[index].klubIndex, "KlubID");
                lbPozice.Text = "Pozice: " + listFotbalistu[index].ConvertIndexToData(listFotbalistu[index].poziceIndex, "PoziceID");
                lbCisloDresu.Text = "Číslo dresu: " + listFotbalistu[index].cisloDresu;
                lbNoha.Text = "Pravá / levá noha: " + listFotbalistu[index].pravaNoha;
                lbZlatyMic.Text = "Zlatý míč: " + listFotbalistu[index].zlatyMic;
                lbZlataKopacka.Text = "Zlaté kopačky: " + listFotbalistu[index].zlataKopacka;
            }
        }

        private void lboxPolozky_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lboxPolozky.SelectedIndex;
            Blocation();
        }

        private void btNovaPolozka_Click(object sender, EventArgs e)
        {
            NovaPolozka novaPolozka = new NovaPolozka();
            novaPolozka.ShowDialog();
            Clear();
        }
    }
}
