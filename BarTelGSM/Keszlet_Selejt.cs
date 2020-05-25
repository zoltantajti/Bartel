using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Keszlet_Selejt : Form
    {
        MySQL db;
        public Keszlet_Selejt(bool row, int id=0, string nev="", string ean="", string dbszam="")
        {
            InitializeComponent();
            this.Text = "Selejtezés | Bar-Tel GSM | " + Program.bolt;
            if (row == false)
            {
                gb_result.Visible = false;
            }
            else
            {
                hasRows(id, nev, ean, dbszam);
                gb_result.Visible = true;
            }
            db = new MySQL();
        }
        string[] res = new string[6];
        private void hasRows(int id, string nev, string ean, string dbszam)
        {
            res[0] = id.ToString();
            res[1] = "";
            res[2] = nev;
            res[3] = ean;
            res[4] = "";
            res[5] = dbszam;

            lbl_name.Text = res[2];
            lbl_vonalkod.Text = res[3];
            lbl_darabszam.Text = res[5];
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string nev = tb_name.Text;
            res = db.get("termekek", "*", "WHERE bolt='" + Program.bolt + "' AND nev='" + nev + "'");
            lbl_name.Text = res[2];
            lbl_vonalkod.Text = res[3];
            lbl_darabszam.Text = res[5];
            gb_result.Visible = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string darab = tb_selejt.Text;
            int ujdb = int.Parse(res[5]) - int.Parse(darab);
            string values = "dbszam='" + ujdb + "'";
            string cond = "WHERE bolt='" + Program.bolt + "' AND id='" + res[0] + "'";
            db.update("termekek", values, cond);
            MessageBox.Show("Selejtezés megtörtént!");
            lbl_darabszam.Text = "";
            lbl_name.Text = "";
            lbl_vonalkod.Text = "";
            tb_name.Text = "";
            tb_selejt.Text = "";
            gb_result.Visible = false;
        }
    }
}
