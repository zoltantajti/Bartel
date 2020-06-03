using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    //Futtassa az updatert
                };
            }

            return false;
        }
    }
}
