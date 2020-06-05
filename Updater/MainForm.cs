using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libsql;
using Microsoft.Win32;

namespace Updater
{
    public partial class MainForm : Form
    {
        private string path;
        private string rPath = "http://downloader.clanweb.hu/bartel/";
        private string cVer;

        private string lVer;
        private string file;
        private string reldt;
        private string changelog;

        MySQL db;
        public MainForm()
        {
            InitializeComponent();
            db = new MySQL();
            this.Text = "Bar-Tel GSM kliens Frissítés";
            p_doUpdate.Visible = false;
            p_postUpdate.Visible = false;
            p_preUpdate.Visible = true;
            p_preUpdate.Dock = DockStyle.Fill;
            ReadRegistry();
            GetNewVersion();
            lbl_cver.Text = cVer;
            lbl_lver.Text = lVer;
            lbl_reldt.Text = reldt;
            tb_chlog.Text = changelog;
        }
        #region beforeUpdate
        private void ReadRegistry()
        {
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\BarTelGSM"))
            {
                Object ver = rk.GetValue("version");
                Object p = rk.GetValue("path");
                this.cVer = ver.ToString().Replace(',','.');
                this.path = p.ToString();
            }
        }
        private void GetNewVersion()
        {
            string[] nV = db.get("soft_updates", "*", "WHERE reld='1' ORDER BY reldt DESC LIMIT 0,1");
            this.lVer = nV[1].Replace(',','.');
            this.file = nV[2];
            this.reldt = nV[4].Replace('-', '.');
            this.changelog = nV[5];
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(1);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            p_preUpdate.Visible = false;
            p_doUpdate.Visible = true;
            p_doUpdate.Dock = DockStyle.Fill;
            doUpdate();
        }
        #endregion
        #region update
        private void doUpdate()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerAsync();
        }

        private async void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            showLog("A firssítés elindult!");
            showLog("A frissítés letöltése");
            await downloadUpdate();
            showLog("A frissítés letöltve");
            showLog("A frissítés telepítése");
            await unpackUpdate();
            showLog("A frissítés telepítése");
            await copyUpdate();
            showLog("Beállításjegyzék frissítése");
            await updateRegistry();
            showLog("Ideiglenes file-ok eltávolítása");
            await cleaning();
            showLog("Frissítés kész");
            complete();
        }

        private async Task<bool> downloadUpdate()
        {
            string rFile = this.rPath + file;
            string local = this.path + "\\" + file;
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
            this.setProcessValue(e.ProgressPercentage);
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e){}
        
        private async Task<bool> unpackUpdate()
        {
            string zipPath = this.path + "\\" + this.file;
            string tmp = this.path + "\\temp";
            Directory.CreateDirectory(tmp);
            ZipFile.ExtractToDirectory(zipPath, tmp);


            return true;
        }
        
        private async Task<bool> copyUpdate()
        {
            string from = this.path + "\\temp";
            string to = this.path;
            string[] files = Directory.GetFiles(from);
            foreach(string file in files)
            {
                string name = Path.GetFileName(file);
                string target = this.path+"\\"+name;
                File.Copy(file, target, true);
                this.showLog(name + " másolva");
            }
            return true;
        }

        private async Task<bool> updateRegistry()
        {
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\BarTelGSM",true))
            {
                rk.SetValue("version", lVer.Replace('.', ','));
            }
            return true;
        }
        
        private async Task<bool> cleaning()
        {
            string from = this.path + "\\temp";
            string[] files = Directory.GetFiles(from);
            foreach(string file in files)
            {
                File.Delete(file);
            };
            Directory.Delete(from);
            File.Delete(this.path + "\\" + file);
            return true;
        }
        #endregion

        #region postUpdate
        private void complete()
        {
            p_doUpdate.BeginInvoke(new MethodInvoker(delegate () { p_doUpdate.Visible = false; }));
            p_postUpdate.BeginInvoke(new MethodInvoker(delegate ()
            {
                p_postUpdate.Visible = true;
                p_postUpdate.Dock = DockStyle.Fill;
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
            Process.Start(this.path + "\\BarTelGSM.exe");
            Thread.Sleep(1000);
            Application.Exit();
            Application.ExitThread();
            Environment.Exit(1);
        }
        #endregion

        #region invokers
        private void showLog(string text)
        {
            tb_log.BeginInvoke(new MethodInvoker(delegate ()
            {
                string log = text + "\r\n" + tb_log.Text;
                tb_log.Text = log;
            }));
        }
        private void setProcessValue(int val)
        {
            pb_process.BeginInvoke(new MethodInvoker(delegate ()
            {
                pb_process.Value = val;
            }));
        }

        #endregion

       
    }
}
