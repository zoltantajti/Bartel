using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Tetel_Elad : Form
    {
        Napi n;
        MainForm mf;
        MySQL db;
        public Tetel_Elad(Napi _n, MainForm _mf)
        {
            InitializeComponent();
            this.Text = this.Text + " | " + Program.bolt;
            n = _n;
            mf = _mf;
            db = new MySQL();
            lbl_status.Visible = false;
            frissit();
        }

        private void btn_elad_Click(object sender, EventArgs e)
        {
            if (tb_tetelnev.Text.Length > 0 && tb_tetelar.Text.Length > 0)
            {
                string tetelNev = tb_tetelnev.Text;
                int tetelAr = int.Parse(tb_tetelar.Text);

                n.tetelszam = n.tetelszam + 1;
                n.tartozek_ar = n.tartozek_ar + tetelAr;

                string values = "bolt='" + Program.bolt + "',tetel='" + tetelNev + "',ar='" + tetelAr.ToString() + "',nap=CURRENT_DATE";
                db.insert("tetel_eladas", values);

                n.napiFrissit();

                tb_tetelnev.Text = "";
                tb_tetelar.Text = "";

                lbl_status.Visible = true;
                timer_kiir.Start();

                mf.statFrissit();
                frissit();
            }
            else MessageBox.Show("Hiányzó mezők!");
        }

        private void timer_kiir_Tick(object sender, EventArgs e)
        {
            lbl_status.Visible = false;
            timer_kiir.Stop();
        }

        private void frissit()
        {
            dgv_napiElad.DataSource = db.getDT("tetel_eladas", "tetel,ar", "WHERE bolt='" + Program.bolt + "' AND nap = CURRENT_DATE");
            dgv_napiElad.Columns[0].HeaderText = "Tétel neve";
            dgv_napiElad.Columns[1].HeaderText = "Tétel ára";
            n.napiFrissit();
        }
    }
}
