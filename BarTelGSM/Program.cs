using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarTelGSM
{
    static class Program
    {
        public static string name { get; set; }
        public static string bolt { get; set; }
        public static string[] user { get; set; }
        public static bool login { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RunLogin();
        }
        public static void Logout()
        {
            RunLogin();
        }
        static void RunLogin()
        {
            LoginForm lf = new LoginForm();
            DialogResult login = lf.ShowDialog();
            if (login == DialogResult.OK)
            {
                RunApp();
            }
            else
            {
                CloseSystem();
            }
        }
        static void RunApp()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            MainForm mf = new MainForm();
            DialogResult prog = mf.ShowDialog();
            if(prog == DialogResult.Abort)
            {
                CloseSystem();
            }
            else if(prog == DialogResult.Retry)
            {
                Logout();
            }
        }
        static void CloseSystem()
        {
            Application.ExitThread();
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
