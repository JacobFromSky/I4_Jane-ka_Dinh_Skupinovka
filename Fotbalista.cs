using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace I4_Janečka_Dinh_Skupinovka
{
    class Fotbalista
    {
        // Použít convertor na datetime a bool, kvůli zpětnému uložení, teď je to jako private metoda chci to jako convertor jako index to data
        public string jmeno, prijmeni;
        public string datumNarozeni;
        public int zemeNarozeniIndex, vyska, vaha, poziceIndex, zemeKlubuIndex, ligaKlubuIndex, klubIndex, cisloDresu;
        public string pravaNoha, zlatyMic, zlataKopacka;

        public Fotbalista(string Jmeno, string Prijmeni, DateTime Datumnarozeni, int ZemeNarozeni, int Vyska, int Vaha, bool Pravanoha, int Pozice, int ZemeKlubu, int LigaKlubu, int Klub, int CisloDresu, bool Zlatymic, bool Zlatakopacka)
        {
            jmeno = Jmeno;
            prijmeni = Prijmeni;
            datumNarozeni = DatumNarozeni(Datumnarozeni);
            zemeNarozeniIndex = ZemeNarozeni;
            vyska = Vyska;
            vaha = Vaha;
            pravaNoha = Noha(Pravanoha);
            poziceIndex = Pozice;
            zemeKlubuIndex = ZemeKlubu;
            ligaKlubuIndex = LigaKlubu;
            klubIndex = Klub;
            cisloDresu = CisloDresu;
            zlatyMic = ZlatyMic(Zlatymic);
            zlataKopacka = ZlataKopacka(Zlatakopacka);
        }

        public string ConvertIndexToData(int variable, string nazevTabulky)
        {
            string vysledek = "";
            string connectionString = Menu.connectionString;
            SqlConnection connectionCommand = new SqlConnection(connectionString);
            string selectionString = "SELECT * FROM" + " [" + nazevTabulky + "]";
            SqlCommand selectionCommand = new SqlCommand(selectionString, connectionCommand);
            connectionCommand.Open();
            SqlDataReader readCommand = selectionCommand.ExecuteReader();
            while (readCommand.Read())
            {
                if (variable == Convert.ToInt32(readCommand[0]))
                {
                    vysledek = readCommand[1].ToString();
                }
            }

            return vysledek;
        }

        private string DatumNarozeni(DateTime datumnarozeni)
        {
            string vysledek = "";

            vysledek = Convert.ToString(datumnarozeni.Day + "." + datumnarozeni.Month + "." + datumnarozeni.Year);

            return vysledek;

        }

        private string Noha(bool noha)
        {
            string vysledek = "";

            if (noha)
                vysledek = "Pravá";
            else
                vysledek = "Levá";
                return vysledek;

        }
        private string ZlatyMic(bool zlatymic)
        {
            string vysledek = "";

            if (zlatymic)
                vysledek = "Ano";
            else
                vysledek = "Ne";
            return vysledek;

        }
        private string ZlataKopacka(bool zlatakopacka)
        {
            string vysledek = "";

            if (zlatakopacka)
                vysledek = "Ano";
            else
                vysledek = "Ne";
            return vysledek;

        }
    }
}
