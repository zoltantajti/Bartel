using System;
using System.Windows.Forms;
using libsql;
using OfficeSDK;

namespace BarTelGSM
{
    public partial class Napi_Jelentes : Form
    {
        MySQL db;
        public Napi_Jelentes()
        {
            InitializeComponent();
            db = new MySQL();
            this.Text = "Napi Jelentés | Bar-Tel GSM | " + Program.bolt;
            string dt = DateTime.Now.ToString();
            string[] t = dt.Split(' ');
            lbl_datum.Text = t[0].Replace('.','-');

            getSums();
            getAllTetel();
            getKPKI();
            getSzerviz();
            getTelVetel();
            getTelElad();
            getTotal();
        }

        private void getSums()
        {
            string[] tetel = db.getNapiTetelEladas(Program.bolt);
            string tetel_db = tetel[1];
            string tetel_ft = tetel[0];
            gb_tEald.Text = "Termék eladás: " + tetel_db + " db, " + tetel_ft + " Ft";

            string[] tel_vet = db.getNapiTelefonVetel(Program.bolt);
            string tel_vet_db = tel_vet[0];
            string tel_vet_ft = tel_vet[1];
            gb_telVetel.Text = "Telefon vétel: " + tel_vet_db + " db, " + tel_vet_ft + " Ft";

            string[] tel_elad = db.getNapiTelefonElad(Program.bolt);
            string tel_elad_db = tel_elad[0];
            string tel_elad_ft = tel_elad[1];
            gb_tel_elad.Text = "Telefon eladás: " + tel_elad_db + " db, " + tel_elad_ft + " Ft";

            string[] szerviz = db.getNapiSzerviz(Program.bolt);
            string szerviz_db = szerviz[0];
            string szerviz_ft = szerviz[1];
            gb_szerviz.Text = "Szervíz: " + szerviz_db + " db, " + szerviz_ft + " Ft";

            string[] kpki = db.getNapiKPKI(Program.bolt);
            string kpki_db = kpki[0];
            string kpki_ft = kpki[1];
            gb_kpki.Text = "KP KI: " + kpki_db + " db, " + kpki_ft + " Ft";
        }
        private void getAllTetel()
        {
            dgv_tetel.DataSource = db.getDT("tetel_eladas", "tetel,ar", "WHERE bolt='" + Program.bolt + "' AND nap=CURRENT_DATE");
            dgv_tetel.Columns[0].HeaderText = "Tétel neve";
            dgv_tetel.Columns[1].HeaderText = "Ára";
        }
        private void getKPKI()
        {
            dgv_kpki.DataSource = db.getDT("kpki", "ki,mennyi", "WHERE bolt='" + Program.bolt + "' AND nap=CURRENT_DATE");
            dgv_kpki.Columns[0].HeaderText = "Ki";
            dgv_kpki.Columns[1].HeaderText = "Mennyit";
        }
        private void getSzerviz()
        {
            dgv_szerviz.DataSource = db.getDT("szerviz", "tipus,ar", "WHERE bolt='" + Program.bolt + "' AND status='Fizetve' AND vissza_nap=CURRENT_DATE");
            dgv_szerviz.Columns[0].HeaderText = "Típus";
            dgv_szerviz.Columns[1].HeaderText = "Ár";
        }
        private void getTelVetel()
        {
            dgv_tel_vetel.DataSource = db.getDT("telefonok", "tipus,beszerzesi_ar", "WHERE bolt='" + Program.bolt + "' AND nap=CURRENT_DATE");
            dgv_tel_vetel.Columns[0].HeaderText = "Típus";
            dgv_tel_vetel.Columns[1].HeaderText = "Ár";
        }
        private void getTelElad()
        {
            dgv_telElad.DataSource = db.getDT("telefonok", "tipus,teny_eladasi_ar", "WHERE bolt='" + Program.bolt + "' AND eladva=1 AND eladas_datum=CURRENT_DATE");
            dgv_telElad.Columns[0].HeaderText = "Típus";
            dgv_telElad.Columns[1].HeaderText = "Ár";
        }
        private void getTotal()
        {
            string[] nap = db.get("napi_jelentes", "*", "WHERE bolt='" + Program.bolt + "' AND datum=CURRENT_DATE");
            lbl_nyito_kassza.Text = nap[3];
            lbl_kassza_ft.Text = nap[14];
        }

        private void btn_export_Excel_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            excel.SaveToExcel(Program.bolt);
        }
    }
}
