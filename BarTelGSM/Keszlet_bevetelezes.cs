using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Keszlet_bevetelezes : Form
    {
        MySQL db;
        public Keszlet_bevetelezes(
            bool fromList = false,string name="",string ean="", string ar="",
            string dbszam="")
        {
            InitializeComponent();
            this.Text = "Készlet bevételezése | Bar-Tel GSM | " + Program.bolt;
            db = new MySQL();
            btn_modify.Enabled = false;
            btn_clear.Enabled = false;
            if(fromList == true)
            {
                initFromList(name,ean,ar,dbszam);
            }
        }
        private void initFromList(string name, string ean, string ar, string dbszam)
        {
            tb_nev.Text = name;
            tb_ean.Text = ean;
            tb_ar.Text = ar;
            tb_db.Text = dbszam;
            btn_modify.Enabled = true;
            btn_new.Enabled = false;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            string bolt = Program.bolt;
            string nev = tb_nev.Text;
            string vonalkod = tb_ean.Text;
            string ar = tb_ar.Text;
            string dbszam = tb_db.Text;
            if (db.count("termekek", "id", "WHERE bolt='" + bolt + "' AND nev='" + nev + "'") > 0)
            {
                MessageBox.Show("Van ilyen nevű termék!");
            }
            else if (db.count("termekek", "id", "WHERE bolt='" + bolt + "' AND vonalkod='" + vonalkod + "'") > 0)
            {
                MessageBox.Show("Van ilyen vonalkóddal termék!");
            }
            else
            {
                string values = "bolt='" + bolt + "',nev='" + nev + "'," +
                    "vonalkod='" + vonalkod + "',ar='" + ar + "',dbszam='" + dbszam + "'";
                db.insert("termekek", values);
                clear();
                MessageBox.Show("A termék mentve!");
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            string nev = tb_nev.Text;
            string vonalkod = tb_ean.Text;
            string ar = tb_ar.Text;
            string dbszam = tb_db.Text;
            string values = "dbszam='" + dbszam + "'";
            string cond = "WHERE bolt='" + Program.bolt + "' AND nev='" + nev + "' AND vonalkod='" + vonalkod + "'";
            db.update("termekek", values, cond);
            clear();
            MessageBox.Show("A termék módosítva!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(tb_keres_nev.Text.Length == 0 && tb_keres_ean.Text.Length == 0)
            {
                MessageBox.Show("Hiányzó mezők!");
            }
            else
            {
                string nev = tb_keres_nev.Text;
                string ean = tb_keres_ean.Text;
                string cond = "WHERE bolt='"+Program.bolt+"'";
                if(nev.Length > 0)
                {
                    cond += " AND nev='" + nev + "'";
                };
                if(ean.Length > 0)
                {
                    cond += " AND vonalkod='" + ean + "'";
                };
                string[] res = db.get("termekek", "*", cond);
                tb_nev.Text = res[2];
                tb_ean.Text = res[3];
                tb_ar.Text = res[4];
                tb_db.Text = res[5];
                btn_modify.Enabled = true;
                btn_new.Enabled = false;
                btn_clear.Enabled = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            tb_nev.Text = "";
            tb_ean.Text = "";
            tb_ar.Text = "";
            tb_db.Text = "";
            tb_keres_nev.Text = "";
            tb_keres_ean.Text = "";
            btn_modify.Enabled = false;
            btn_new.Enabled = true;
            btn_clear.Enabled = false;
        }
    }
}
