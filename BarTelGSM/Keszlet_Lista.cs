using System;
using System.Windows.Forms;
using libsql;


namespace BarTelGSM
{
    public partial class Keszlet_Lista : Form
    {
        Napi n;
        MainForm mf;
        MySQL db;
        public Keszlet_Lista(Napi _n, MainForm _mf)
        {
            InitializeComponent();
            n = _n;
            mf = _mf;
            this.Text = "Készlet lista | Bar-Tel GSM | " + Program.bolt;
            db = new MySQL();
            init();
            btn_clear.Enabled = false;
        }

        private void init(string cond = "")
        {
            dgv_termekek.DataSource = db.getDT("termekek", "id,vonalkod,nev,ar,dbszam,bolt", cond);
            dgv_termekek.Columns[0].HeaderText = "ID";
            dgv_termekek.Columns[1].HeaderText = "Vonalkód";
            dgv_termekek.Columns[2].HeaderText = "Név";
            dgv_termekek.Columns[3].HeaderText = "Ár";
            dgv_termekek.Columns[4].HeaderText = "Darabszám";
            dgv_termekek.Columns[5].HeaderText = "Hol van?";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (
                tb_nev.Text.Length == 0 &&
                tb_vonalkod.Text.Length == 0
            )
            {
                init();
            }
            else
            {
                string cond = "WHERE ";
                if (tb_nev.Text.Length > 0)
                {
                    cond += "nev LIKE '%" + tb_nev.Text + "%'";
                };
                if (tb_vonalkod.Text.Length > 0)
                {
                    if (cond != "WHERE ") { cond += " AND "; };
                    cond += "vonalkod LIKE '%" + tb_vonalkod.Text + "%'";
                };
                if (cb_hol.Text == "Kisbolt")
                {
                    if (cond != "WHERE ") { cond += " AND "; };
                    cond += "bolt='Kisbolt'";
                }
                else if (cb_hol.Text == "Nagybolt")
                {
                    if (cond != "WHERE ") { cond += " AND "; };
                    cond += "bolt='Nagybolt'";
                }
                else if (cb_hol.Text == "Mind")
                { };
                btn_clear.Enabled = true;
                init(cond);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            btn_clear.Enabled = false;
            tb_nev.Text = "";
            tb_vonalkod.Text = "";
            cb_hol.Text = "Mind";
            init();
        }

        int rowID;
        private void dgv_termekek_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                rowID = e.RowIndex;
                dgv_termekek.Rows[e.RowIndex].Selected = true;
                rowMenuStrip.Show(Cursor.Position);
            }
        }

        private void eladásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int darab = int.Parse(dgv_termekek.Rows[rowID].Cells[4].Value.ToString());
            if (darab > 0)
            {
                string name = dgv_termekek.Rows[rowID].Cells[2].Value.ToString();
                string ean = dgv_termekek.Rows[rowID].Cells[1].Value.ToString();
                string ar = dgv_termekek.Rows[rowID].Cells[3].Value.ToString();

                Tetel_Elad te = new Tetel_Elad(n, mf, true, name, ean, ar);
                te.Show();
            }
            else { MessageBox.Show("A készlet 0!"); };
        }

        private void selejtezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgv_termekek.Rows[rowID].Cells[0].Value.ToString());
            string name = dgv_termekek.Rows[rowID].Cells[2].Value.ToString();
            string ean = dgv_termekek.Rows[rowID].Cells[1].Value.ToString();
            string dbszam = dgv_termekek.Rows[rowID].Cells[4].Value.ToString();
            Keszlet_Selejt ks = new Keszlet_Selejt(true,id,name,ean,dbszam);
            ks.Show();
        }

        private void bevételezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = dgv_termekek.Rows[rowID].Cells[2].Value.ToString();
            string ean = dgv_termekek.Rows[rowID].Cells[1].Value.ToString();
            string ar = dgv_termekek.Rows[rowID].Cells[3].Value.ToString();
            string dbszam = dgv_termekek.Rows[rowID].Cells[4].Value.ToString();

            Keszlet_bevetelezes kb = new Keszlet_bevetelezes(true,name,ean,ar,dbszam);
            kb.Show();
        }

        private void boltokKöztiÁtadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = dgv_termekek.Rows[rowID].Cells[2].Value.ToString();
            string ean = dgv_termekek.Rows[rowID].Cells[1].Value.ToString();

            Keszlet_Transzfer kt = new Keszlet_Transzfer(name, ean);
            kt.Show();
        }

        private void árváltozásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = dgv_termekek.Rows[rowID].Cells[2].Value.ToString();
            string ean = dgv_termekek.Rows[rowID].Cells[1].Value.ToString();
            string ar = dgv_termekek.Rows[rowID].Cells[3].Value.ToString();
            Termek_arvaltozas ta = new Termek_arvaltozas(name,ean,ar);
            ta.Show();
        }
    }
};
