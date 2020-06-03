using System;
using System.Collections.Generic;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Szerviz_Lista : Form
    {
        MySQL db;
        Napi n;
        MainForm mf;
        string feltetel = "";
        public Szerviz_Lista(Napi _n, MainForm _mf)
        {
            InitializeComponent();
            db = new MySQL();
            this.Text = "Szervíz lista | Bar-Tel GSM | " + Program.bolt;
            n = _n;
            mf = _mf;
            init();
        }
        public void init(string f = "")
        {
            string filter = "";
            if (cb_showAll.Checked == false)
            {
                filter = " AND status != 'Fizetve'";
            }
            else
            {
                filter = " AND (status != 'Fizetve' OR status = 'Fizetve')";
            }
            string cond = "WHERE bolt='" + Program.bolt + "' " + this.feltetel + filter + " ORDER BY nap DESC";
            dgv_szervizek.DataSource = db.getDT(
                "szerviz", 
                "id,nap,tipus,tulaj,telszam,status", 
                cond
            );
            dgv_szervizek.Columns[0].HeaderText = "Azon";
            dgv_szervizek.Columns[1].HeaderText = "Felvétel";
            dgv_szervizek.Columns[2].HeaderText = "Típus";
            dgv_szervizek.Columns[3].HeaderText = "Tulajdonos neve";
            dgv_szervizek.Columns[4].HeaderText = "Telefonszáma";
            dgv_szervizek.Columns[5].HeaderText = "Szervíz állapot";
        }

        private void dgv_szervizek_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string azon = dgv_szervizek.Rows[index].Cells[0].Value.ToString();
            Szerviz_megtekint szm = new Szerviz_megtekint(n,mf,this,int.Parse(azon));
            szm.Show();
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            tb_nev.Text = "";
            tb_telszam.Text = "";
            tb_tipus.Text = "";
            btn_showAll.Visible = false;
            this.feltetel = "";
            init();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(tb_nev.Text.Length > 0)
            {
                feltetel += " AND tulaj LIKE '%" + tb_nev.Text + "%'";
            };
            if(tb_telszam.Text.Length > 0)
            {
                feltetel += " AND telszam LIKE '%" + tb_telszam.Text + "%'";
            };
            if(tb_tipus.Text.Length > 0)
            {
                feltetel += " AND tipus LIKE '%" + tb_tipus.Text + "%'";
            };
            btn_showAll.Visible = true;
            init();
        }

        private void cb_showAll_CheckedChanged(object sender, EventArgs e)
        {
            init();
        }
    }
}
