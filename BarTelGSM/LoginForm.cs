using System;
using System.Collections.Generic;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class LoginForm : Form
    {
        MySQL db;
        Updates upd;

        public LoginForm()
        {
            InitializeComponent();

            upd = new Updates();
            bool hasUpdate = upd.checkUpdates();

            db = new MySQL();
            cb_bolt.Items.Add(Boltok.Nagybolt);
            cb_bolt.Items.Add(Boltok.Kisbolt);
            cb_bolt.SelectedItem = Boltok.Kisbolt;
            tb_username.Text = Program.name;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = tb_username.Text;
            string pass = tb_passwd.Text;
            string bolt = cb_bolt.Text;

            int sor = db.count("eladok", "id", "WHERE name='" + user + "' AND jelszo='" + pass + "'");
            if(sor > 0)
            {
                Program.bolt = bolt;
                Program.name = user;
                Program.login = true;
                Program.user = db.get("eladok", "*", "WHERE name='" + user + "' AND jelszo='" + pass + "'");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Hibás név, vagy jelszó!");
                tb_passwd.Text = "";
            }
        }
    }
}
