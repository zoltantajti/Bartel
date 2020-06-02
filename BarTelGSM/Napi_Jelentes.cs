using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
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
            lbl_bolt.Text = Program.bolt;
            init();
        }
        public void init()
        {
            p_loading.Visible = true;
            p_loading.Dock = DockStyle.Fill;
            lbl_process.Text = "Betöltés folyamatban!";
            gb_tEald.Visible = false;
            gb_telVetel.Visible = false;
            gb_tel_elad.Visible = false;
            gb_szerviz.Visible = false;
            gb_kpki.Visible = false;
            gb_sum.Visible = false;
            gb_fncs.Visible = false;

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            p_loading.Visible = false;
            p_loading.Dock = DockStyle.None;
            gb_tEald.Visible = true;
            gb_telVetel.Visible = true;
            gb_tel_elad.Visible = true;
            gb_szerviz.Visible = true;
            gb_kpki.Visible = true;
            gb_sum.Visible = true;
            gb_fncs.Visible = true;
            lbl_process.Text = "";
        }

        private async void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            await getSums();
            Thread.Sleep(1000);
            await getAllTetel();
            Thread.Sleep(1000);
            await getKPKI();
            Thread.Sleep(1000);
            await getSzerviz();
            Thread.Sleep(1000);
            await getTelVetel();
            Thread.Sleep(1000);
            await getTelElad();
            Thread.Sleep(1000);
            await getTotal();
        }

        private async Task<bool> getSums()
        {
            string[] tetel = db.getNapiTetelEladas(Program.bolt);
            string tetel_db = tetel[1];
            string tetel_ft = tetel[0];
            gb_tEald.BeginInvoke(new MethodInvoker(delegate () {
                gb_tEald.Text = "Termék eladás: " + tetel_db + " db, " + tetel_ft + " Ft";
            }));

            string[] tel_vet = db.getNapiTelefonVetel(Program.bolt);
            string tel_vet_db = tel_vet[0];
            string tel_vet_ft = tel_vet[1];
            gb_telVetel.BeginInvoke(new MethodInvoker(delegate ()
            {
                gb_telVetel.Text = "Telefon vétel: " + tel_vet_db + " db, " + tel_vet_ft + " Ft";
            }));

            string[] tel_elad = db.getNapiTelefonElad(Program.bolt);
            string tel_elad_db = tel_elad[0];
            string tel_elad_ft = tel_elad[1];
            gb_tel_elad.BeginInvoke(new MethodInvoker(delegate ()
            {
                gb_tel_elad.Text = "Telefon eladás: " + tel_elad_db + " db, " + tel_elad_ft + " Ft";
            }));

            string[] szerviz = db.getNapiSzerviz(Program.bolt);
            string szerviz_db = szerviz[0];
            string szerviz_ft = szerviz[1];
            gb_szerviz.BeginInvoke(new MethodInvoker(delegate ()
            {
                gb_szerviz.Text = "Szervíz: " + szerviz_db + " db, " + szerviz_ft + " Ft";
            }));

            string[] kpki = db.getNapiKPKI(Program.bolt);
            string kpki_db = kpki[0];
            string kpki_ft = kpki[1];
            gb_kpki.BeginInvoke(new MethodInvoker(delegate ()
            {
                gb_kpki.Text = "KP KI: " + kpki_db + " db, " + kpki_ft + " Ft";
            }));
            return true;
        }
        private async Task<bool> getAllTetel()
        {
            dgv_tetel.BeginInvoke(new MethodInvoker(delegate ()
            {
                db.close();
                db.open();
                dgv_tetel.DataSource = db.getDT("tetel_eladas", "tetel,ar", "WHERE bolt='" + Program.bolt + "' AND nap=CURRENT_DATE");
                dgv_tetel.Columns[0].HeaderText = "Tétel neve";
                dgv_tetel.Columns[1].HeaderText = "Ára";
            }));
            return true;
        }
        private async Task<bool> getKPKI()
        {
            dgv_kpki.BeginInvoke(new MethodInvoker(delegate ()
            {
                
                dgv_kpki.DataSource = db.getDT("kpki", "ki,mennyi", "WHERE bolt='" + Program.bolt + "' AND nap=CURRENT_DATE");
                dgv_kpki.Columns[0].HeaderText = "Ki";
                dgv_kpki.Columns[1].HeaderText = "Mennyit";
            }));
            return true;
        }
        private async Task<bool> getSzerviz()
        {
            dgv_szerviz.BeginInvoke(new MethodInvoker(delegate ()
            {
                
                dgv_szerviz.DataSource = db.getDT("szerviz", "tipus,ar", "WHERE bolt='" + Program.bolt + "' AND status='Fizetve' AND vissza_nap=CURRENT_DATE");
                dgv_szerviz.Columns[0].HeaderText = "Típus";
                dgv_szerviz.Columns[1].HeaderText = "Ár";
            }));
            return true;
        }
        private async Task<bool> getTelVetel()
        {
            dgv_tel_vetel.BeginInvoke(new MethodInvoker(delegate ()
            {
                
                dgv_tel_vetel.DataSource = db.getDT("telefonok", "tipus,beszerzesi_ar", "WHERE bolt='" + Program.bolt + "' AND nap=CURRENT_DATE");
                dgv_tel_vetel.Columns[0].HeaderText = "Típus";
                dgv_tel_vetel.Columns[1].HeaderText = "Ár";
            }));
            return true;
        }
        private async Task<bool> getTelElad()
        {
            dgv_telElad.BeginInvoke(new MethodInvoker(delegate ()
            {
               
                dgv_telElad.DataSource = db.getDT("telefonok", "tipus,teny_eladasi_ar", "WHERE bolt='" + Program.bolt + "' AND eladva=1 AND eladas_datum=CURRENT_DATE");
                dgv_telElad.Columns[0].HeaderText = "Típus";
                dgv_telElad.Columns[1].HeaderText = "Ár";
            }));
            return true;
        }
        private async Task<bool> getTotal()
        {
            
            string[] nap = db.get("napi_jelentes", "*", "WHERE bolt='" + Program.bolt + "' AND datum=CURRENT_DATE");
            lbl_nyito_kassza.BeginInvoke(new MethodInvoker(delegate () { 
                lbl_nyito_kassza.Text = nap[3];
            }));
            lbl_kassza_ft.BeginInvoke(new MethodInvoker(delegate ()
            {
                lbl_kassza_ft.Text = nap[14];
            }));
            return true;
        }

        private void btn_export_Excel_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            excel.SaveToExcel(Program.bolt);
        }

        
    }
}
