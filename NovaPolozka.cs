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
        bool texty, pravak, pozice;
        private void NovaPolozka_TextChanged(object sender, EventArgs e) // hlídá, aby byl text v boxech
        {
            if (tbDatumNarozeni.Text == "" || tbJmeno.Text == "" || tbKlub.Text == "" || tbLigaKlubu.Text == "" || tbPrijmeni.Text == "" || tbZemeKlubu.Text == "" || tbZemeNarozeni.Text == "")
            {
                texty = false;
            }
            else
            {
                texty = true;
            }
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

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPridat_Click(object sender, EventArgs e)
        {
            string connectionString = I4_Janečka_Dinh_Skupinovka.Menu.connectionString;
            string commandString = "INSERT INTO [Fotbalista] VALUES(Jmeno, Prijmeni, DatumNarozeni, ZemeNarozeni, Vyska, Vaha, PravaNoha, Pozice, ZemeKlubu, LigaKlubu, Klub, CisloDresu, ZlatyMic, ZlataKopacka)";
          
        }

        private void cmbPozice_SelectedIndexChanged(object sender, EventArgs e) // hlídá, aby uživatel vybral pozici hráče
        {
            if (cmbPozice.SelectedIndex == -1)
            {
                pozice = false;
            }
            else
            {
                pozice = true;
            }
            Podmínky();
        }

        private void Podmínky() // podmínka, aby uživatel musel vyplňit nejdřívě vše a poté až vybral portrét
        {
            if (pozice == true && pravak == true && texty == true)
            {
                btPridat.Enabled = true;
            }
            else
            {
                btPridat.Enabled = false;
            }
        }
    }
}
