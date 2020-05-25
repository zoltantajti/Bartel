using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Termek_arvaltozas : Form
    {
        MySQL db;
        string nev;
        string ean;
        public Termek_arvaltozas(string name, string ean, string regiAr)
        {
            InitializeComponent();
            db = new MySQL();
            this.Text = "Termék árváltozás: " + name + " | Bar-Tel GSM | " + Program.bolt;
            this.nev = name;
            this.ean = ean;
            lbl_name.Text = "Termék név: " + name;
            lbl_ean.Text = "Vonalkód: " + ean;
            lbl_regiAr.Text = "Régi ár: " + regiAr + " Ft";
            tb_ujAr.Text = regiAr;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(tb_ujAr.Text.Length > 0)
            {
                string ar = tb_ujAr.Text;
                string values = "ar='" + ar + "'";
                string cond = "WHERE bolt='" + Program.bolt + "' AND nev='" + this.nev + "' AND vonalkod='" + this.ean + "'";
                db.update("termekek", values, cond);
                MessageBox.Show("Ár módosítva!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hiányzó mező!");
            }
        }
    }
}
