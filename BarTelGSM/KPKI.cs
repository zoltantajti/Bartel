using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class KPKI : Form
    {
        Napi n;
        MainForm mf;
        MySQL db;
        public KPKI(Napi _n, MainForm _mf)
        {
            InitializeComponent();
            this.Text = "KP KI | Bar-Tel GSM | " + Program.bolt;
            db = new MySQL();
            n = _n;
            mf = _mf;
            lbl_status.Visible = false;
            frissit();
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            if (tb_ki.Text.Length > 0 && tb_mennyi.Text.Length > 0)
            {
                string ki = tb_ki.Text;
                int mennyi = int.Parse(tb_mennyi.Text);

                n.kpki_db = n.kpki_db + 1;
                n.kpki = n.kpki + mennyi;

                string values = "bolt='" + Program.bolt + "',ki='" + ki + "',mennyi='" + mennyi.ToString() + "',nap=CURRENT_DATE";
                db.insert("kpki", values);

                tb_ki.Text = "";
                tb_mennyi.Text = "";

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
            dgv_kpki.DataSource = db.getDT("kpki", "ki,mennyi", "WHERE bolt='" + Program.bolt + "' AND nap = CURRENT_DATE");
            dgv_kpki.Columns[0].HeaderText = "Ki";
            dgv_kpki.Columns[1].HeaderText = "Összeg";
            n.napiFrissit();
        }
    }
}
