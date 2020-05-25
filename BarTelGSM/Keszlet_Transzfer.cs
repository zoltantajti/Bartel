using System;
using System.Data;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Keszlet_Transzfer : Form
    {
        MySQL db;
        public Keszlet_Transzfer(string name, string ean)
        {
            InitializeComponent();
            db = new MySQL();
            this.Text = "Boltok közti átadás | Bar-Tel GSM";
            cb_from.Items.Add("Kisbolt");
            cb_from.Items.Add("Nagybolt");
            cb_from.Text = Program.bolt;
            lbl_termeknev.Text = name;
            lbl_ean.Text = ean;
            cb_to.Items.Add("Kisbolt");
            cb_to.Items.Add("Nagybolt");
            cb_to.Text = "Válassz!";
            tb_darab.Text = "0";
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (cb_to.Text != "Válassz!" && tb_darab.Text != "0")
            {
                string name = lbl_termeknev.Text;
                string ean = lbl_ean.Text;
                string honnan = cb_from.Text;
                string hova = cb_to.Text;
                string darab = tb_darab.Text;

                //mentjük a saját készletünket
                string[] sajat = db.get("termekek", "dbszam", "WHERE bolt='" + honnan + "' AND nev='" + name + "' AND vonalkod='" + ean + "'");
                int dbszam = int.Parse(sajat[0]);
                int dbszam_uj = dbszam - int.Parse(darab);
                db.update("termekek", "dbszam='" + dbszam_uj + "'", "WHERE bolt='" + honnan + "' AND nev='" + name + "' AND vonalkod='" + ean + "'");

                //Jóváírjuk a készletet
                string[] cel = db.get("termekek","dbszam","WHERE bolt='"+hova+ "' AND nev='" + name + "' AND vonalkod='" + ean + "'");
                int c_dbszam = int.Parse(cel[0]);
                int c_dbszam_uj = c_dbszam + int.Parse(darab);
                db.update("termekek","dbszam='"+c_dbszam_uj+"'", "WHERE bolt='" + hova + "' AND nev='" + name + "' AND vonalkod='" + ean + "'");

                MessageBox.Show("Transzfer könyvelve!");
            }
            else
            {
                MessageBox.Show("Hibásan kitöltött mezők!");
            }
        }
    }
}
