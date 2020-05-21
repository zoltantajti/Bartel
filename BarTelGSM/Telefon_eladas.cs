using System.Collections.Generic;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Telefon_eladas : Form
    {
        Napi n;
        MainForm mf;
        MySQL db;
        public Telefon_eladas(Napi _n, MainForm _mf)
        {
            InitializeComponent();
            this.Text = "Telefon eladás | Bar-Tel GSM | " + Program.bolt;
            n = _n;
            mf = _mf;
            db = new MySQL();
            init();
        }
        private void init()
        {
            cb_telefon.Items.Clear();
            cb_telefon.Text = "";
            tb_eladasi_ar.Text = "";
            List<string> telok = db.getList("telefonok", "*", "WHERE bolt='" + Program.bolt + "' AND eladva='0'");
            foreach (string telo in telok)
            {
                cb_telefon.Items.Add(telo);
            }
            lbl_status.Visible = false;
        }
        private void cb_telefon_SelectedValueChanged(object sender, System.EventArgs e)
        {
            string[] tAdat = cb_telefon.Text.Split('-');
            tb_eladasi_ar.Text = tAdat[1].Trim();
        }
        private void btn_save_Click(object sender, System.EventArgs e)
        {
            if (cb_telefon.Text.Length > 0 && tb_eladasi_ar.Text.Length > 0)
            {
                string _t = cb_telefon.Text;
                string[] tel = _t.Split('-');
                int ar = int.Parse(tb_eladasi_ar.Text);
                string tipus = tel[0].Trim();
                string t_e_a = tel[1].Trim();

                n.telefon_elad_db = n.telefon_elad_db + 1;
                n.telefon_elad_ft = n.telefon_elad_ft + ar;

                string values = "teny_eladasi_ar='" + ar + "',eladva='1'," +
                    "eladas_datum=CURRENT_DATE";
                string where = "WHERE bolt='"+Program.bolt+"' AND " +
                    "tipus = '"+tipus+"' AND terv_eladasi_ar='"+t_e_a+"'";
                db.update("telefonok", values, where);

                n.napiFrissit();

                init();
                lbl_status.Visible = true;
                timer_status.Start();

                mf.statFrissit();
                frissit();
            }
            else MessageBox.Show("Hiányzó paraméter!");
        }

        private void status_timer_Tick(object sender, System.EventArgs e)
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
