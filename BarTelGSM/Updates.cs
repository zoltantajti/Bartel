using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libsql;

namespace BarTelGSM
{
    public class Updates
    {
        MySQL db;
        public bool checkUpdates()
        {
            db = new MySQL();
            string cVer = Program.version;
            string[] latest = db.get("soft_updates", "*", "ORDER BY reldt DESC LIMIT 0,1");
            string lVer = latest[1];

            double cv = double.Parse(cVer);
            double lv = double.Parse(lVer);
            if(lv > cv)
            {
                DialogResult update = MessageBox.Show(
                    "Elérhető új frissítés!\r\nKívánod letölteni?",
                    "Firssítés elérhető",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if(update == DialogResult.Yes)
                {
                    Process.Start(Directory.GetCurrentDirectory() + "\\Updater.exe");
                    Thread.Sleep(1000);
                    Application.Exit();
                    Application.ExitThread();
                    Environment.Exit(1);
                };
            }

            return false;
        }
    }
}
