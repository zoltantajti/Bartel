using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using libsql;
using Microsoft.Win32;

namespace Setup
{
    public partial class MainForm : Form
    {
        public string instPath = @"C:\BarTelGSM";
        private string instPWD = "Bartel2016";
        private string remote = "http://downloader.clanweb.hu/bartel/";
        private string version = "";
        MySQL db;
        public MainForm()
        {
            InitializeComponent();
            db = new MySQL();

            this.Text = "Bar-Tel GSM Eladói kliens telepítése";
            p_setup.Visible = true;
            p_setup.Dock = DockStyle.Fill;
            p_process.Visible = false;
            p_completed.Visible = false;
            fbd_installPath.SelectedPath = this.instPath;
            tb_installPath.Text = this.instPath;
            btn_install.Enabled = false;
        }

        #region step1
        private void tb_installPath_TextChanged(object sender, EventArgs e)
        {
            string path = tb_installPath.Text;
            fbd_installPath.SelectedPath = path;
            this.instPath = path;
        }

        private void tb_passwd_TextChanged(object sender, EventArgs e)
        {
            string pw = tb_passwd.Text;
            if(pw == this.instPWD)
            {
                btn_install.Enabled = true;
            }
            else
            {
                btn_install.Enabled = false;
            }
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            if(fbd_installPath.ShowDialog() == DialogResult.OK)
            {
                string path = fbd_installPath.SelectedPath;
                tb_installPath.Text = path;
                this.instPath = path;                
            };
        }
        private void btn_install_Click(object sender, EventArgs e)
        {
            p_setup.Visible = false;
            p_process.Visible = true;
            p_process.Dock = DockStyle.Fill;
            install();
        }
        #endregion
        #region step2
        private void install()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private async void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            this.setLogDelegate("A telepítő elindult");
            this.setLogDelegate("Telepítési mappa létrehozása");
            await MakeFolder();
            this.setLogDelegate("Telepítési mappa létrehozva");
            this.setLogDelegate("Program letöltése");
            await GetArchiveFile();
            this.setLogDelegate("Program telepítése");
            await unpack();
            this.setLogDelegate("Registry írása");
            await writeRegistry();
            this.setLogDelegate("Parancsikon írása");
            await setShortCut();
            this.setLogDelegate("Ideiglenes fileok eltávolítása");
            await removeTempFiles();

            step3();
        }

        public async Task<bool> MakeFolder()
        {
            if (!Directory.Exists(this.instPath))
            {
                Directory.CreateDirectory(this.instPath);
            };
            return true;
        }
        private string filename = "";
        public async Task<bool> GetArchiveFile()
        {
            string[] i = db.get("soft_installer", "*", "WHERE reld='1' ORDER BY reldt DESC LIMIT 0,1");
            string rFile = this.remote + i[2];
            string local = this.instPath + "\\" + i[2];
            this.filename = i[2];
            this.version = i[1];
            using (WebClient client = new WebClient())
            {
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                await client.DownloadFileTaskAsync(new Uri(rFile), local);
            };
            return true;
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pb_fileComplete.BeginInvoke(new MethodInvoker(delegate ()
            {
                pb_fileComplete.Value = e.ProgressPercentage;
            }));
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Letöltve
        }

        private async Task<bool> unpack()
        {
            try
            {
                string zipPath = this.instPath + "\\" + this.filename;
                string targetPath = this.instPath;
                ZipFile.ExtractToDirectory(zipPath, targetPath);
            }catch(Exception e)
            {
                MessageBox.Show("A telepítés sikertelen!\r\n" + e.Message,
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
            return true;
        }
        private async Task<bool> writeRegistry()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            key.CreateSubKey("BarTelGSM");
            key = key.OpenSubKey("BarTelGSM", true);
            key.SetValue("version", this.version);
            key.SetValue("path", this.instPath);
            return true;
        }
        private async Task<bool> setShortCut()
        {
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, "Bar-Tel GSM.lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            shortcut.Description = "Bar-Tel GSM program indítóikon";
            shortcut.IconLocation = this.instPath + "\\BarTelGSM.exe";
            shortcut.TargetPath = this.instPath + "\\BarTelGSM.exe";
            shortcut.Save();
            return true;
        }
        private async Task<bool> removeTempFiles()
        {
            System.IO.File.Delete(this.instPath + "\\" + this.filename);
            return true;
        }
        #endregion
        #region step3
        private void step3()
        {
            p_process.BeginInvoke(new MethodInvoker(delegate ()
            {
                p_process.Visible = false;
            }));
            p_completed.BeginInvoke(new MethodInvoker(delegate ()
            {
                p_completed.Visible = true;
                p_completed.Dock = DockStyle.Fill;
            }));
        }
        #endregion
        private void setLog(string text)
        {
            string log = text + "\r\n" + tb_log.Text;
            tb_log.Text = log;
        }
        private void setLogDelegate(string text)
        {
            tb_log.BeginInvoke(new MethodInvoker(delegate ()
            {
                string log = text + "\r\n" + tb_log.Text;
                tb_log.Text = log;
            }));
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(1);
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            Process.Start(this.instPath + "\\BarTelGSM.exe");
            Thread.Sleep(1000);
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(1);
        }
    }
}
