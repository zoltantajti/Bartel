using System;
using System.Drawing;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public partial class TulajForm : Form
    {
        MySQL db;
        int syncTime = 30;
        public TulajForm()
        {
            InitializeComponent();
            this.Text = "Jelentések | Bar-Tel GSM";
            db = new MySQL();
            string most =  DateTime.Now.ToString();
            string[] d = most.Split(' ');
            lbl_today.Text = d[0];
            init();
        }

        public void init()
        {
            string[] b_kb = db.get("boltok", "*", "WHERE nev='Kisbolt'");
            string[] b_nb = db.get("boltok", "*", "WHERE nev='Nagybolt'");
            string[] kb = db.get("napi_jelentes", "*", "WHERE bolt='Kisbolt'");
            string[] nb = db.get("napi_jelentes", "*", "WHERE bolt='Nagybolt'");
            if(checkOpen(b_kb[2]) == true)
            {
                lbl_kb_nyitzar.Text = "Nyitva";
                lbl_kb_nyitzar.ForeColor = Color.FromArgb(255, 0, 168, 39);
                initKicsi(kb);
            }
            else
            {
                lbl_kb_nyitzar.Text = "Zárva";
                lbl_kb_nyitzar.ForeColor = Color.FromArgb(255, 168, 0, 0);
            }
            if (checkOpen(b_nb[2]) == true)
            {
                lbl_nb_nyitzar.Text = "Nyitva";
                lbl_nb_nyitzar.ForeColor = Color.FromArgb(255, 0, 168, 39);
                initNagy(nb);
            }
            else
            {
                lbl_nb_nyitzar.Text = "Zárva";
                lbl_nb_nyitzar.ForeColor = Color.FromArgb(255, 168, 0, 0);
            }
            Timer_countdown.Start();
        }
        private void initKicsi(string[] b)
        {
            lbl_k_nyito.Text = b[3] + " Ft";
            lbl_k_tetelszam.Text = b[4] + " db";
            lbl_k_tetel_ft.Text = b[5] + " Ft";
            lbl_k_telVet_db.Text = b[8] + " db";
            lbl_k_telVet_ft.Text = b[9] + " Ft";
            lbl_k_tel_elad_db.Text = b[6] + " db";
            lbl_k_tel_elad_ft.Text = b[7] + " Ft";
            lbl_k_szerviz_db.Text = b[10] + " db";
            lbl_k_szerviz_ft.Text = b[11] + " Ft";
            lbl_k_kpki_db.Text = b[12] + " db";
            lbl_k_kpki_ft.Text = b[13] + " Ft";
            lbl_k_zaro.Text = b[14] + " Ft";
        }
        private void initNagy(string[] b)
        {
            lbl_n_nyito.Text = b[3] + " Ft";
            lbl_n_tetel_db.Text = b[4] + " db";
            lbl_n_tetel_ft.Text = b[5] + " Ft";
            lbl_n_tel_vetel_db.Text = b[8] + " db";
            lbl_n_tel_vetel_ft.Text = b[9] + " Ft";
            lbl_n_tel_elad_db.Text = b[6] + " db";
            lbl_n_tel_elad_ft.Text = b[7] + " Ft";
            lbl_n_szerviz_db.Text = b[10] + " db";
            lbl_n_szerviz_ft.Text = b[11] + " Ft";
            lbl_n_kpki_db.Text = b[12] + " db";
            lbl_n_kpki_ft.Text = b[13] + " Ft";
            lbl_n_zaro.Text = b[14] + " Ft";
        }
        private bool checkOpen(string open)
        {
            if(open == "1") { return true; } else { return false; }
        }

       

        private void Timer_countdown_Tick(object sender, EventArgs e)
        {
            if (syncTime == 0)
            {
                lbl_countDown.Text = "Frissítés...";
                init();
                Timer_countdown.Stop();
                syncTime = 30;
                Timer_countdown.Start();
            }
            else
            {
                syncTime--;
                lbl_countDown.Text = "Frissítésig: " + syncTime.ToString();
            }
        }
    }
}
