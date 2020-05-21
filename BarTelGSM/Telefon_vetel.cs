using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Telefon_vetel : Form
    {
        Napi n;
        MainForm mf;
        MySQL db;
        public Telefon_vetel(Napi _n, MainForm _mf)
        {
            InitializeComponent();
            this.Text = "Telefon vétel | Bar-Tel GSM | " + Program.bolt;
            db = new MySQL();
            n = _n;
            mf = _mf;
            lbl_status.Visible = false;
            frissit();
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            if (tb_tipus.Text.Length > 0 && tb_besz_ar.Text.Length > 0 && tb_terv_elad_ar.Text.Length > 0)
            {
                string tipus = tb_tipus.Text;
                int besz_ar = int.Parse(tb_besz_ar.Text);
                int terv_elad_ar = int.Parse(tb_terv_elad_ar.Text);

                n.telefon_vetel_db = n.telefon_vetel_db + 1;
                n.telefon_vetel_ft = n.telefon_vetel_ft + besz_ar;

                string values = "bolt='" + Program.bolt + "',nap=CURRENT_DATE,tipus='" + tipus + "',beszerzesi_ar='" + besz_ar + "'," +
                    "terv_eladasi_ar='" + terv_elad_ar + "',eladva='0'";
                db.insert("telefonok", values);

                tb_tipus.Text = "";
                tb_besz_ar.Text = "";
                tb_terv_elad_ar.Text = "";

                mf.statFrissit();
                frissit();

                lbl_status.Visible = true;
                timer_status.Start();
            }
            else MessageBox.Show("Hiányzó mezők!");
        }

        private void timer_status_Tick(object sender, System.EventArgs e)
        {
            lbl_status.Visible = false;
            timer_status.Stop();
        }
        private void frissit()
        {
            n.napiFrissit();
        }
    }
}
