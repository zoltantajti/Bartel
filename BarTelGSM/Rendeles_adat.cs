using System;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class Rendeles_adat : Form
    {
        MySQL db;
        string id;
        Rendelesek r;
        public Rendeles_adat(string _id, Rendelesek _r)
        {
            InitializeComponent();
            db = new MySQL();
            r = _r;
            id = _id;
            string[] o = db.get("rendelesek", "*", "WHERE id='" + id + "' AND bolt='"+Program.bolt+"'");
            lbl_rendelo.Text = o[4] + " (" + o[5] + ")";
            lbl_termek.Text = o[2];
            lbl_leiras.Text = o[3];

            cb_status.Items.Add(o_status.Rögzítve);
            cb_status.Items.Add(o_status.Leadva);
            cb_status.Items.Add(o_status.Érkezett);
            cb_status.Items.Add(o_status.Nincs);
            cb_status.Items.Add(o_status.Kiadva);
            cb_status.Text = o[7];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string values = "status='" + cb_status.Text + "',lastMod=CURRENT_DATE";
            string cond = "WHERE id='" + id + "'";
            db.update("rendelesek", values, cond);
            r.init();
        }
    }
}
