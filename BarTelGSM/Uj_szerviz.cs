using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Uj_szerviz : Form
    {
        MySQL db;
        public Uj_szerviz()
        {
            InitializeComponent();
            this.Text = "Szervíz felvétele | Bar-Tel GSM | " + Program.bolt;
            db = new MySQL();
            lbl_status.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (this.validForm() == true)
            {
                string bolt = Program.bolt;
                string tipus = tb_tipus.Text;
                string hiba = tb_hiba.Text;
                string pinkod = tb_pin.Text;
                string jelkod = tb_jelkod.Text;
                string tulaj = tb_tulaj.Text;
                string telszam = tb_telszam.Text;

                string values = "bolt='" + bolt + "',nap=CURRENT_DATE,tipus='" + tipus + "'," +
                    "hiba='" + hiba + "',pinkod='" + pinkod + "',jelkod='" + jelkod + "'," +
                    "tulaj='" + tulaj + "',telszam='" + telszam + "',status='Új'," +
                    "lastMod=CURRENT_DATE";
                db.insert("szerviz", values);
                MessageBox.Show("A szervíz rögzítve!");
                tb_tipus.Text = "";
                tb_hiba.Text = "";
                tb_pin.Text = "";
                tb_jelkod.Text = "";
                tb_tulaj.Text = "";
                tb_telszam.Text = "";
            }
            else MessageBox.Show("Hiányzó mezők!");
        }
        private bool validForm()
        {
            if (
                tb_tipus.Text.Length > 0 &&
                tb_hiba.Text.Length > 0 &&
                tb_tulaj.Text.Length > 0 &&
                tb_telszam.Text.Length > 0
                )
            {
                return true;
            }
            else return false;
        }
    }
}
