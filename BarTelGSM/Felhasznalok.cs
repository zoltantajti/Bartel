using System;
using System.Collections.Generic;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Felhasznalok : Form
    {
        MySQL db;
        string func = "new";
        string id = "";
        public Felhasznalok()
        {
            InitializeComponent();
            this.Text = "Felhasználók kezelése | Bar-Tel GSM";
            db = new MySQL();
            List<string> ranks = db.getRanks("rangok", "*");
            foreach(string r in ranks)
            {
                cb_ranks.Items.Add(r);
            }
            cb_ranks.Text = "1 - Eladó";
            btn_delUser.Enabled = false;
            init();
        }
        public void init()
        {
            dgv_users.DataSource = db.getDT("eladok", "id,name,rang");
            dgv_users.Columns[0].HeaderText = "Azon";
            dgv_users.Columns[1].HeaderText = "Név";
            dgv_users.Columns[2].HeaderText = "Rang";
            func = "new";
            btn_delUser.Enabled = false;
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            if(func == "new")
            {
                string name = tb_user.Text;
                string pwd = tb_passwd.Text;
                string[] _r = cb_ranks.Text.Split('-');
                string rankID = _r[0].Trim();
                string rankName = _r[1].Trim();
                string values = "name='" + name + "',jelszo='" + pwd + "',rang='" + rankID + "'";
                db.insert("eladok", values);
                init();
                tb_user.Text = "";
                tb_passwd.Text = "";
                cb_ranks.Text = "1 - Eladó";
            }
            else
            {
                string name = tb_user.Text;
                string pwd = tb_passwd.Text;
                string[] _r = cb_ranks.Text.Split('-');
                string rankID = _r[0].Trim();
                string rankName = _r[1].Trim();
                string values = "";
                if(Program.name == name)
                {
                    values = "jelszo='" + pwd + "'";
                }
                else
                {
                    values = "name='" + name + "',jelszo='" + pwd + "',rang='" + rankID + "'";
                };
                string cond = "WHERE id='"+this.id+"'";
                db.update("eladok", values, cond);
                init();
                tb_user.Text = "";
                tb_passwd.Text = "";
                cb_ranks.Text = "1 - Eladó";
            }
        }
        private void btn_delUser_Click(object sender, EventArgs e)
        {
            string name = tb_user.Text;
            if (name != Program.name)
            {
                db.delete("eladok", "WHERE name='" + name + "'");
                init();
                tb_user.Text = "";
                tb_passwd.Text = "";
                cb_ranks.Text = "1 - Eladó";
            }
            else MessageBox.Show("Saját magad nem törölheted!");
        }
        private void dgv_users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string id = dgv_users.Rows[index].Cells[0].Value.ToString();
            string[] editable = db.get("eladok", "*", "WHERE id='" + id + "'");
            string[] rank = db.get("rangok", "*", "WHERE id='" + editable[3] + "'");
            tb_user.Text = editable[1];
            tb_passwd.Text = editable[2];
            cb_ranks.Text = rank[0] + " - " + rank[1];
            this.id = editable[0];
            func = "edit";
            btn_delUser.Enabled = true;
        }

        
    }
}
