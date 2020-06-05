using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
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
        public void init(bool fromFile = false)
        {
            if (fromFile == false)
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
                groupBox6.Visible = false;

                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += Bw_DoWork;
                bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
                bw.RunWorkerAsync();
            }
            else
            {
                this.Text = "Napi jelentés | Bar-Tel GSM | Megnyitott file";
                int i = 0; //sorszám - 1;

                int termekStart = Array.IndexOf(this.sorok, "Tétel eladások:");
                int telVetStart = Array.IndexOf(this.sorok, "Telefon vétel:");
                int telEladStart = Array.IndexOf(this.sorok, "Telefon eladás:");
                int szervizStart = Array.IndexOf(this.sorok, "Szervíz:");
                int kpkistart = Array.IndexOf(this.sorok, "KP KI:");
                int vege = Array.IndexOf(this.sorok, "end");

                dgv_tetel.DataSource = null;
                dgv_tetel.Columns.Add("termek", "Termék");
                dgv_tetel.Columns.Add("ar", "Ár");

                dgv_tel_vetel.DataSource = null;
                dgv_tel_vetel.Columns.Add("tipus", "Típus");
                dgv_tel_vetel.Columns.Add("besz_ar", "Ár");

                dgv_telElad.DataSource = null;
                dgv_telElad.Columns.Add("tipus", "Típus");
                dgv_telElad.Columns.Add("besz_ar", "Ár");

                dgv_kpki.DataSource = null;
                dgv_kpki.Columns.Add("ki", "Ki");
                dgv_kpki.Columns.Add("mennyi", "Összeg");

                dgv_szerviz.DataSource = null;
                dgv_szerviz.Columns.Add("tipus", "Típus");
                dgv_szerviz.Columns.Add("ar", "Ár");

                foreach (string sor in this.sorok)
                {
                    if (i == 0)
                    { //Boltnév
                        string[] s = sor.Split(':');
                        lbl_bolt.Text = s[1].Trim();
                    };
                    if(i == 1)
                    { //Dátum
                        string[] s = sor.Split(':');
                        string[] d = s[1].Split(' ');
                        lbl_datum.Text = d[1].Trim();
                    };
                    if (i == 2)
                    { //Nyitó kassza
                        string[] s = sor.Split(':');
                        lbl_nyito_kassza.Text = s[1].Trim();
                    };
                    if (i == 3)
                    { //Záró kassza
                        string[] s = sor.Split(':');
                        lbl_kassza_ft.Text = s[1].Trim();
                    };
                    if(i == 4)
                    { //Tétel eladás fejléc
                        string[] s = sor.Split(':');
                        string[] d = s[1].Trim().Split(',');
                        gb_tEald.Text = "Tétel eladás: " + d[0] + ", " + d[1];
                    };
                    if (i == 5)
                    { //Telefon vétel
                        string[] s = sor.Split(':');
                        string[] d = s[1].Trim().Split(',');
                        gb_telVetel.Text = "Telefon vétel: " + d[0] + ", " + d[1];
                    };
                    if (i == 6)
                    { //Telefon eladás
                        string[] s = sor.Split(':');
                        string[] d = s[1].Trim().Split(',');
                        gb_tel_elad.Text = "Telefon eladás: " + d[0] + ", " + d[1];
                    };
                    if (i == 7)
                    { //Szervíz
                        string[] s = sor.Split(':');
                        string[] d = s[1].Trim().Split(',');
                        gb_szerviz.Text = "Szervíz: " + d[0] + ", " + d[1];
                    };
                    if (i == 8)
                    { //KP KI
                        string[] s = sor.Split(':');
                        string[] d = s[1].Trim().Split(',');
                        gb_kpki.Text = "KP KI: " + d[0] + ", " + d[1];
                    };
                    
                    if(i > termekStart && i < telVetStart - 1)
                    { //Termék eladások
                        string[] s = sor.Split(';');
                        dgv_tetel.Rows.Add(
                            new object[] { s[0], s[1] }
                        );
                    }

                    if (i > telVetStart && i < telEladStart - 1)
                    { //Telefon vétel
                        string[] s = sor.Split(';');
                        dgv_tel_vetel.Rows.Add(
                            new object[] { s[0], s[1] }
                        );
                    }

                    if (i > telEladStart && i < szervizStart - 1)
                    { //Telefon vétel
                        string[] s = sor.Split(';');
                        dgv_telElad.Rows.Add(
                            new object[] { s[0], s[1] }
                        );
                    }

                    if (i > szervizStart && i < kpkistart - 1)
                    { //Telefon vétel
                        string[] s = sor.Split(';');
                        dgv_szerviz.Rows.Add(
                            new object[] { s[0], s[1] }
                        );
                    }

                    if (i > kpkistart && i < vege - 1)
                    { //Telefon vétel
                        string[] s = sor.Split(';');
                        dgv_kpki.Rows.Add(
                            new object[] { s[0], s[1] }
                        );
                    }
                    i++;
                }
            }
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
            groupBox6.Visible = true;
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

        public string _nyit;
        public string _zar;
        public string _tdb;
        public string _tft;
        public string _telEDB;
        public string _telEFt;
        public string _telVDB;
        public string _telVFt;
        public string _szervizDb;
        public string _szervizFt;
        public string _kpkiDB;
        public string _kpkiFt;
        public string[] sorok;

        private async Task<bool> getSums()
        {
            string[] tetel = db.getNapiTetelEladas(Program.bolt);
            string tetel_db = tetel[1];
            string tetel_ft = tetel[0];
            this._tdb = tetel_db;
            this._tft = tetel_ft;
            gb_tEald.BeginInvoke(new MethodInvoker(delegate () {
                gb_tEald.Text = "Termék eladás: " + tetel_db + " db, " + tetel_ft + " Ft";
            }));

            string[] tel_vet = db.getNapiTelefonVetel(Program.bolt);
            string tel_vet_db = tel_vet[0];
            string tel_vet_ft = tel_vet[1];
            this._telVDB = tel_vet_db;
            this._telVFt = tel_vet_ft;
            gb_telVetel.BeginInvoke(new MethodInvoker(delegate ()
            {
                gb_telVetel.Text = "Telefon vétel: " + tel_vet_db + " db, " + tel_vet_ft + " Ft";
            }));

            string[] tel_elad = db.getNapiTelefonElad(Program.bolt);
            string tel_elad_db = tel_elad[0];
            string tel_elad_ft = tel_elad[1];
            this._telEDB = tel_elad_db;
            this._telEFt = tel_elad_ft;
            gb_tel_elad.BeginInvoke(new MethodInvoker(delegate ()
            {
                gb_tel_elad.Text = "Telefon eladás: " + tel_elad_db + " db, " + tel_elad_ft + " Ft";
            }));

            string[] szerviz = db.getNapiSzerviz(Program.bolt);
            string szerviz_db = szerviz[0];
            string szerviz_ft = szerviz[1];
            this._szervizDb = szerviz_db;
            this._szervizFt = szerviz_ft;
            gb_szerviz.BeginInvoke(new MethodInvoker(delegate ()
            {
                gb_szerviz.Text = "Szervíz: " + szerviz_db + " db, " + szerviz_ft + " Ft";
            }));

            string[] kpki = db.getNapiKPKI(Program.bolt);
            string kpki_db = kpki[0];
            string kpki_ft = kpki[1];
            this._kpkiDB = kpki_db;
            this._kpkiFt = kpki_ft;
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
            this._nyit = nap[3];
            this._zar = nap[14];
            lbl_nyito_kassza.BeginInvoke(new MethodInvoker(delegate () { 
                lbl_nyito_kassza.Text = nap[3];
            }));
            lbl_kassza_ft.BeginInvoke(new MethodInvoker(delegate ()
            {
                lbl_kassza_ft.Text = nap[14];
            }));
            return true;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            cms_export.Show(Cursor.Position);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cms_save.Show(Cursor.Position);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            cms_open.Show(Cursor.Position);
        }

        private string getZaro()
        {
            string zaro = "Napi záró: " + Program.bolt + "\r\n";
            zaro += "Dátum: " + DateTime.Now.ToString() + "\r\n";
            zaro += "Nyitó kassza: " + this._nyit + "\r\n";
            zaro += "Záró kassza: " + this._zar + "\r\n";
            zaro += "Tétel eladás: " + this._tdb + " db, " + this._tft + " Ft\r\n";
            zaro += "Telefon vétel: " + this._telVDB + " db, " + this._telVFt + " Ft\r\n";
            zaro += "Telefon eladás: " + this._telEDB + " db, " + this._telEFt + " ft\r\n";
            zaro += "Szervíz: " + this._szervizDb + " db, " + this._szervizFt + " Ft\r\n";
            zaro += "KPKI: " + this._kpkiDB + " db, " + this._kpkiFt + " Ft\r\n";
            zaro += "\r\n";
            zaro += "Tétel eladások:\r\n";
            List<string> allTetel = db.getEladToList("tetel_eladas", "*", "WHERE bolt='" + Program.bolt + "' AND nap = CURRENT_DATE");
            foreach (string tetel in allTetel)
            {
                zaro += tetel + "\r\n";
            }
            zaro += "\r\n";
            zaro += "Telefon vétel:\r\n";
            List<string> telvet = db.getTelVetelToList("telefonok", "*", "WHERE bolt='" + Program.bolt + "' AND nap = CURRENT_DATE");
            foreach (string tetel in telvet)
            {
                zaro += tetel + "\r\n";
            }
            zaro += "\r\n";
            zaro += "Telefon eladás:\r\n";
            List<string> telelad = db.getTelEladToList("telefonok", "*", "WHERE bolt='" + Program.bolt + "' AND eladas_datum = CURRENT_DATE");
            foreach (string tetel in telelad)
            {
                zaro += tetel + "\r\n";
            }
            zaro += "\r\n";
            zaro += "Szervíz:\r\n";
            List<string> szerviz = db.getSzervizToList("szerviz", "*", "WHERE bolt='" + Program.bolt + "' AND vissza_nap = CURRENT_DATE");
            foreach (string tetel in szerviz)
            {
                zaro += tetel + "\r\n";
            }
            zaro += "\r\n";
            zaro += "KP KI:\r\n";
            List<string> kpki = db.getKPKIToList("kpki", "*", "WHERE bolt='" + Program.bolt + "' AND nap = CURRENT_DATE");
            foreach (string tetel in kpki)
            {
                zaro += tetel + "\r\n";
            }
            zaro += "\r\n";
            return zaro;
        }
        
        //Műveletek helyi gépre
        private void helyiGépreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zaro = this.getZaro();

            SaveFileDialog sfd_Save = new SaveFileDialog();
            sfd_Save.Filter = "BarTel Save File|*.btsave";
            sfd_Save.Title = "Napi jelentés mentése";
            sfd_Save.ShowDialog();
            if (sfd_Save.FileName != "")
            {
                File.WriteAllText(sfd_Save.FileName, zaro);
                MessageBox.Show("Mentve!");
            }

        }
        private void helyiGéprőlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_Open = new OpenFileDialog();
            ofd_Open.Filter = "BarTel Save File|*.btsave";
            ofd_Open.Title = "Napi jelentés megnyitása";
            ofd_Open.ShowDialog();
            if(ofd_Open.FileName != "")
            {
                this.sorok = File.ReadAllLines(ofd_Open.FileName);
                init(true);
            }
        }


    }
}
