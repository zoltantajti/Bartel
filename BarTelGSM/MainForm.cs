using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class MainForm : Form
    {
        public int rank = 0;
        public string[] bolt;

        public MainForm()
        {
            InitializeComponent();
            MySQL db = new MySQL();
            lbl_user.Text = "Szia " + Program.name;
            lbl_bolt.Text = Program.bolt;
            string ma = DateTime.Now.ToString();
            lbl_ido.Text = ma;
            t_pontosIdo.Start();
            this.rank = int.Parse(Program.user[3]);
            this.bolt = db.get("boltok", "*", "WHERE nev='" + Program.bolt + "'");
            if(this.bolt[2] == "0")
            {
                eladásToolStripMenuItem.Enabled = false;
                vételToolStripMenuItem.Enabled = false;
                kPKIToolStripMenuItem.Enabled = false;
                termékekToolStripMenuItem.Enabled = false;
                összessítőkToolStripMenuItem.Enabled = false;
                btn_close.Enabled = false;
                btn_open.Enabled = true;
            }
            else
            {
                eladásToolStripMenuItem.Enabled = true;
                vételToolStripMenuItem.Enabled = true;
                kPKIToolStripMenuItem.Enabled = true;
                termékekToolStripMenuItem.Enabled = true;
                összessítőkToolStripMenuItem.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = false;
            }
        }

        private void t_pontosIdo_Tick(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString();
            lbl_ido.Text = now;
        }
    }
}
