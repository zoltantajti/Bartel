using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Tetel_elad_uj : Form
    {
        Napi n;
        MainForm mf;
        MySQL db;
        List<DataGridViewRow> tetelek;
        int vegosszeg = 0;
        public Tetel_elad_uj(Napi _n, MainForm _mf, bool fromList = false,
            string name = "", string ean = "", string ar = "", int darab = 1)
        {
            InitializeComponent();
            this.Text = "Eladás | Bar-Tel GSM | " + Program.bolt;
            db = new MySQL();
            n = _n;
            mf = _mf;
        }

        private void btn_keres_Click(object sender, EventArgs e)
        {
            Keszlet_keres kk = new Keszlet_keres(this);
            kk.ShowDialog();
        }

        private void btn_toList_Click(object sender, EventArgs e)
        {
            string name = tb_tetelnev.Text;
            string ean = tb_vonalkod.Text;
            int ar = int.Parse(tb_tetelar.Text);
            int darab = int.Parse(tb_darab.Text);
            int sum = ar * darab;

            dgv_lista.Rows.Add(name,ean,ar + " Ft",darab,sum + " Ft");

            tb_tetelnev.Text = "";
            tb_tetelar.Text = "";
            tb_vonalkod.Text = "";
            tb_darab.Text = "";

            vegosszeg_frissit();
        }

        private void vegosszeg_frissit()
        {
            int vegossz = 0;
            foreach (DataGridViewRow row in dgv_lista.Rows)
            {                
                string[] _ar = row.Cells[4].Value.ToString().Split(' ');
                vegossz += int.Parse(_ar[0]);
                lbl_vegosszeg.Text = vegossz.ToString() + " Ft";
            }
        }

        List<string> insert = new List<string>();
        private void btn_sale_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgv_lista.Rows)
            {
                string[] ear = row.Cells[2].Value.ToString().Split(' ');
                string[] sar = row.Cells[4].Value.ToString().Split(' ');
                string tetelNev = row.Cells[0].Value.ToString();
                string ean = row.Cells[1].Value.ToString();
                int tetelar = int.Parse(ear[0]);
                int darab = int.Parse(row.Cells[3].Value.ToString());
                int sum = int.Parse(sar[0]);

                n.tetelszam = n.tetelszam + darab;
                n.tartozek_ar = n.tartozek_ar + sum;

                for (int i = 1; i <= darab; i++)
                {
                    string values = "bolt='" + Program.bolt + "',tetel='" + tetelNev + "',ar='" + tetelar.ToString() + "',nap=CURRENT_DATE";
                    insert.Add(values);
                }
                
                keszletFrissit(tetelNev, ean, darab);
            };

            eladBeszur();
            mf.statFrissit();
            n.napiFrissit();

            dgv_lista.Rows.Clear();
            dgv_lista.Refresh();
        }

        private void eladBeszur()
        {
            foreach(string values in insert)
            {
                db.insert("tetel_eladas", values);
            };          
        }
        private void keszletFrissit(string nev, string ean, int _db)
        {
            try
            {
                string[] res = db.get("termekek", "dbszam", "WHERE bolt='" + Program.bolt + "' AND nev='" + nev + "' AND vonalkod='" + ean + "'");
                int darab = int.Parse(res[0]) - _db;
                string values = "dbszam='" + darab + "'";
                string cond = "WHERE bolt='" + Program.bolt + "' AND nev='" + nev + "' AND vonalkod='" + ean + "'";
                db.update("termekek", values, cond);
            }
            catch (Exception e) { };
        }
        
    }
}
