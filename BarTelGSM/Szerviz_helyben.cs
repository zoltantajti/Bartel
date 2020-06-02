using System;
using System.Data;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Szerviz_helyben : Form
    {
        MySQL db;
        Napi n;
        MainForm mf;
        public Szerviz_helyben(Napi _n, MainForm _mf)
        {
            InitializeComponent();
            this.Text = "Szervíz helyben | Bar-Tel GSM | " + Program.bolt;
            db = new MySQL();
            n = _n;
            mf = _mf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ar = tb_ar.Text;
            string bolt = Program.bolt;
            string tipus = "Helyi szervíz";
            string hiba = "";
            string tulaj = "Bolti vevő";
            string status = "Fizetve";

            string values = "bolt='" + bolt + "',nap=CURRENT_DATE,tipus='" + tipus + "'," +
                "hiba='" + hiba + "',tulaj='" + tulaj + "',status='" + status + "',ar='" + ar + "'";
            db.insert("szerviz", values);

            tb_ar.Text = "";

            n.szerviz_db = n.szerviz_db + 1;
            n.szerviz_ft = n.szerviz_ft + int.Parse(ar);
            n.kassza = n.kassza + int.Parse(ar);
            n.napiFrissit();

            mf.statFrissit();

            MessageBox.Show("Mentve!");
        }
    }
}
