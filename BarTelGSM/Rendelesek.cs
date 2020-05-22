using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public enum o_status
    {
        Rögzítve,
        Leadva,
        Érkezett,
        Nincs,
        Kiadva
    }
    public partial class Rendelesek : Form
    {
        MySQL db;
        public Rendelesek()
        {
            InitializeComponent();
            this.Text = "Rendelések | Bar-Tel GSM | " + Program.bolt;
            btn_showAll.Visible = false;
            db = new MySQL();
            init();
        }

        public void init(string feltet = "")
        {
            string cond = "WHERE bolt='" + Program.bolt + "' AND status != 'Kiadva' " + feltet;
            dgv_orders.DataSource = db.getDT("rendelesek", "id,termek,nev,telszam,status,lastmod", cond);
            dgv_orders.Columns[0].HeaderText = "Azon";
            dgv_orders.Columns[1].HeaderText = "Termék";
            dgv_orders.Columns[2].HeaderText = "Név";
            dgv_orders.Columns[3].HeaderText = "Telefonszám";
            dgv_orders.Columns[4].HeaderText = "Státusz";
            dgv_orders.Columns[5].HeaderText = "Módosítva";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string feltetel = "";
            string nev = tb_nev.Text;
            string telsz = tb_telszam.Text;
            if(nev.Length > 0)
            {
                feltetel += "AND nev LIKE '%" + nev + "%' ";
            };
            if(telsz.Length > 0)
            {
                feltetel += "AND telszam LIKE '%" + telsz + "%'";
            };
            btn_showAll.Visible = true;
            init(feltetel);
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            tb_nev.Text = "";
            tb_telszam.Text = "";
            btn_showAll.Visible = false;
            init();
        }

        private void dgv_orders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string id = dgv_orders.Rows[index].Cells[0].Value.ToString();
            Rendeles_adat ra = new Rendeles_adat(id,this);
            ra.Show();
        }
    }
}
