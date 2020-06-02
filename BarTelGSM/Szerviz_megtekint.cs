using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Szerviz_megtekint : Form
    {
        MySQL db;
        Napi n;
        MainForm mf;
        Szerviz_Lista szl;
        int id;
        string[] szAdat;
        int ar;
        public Szerviz_megtekint(Napi _n, MainForm _mf, Szerviz_Lista _szl, int _id)
        {
            InitializeComponent();
            n = _n;
            mf = _mf;
            szl = _szl;
            id = _id;
            db = new MySQL();
            szAdat = db.get("szerviz", "*", "WHERE id='" + id + "'");
            this.Text = "Szervíz: " + szAdat[3] + " | Bar-Tel GSM | " + Program.bolt;
            gb_szervizdij.Visible = false;
            init();
        }

        private void init()
        {
            lbl_tipus.Text = szAdat[3];
            lbl_pin.Text = szAdat[5];
            lbl_jelkod.Text = szAdat[6];
            lbl_hiba.Text = szAdat[4];
            lbl_tulaj.Text = szAdat[7] + " (" + szAdat[8] + ")";
            tb_megjegyz.Text = szAdat[10];
            cb_status.Items.Add(status.Új);
            cb_status.Items.Add(status.Szervizben);
            cb_status.Items.Add(status.Javitva);
            cb_status.Items.Add(status.Fizetve);
            cb_status.Items.Add(status.Nem);
            cb_status.Text = szAdat[9];
            if(szAdat[9] == status.Fizetve.ToString())
            {
                fizetett();
            };
        }
        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_status.Text == status.Fizetve.ToString())
            {
                gb_szervizdij.Visible = true;
            }
            else
            {
                gb_szervizdij.Visible = false;
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            string szStatus = cb_status.Text;
            string megj = tb_megjegyz.Text;
            if(szStatus == status.Fizetve.ToString())
            {
                ar = int.Parse(tb_szAr.Text);
                if(tb_szAr.Text.Length > 0)
                {
                    string values = "status='" + szStatus + "',megjegyzes='" + megj + "', vissza_nap=CURRENT_DATE, ar='"+ar.ToString()+"'";
                    string cond = "WHERE id='" + id + "'";
                    db.update("szerviz", values, cond);
                    fizet();
                    n.napiFrissit();
                    mf.statFrissit();
                }
                else
                {
                    MessageBox.Show("Add meg a szervízdíjat!");
                }
            }
            else
            {
                string values = "status='" + szStatus + "',megjegyzes='" + megj + "'";
                string cond = "WHERE id='" + id + "'";
                db.update("szerviz", values, cond);
            }
            szl.init();
        }
        private void fizet()
        {
            n.szerviz_db = n.szerviz_db + 1;
            n.szerviz_ft = n.szerviz_ft + ar;
            n.kassza = n.kassza + ar;
            n.napiFrissit();
            fizetett();
        }
        private void fizetett()
        {
            cb_status.Enabled = false;
            tb_szAr.Enabled = false;
            tb_megjegyz.Enabled = false;
            btn_modify.Enabled = false;
        }
    }

    public enum status
    {
        Új,
        Szervizben,
        Javitva,
        Fizetve,
        Nem
    }
}
