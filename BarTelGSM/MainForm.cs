using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class MainForm : Form
    {
        public int rank = 0;
        public string[] bolt;
        Napi napi;
        MySQL db;
        public MainForm()
        {
            InitializeComponent();
            db = new MySQL();
            napi = new Napi();
            lbl_user.Text = "Szia " + Program.name;
            lbl_bolt.Text = Program.bolt;
            string ma = DateTime.Now.ToString();
            lbl_ido.Text = ma;
            t_pontosIdo.Start();
            this.rank = int.Parse(Program.user[3]);
            this.bolt = db.get("boltok", "*", "WHERE nev='" + Program.bolt + "'");
            if(this.bolt[2] == "0")
            {
                setClose();
            }
            else
            {
                setOpen();
                collectFromData();
            }
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if(napi.checkNapi() == true)
            {
                string[] nap = db.get("napi_jelentes", "*", "WHERE bolt='" + Program.bolt + "' AND datum = CURRENT_DATE");
                napi.nyito_kassza = int.Parse(nap[3]);
                napi.tetelszam = int.Parse(nap[4]);
                napi.tartozek_ar = int.Parse(nap[5]);
                napi.telefon_elad_db = int.Parse(nap[6]);
                napi.telefon_elad_ft = int.Parse(nap[7]);
                napi.telefon_vetel_db = int.Parse(nap[8]);
                napi.telefon_vetel_ft = int.Parse(nap[9]);
                napi.szerviz_db = int.Parse(nap[10]);
                napi.szerviz_ft = int.Parse(nap[11]);
                napi.kpki_db = int.Parse(nap[12]);
                napi.kpki = int.Parse(nap[13]);
                napi.kassza = int.Parse(nap[14]);
                statFrissit();
            }
        }
        private void collectFromData()
        {
            try
            {
                string[] _napi_tetel_elad = db.getNapiTetelEladas(Program.bolt);
                napi.tartozek_ar = int.Parse(_napi_tetel_elad[0]);
                napi.tetelszam = int.Parse(_napi_tetel_elad[1]);
                statFrissit();
            }catch(Exception e)
            {
                napi.tartozek_ar = 0;
                napi.tetelszam = 0;
                statFrissit();
            }
        }

        private void t_pontosIdo_Tick(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString();
            lbl_ido.Text = now;
        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.login = false;
            Program.bolt = null;
            Program.user = null;
            DialogResult = DialogResult.Retry;
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            if (tb_nyitokassza.Text.Length > 0)
            {
                int nyito = int.Parse(tb_nyitokassza.Text);
                napi.nyito_kassza = nyito;
                setOpen(true);
            }
            else MessageBox.Show("Adj meg nyitó kasszát!");
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            setClose();
        }
        private void setOpen(bool btn = false)
        {
            eladásToolStripMenuItem.Enabled = true;
            vételToolStripMenuItem.Enabled = true;
            kPKIToolStripMenuItem.Enabled = true;
            termékekToolStripMenuItem.Enabled = true;
            összessítőkToolStripMenuItem.Enabled = true;
            szervizToolStripMenuItem.Enabled = true;
            gb_napiAdatok.Visible = true;
            tb_nyitokassza.Enabled = false;
            btn_close.Enabled = true;
            btn_open.Enabled = false;
            lbl_nyito_kassza.Text = tb_nyitokassza.Text;
            if (btn == true)
            {
                napi.nyito_kassza = int.Parse(tb_nyitokassza.Text);
                napi.kassza = int.Parse(tb_nyitokassza.Text);
                db.update("boltok", "nyitva='1'", "WHERE nev='" + Program.bolt + "'");
                napi.napiFrissit();
            };
            statFrissit();
            
        }
        private void setClose()
        {
            eladásToolStripMenuItem.Enabled = false;
            vételToolStripMenuItem.Enabled = false;
            kPKIToolStripMenuItem.Enabled = false;
            termékekToolStripMenuItem.Enabled = false;
            összessítőkToolStripMenuItem.Enabled = false;
            szervizToolStripMenuItem.Enabled = false;
            gb_napiAdatok.Visible = false;
            tb_nyitokassza.Enabled = true;
            db.update("boltok", "nyitva='0'", "WHERE nev='" + Program.bolt + "'");
            btn_close.Enabled = false;
            btn_open.Enabled = true;
        }
        public void statFrissit()
        {
            szamol();
            lbl_napi_tetelszam.Text = napi.tetelszam.ToString();
            lbl_napi_tetel_ft.Text = napi.tartozek_ar.ToString();
            lbl_tel_elad_db.Text = napi.telefon_elad_db.ToString();
            lbl_tel_elad_ft.Text = napi.telefon_elad_ft.ToString();
            lbl_tel_vetel_db.Text = napi.telefon_vetel_db.ToString();
            lbl_tel_vetel_ft.Text = napi.telefon_vetel_ft.ToString();
            lbl_szerviz_db.Text = napi.szerviz_db.ToString();
            lbl_szerviz_ft.Text = napi.szerviz_ft.ToString();
            lbl_kpki_db.Text = napi.kpki_db.ToString();
            lbl_kpki_ft.Text = napi.kpki.ToString();
            lbl_nyito_kassza.Text = napi.nyito_kassza.ToString();
            lbl_kassza_ft.Text = napi.kassza.ToString();
            
        }
        private void szamol()
        {
            int bevet = (napi.tartozek_ar + napi.telefon_elad_ft + napi.szerviz_ft);
            int kiad = (napi.telefon_vetel_ft + napi.kpki);
            int kassza = (napi.nyito_kassza + bevet) - kiad;
            napi.kassza = kassza;
        }

        private void tételEladásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tetel_Elad te = new Tetel_Elad(napi,this);
            te.Show();
        }

        private void kPKIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KPKI kpki = new KPKI(napi, this);
            kpki.Show();
        }

        private void telefonVételToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefon_vetel tv = new Telefon_vetel(napi, this);
            tv.Show();
        }

        private void telefonEladásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefon_eladas te = new Telefon_eladas(napi, this);
            te.Show();
        }

        private void újSzervízToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uj_szerviz usz = new Uj_szerviz();
            usz.Show();
        }

        private void szervízListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Szerviz_Lista szl = new Szerviz_Lista(napi, this);
            szl.Show();
        }
    }
}
