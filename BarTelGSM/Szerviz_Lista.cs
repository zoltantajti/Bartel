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
        public Szerviz_Lista(Napi _n, MainForm _mf)
        {
            InitializeComponent();
            db = new MySQL();
            this.Text = "Szervíz lista | Bar-Tel GSM | " + Program.bolt;
            n = _n;
            mf = _mf;
            init();
        }
        private void init()
        {

        }
    }
}
