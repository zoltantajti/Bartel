using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Rendelesek_uj : Form
    {
        MySQL db;
        public Rendelesek_uj()
        {
            InitializeComponent();
            this.Text = "Új rendelés | Bar-Tel GSM | " + Program.bolt;
            lbl_status.Visible = false;
            db = new MySQL();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string termek = tb_termek.Text;
            string leiras = tb_leiras.Text;
            string nev = tb_nev.Text;
            string telszam = tb_telszam.Text;

            string values = "bolt='" + Program.bolt + "',termek='" + termek + "'," +
                "leiras='" + leiras + "',nev='" + nev + "',telszam='" + telszam + "'," +
                "datum=CURRENT_DATE,status='Rögzítve'";
            db.insert("rendelesek", values);

            lbl_status.Visible = true;
            timer_status.Start();
        }

        private void timer_status_Tick(object sender, EventArgs e)
        {
            lbl_status.Visible = false;
            timer_status.Stop();
            tb_termek.Text = "";
            tb_leiras.Text = "";
            tb_nev.Text = "";
            tb_telszam.Text = "";
        }
    }
}
