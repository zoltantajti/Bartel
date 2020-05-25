using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Keszlet_keres : Form
    {
        Tetel_Elad te;
        MySQL db;
        string[] result = new string[3];
        public Keszlet_keres(Tetel_Elad _te)
        {
            InitializeComponent();
            this.Text = "Termék keresése | Bar-Tel GSM | " + Program.bolt;
            te = _te;
            db = new MySQL();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string nev = tb_nev.Text;
            string ean = tb_ean.Text;
            string cond = "";
            if(nev.Length > 0)
            {
                if(cond.Length == 0) { cond += "WHERE "; }else { cond += "AND"; };
                cond += " nev LIKE '%" + nev + "%'";
            };
            if(ean.Length > 0)
            {
                if (cond.Length == 0) { cond += "WHERE "; } else { cond += "AND"; };
                cond += " vonalkod LIKE '%" + ean + "%'";
            };
            dgv_result.DataSource = db.getDT("termekek", "id,vonalkod,nev,ar,dbszam,bolt", cond);
            dgv_result.Columns[0].HeaderText = "ID";
            dgv_result.Columns[1].HeaderText = "Vonalkód";
            dgv_result.Columns[2].HeaderText = "Terméknév";
            dgv_result.Columns[3].HeaderText = "Eladási ár";
            dgv_result.Columns[4].HeaderText = "Darabszám";
            dgv_result.Columns[5].HeaderText = "Hol van?";
        }

        private void dgv_result_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(dgv_result.Rows[index].Cells[4].Value.ToString() == Program.bolt)
            {
                if(int.Parse(dgv_result.Rows[index].Cells[4].Value.ToString()) > 0)
                {
                    result[0] = dgv_result.Rows[index].Cells[2].Value.ToString();
                    result[1] = dgv_result.Rows[index].Cells[1].Value.ToString();
                    result[2] = dgv_result.Rows[index].Cells[3].Value.ToString();

                    te.tb_tetelnev.Text = result[0];
                    te.tb_vonalkod.Text = result[1];
                    te.tb_tetelar.Text = result[2];

                    result = new string[3];

                    this.Close();
                }
                else
                {
                    MessageBox.Show("A kiválasztott termék nincs készleten!");
                }
            }
            else
            {
                MessageBox.Show("Nem adhatod el, mert másik boltban van készleten!");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int rowID;
        private void dgv_result_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if(me.Button == MouseButtons.Right)
            {
                rowID = e.RowIndex;
                rowMenuStrip.Show(Cursor.Position);
            }
        }

        private void selejtezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_result.Rows[rowID].Cells[5].Value.ToString() == Program.bolt)
            {
                int id = int.Parse(dgv_result.Rows[rowID].Cells[0].Value.ToString());
                string nev = dgv_result.Rows[rowID].Cells[2].Value.ToString();
                string ean = dgv_result.Rows[rowID].Cells[1].Value.ToString();
                string dbszam = dgv_result.Rows[rowID].Cells[4].Value.ToString();

                Keszlet_Selejt ks = new Keszlet_Selejt(true, id, nev, ean, dbszam);
                ks.Show();
            }
            else
            {
                MessageBox.Show("Nem nálad van!");
            }
        }

        private void eladásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = rowID;
            if (dgv_result.Rows[index].Cells[5].Value.ToString() == Program.bolt)
            {
                if (int.Parse(dgv_result.Rows[index].Cells[4].Value.ToString()) > 0)
                {
                    result[0] = dgv_result.Rows[index].Cells[2].Value.ToString();
                    result[1] = dgv_result.Rows[index].Cells[1].Value.ToString();
                    result[2] = dgv_result.Rows[index].Cells[3].Value.ToString();

                    te.tb_tetelnev.Text = result[0];
                    te.tb_vonalkod.Text = result[1];
                    te.tb_tetelar.Text = result[2];

                    result = new string[3];

                    this.Close();
                }
                else
                {
                    MessageBox.Show("A kiválasztott termék nincs készleten!");
                }
            }
            else
            {
                MessageBox.Show("Nem adhatod el, mert másik boltban van készleten!");
            }
        }
    }
}
