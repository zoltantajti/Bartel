namespace Setup
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.p_setup = new System.Windows.Forms.Panel();
            this.btn_install = new System.Windows.Forms.Button();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tb_installPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_completed = new System.Windows.Forms.Panel();
            this.fbd_installPath = new System.Windows.Forms.FolderBrowserDialog();
            this.p_process = new System.Windows.Forms.Panel();
            this.pb_fileComplete = new System.Windows.Forms.ProgressBar();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.tlp_frame = new System.Windows.Forms.TableLayoutPanel();
            this.p_frame_right = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_setup.SuspendLayout();
            this.p_completed.SuspendLayout();
            this.p_process.SuspendLayout();
            this.tlp_frame.SuspendLayout();
            this.p_frame_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // p_setup
            // 
            this.p_setup.Controls.Add(this.btn_install);
            this.p_setup.Controls.Add(this.tb_passwd);
            this.p_setup.Controls.Add(this.label2);
            this.p_setup.Controls.Add(this.btn_browse);
            this.p_setup.Controls.Add(this.tb_installPath);
            this.p_setup.Controls.Add(this.label1);
            this.p_setup.Location = new System.Drawing.Point(0, 3);
            this.p_setup.Name = "p_setup";
            this.p_setup.Size = new System.Drawing.Size(369, 106);
            this.p_setup.TabIndex = 0;
            // 
            // btn_install
            // 
            this.btn_install.Location = new System.Drawing.Point(271, 68);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(75, 23);
            this.btn_install.TabIndex = 5;
            this.btn_install.Text = "Telepítés";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(14, 70);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.PasswordChar = '*';
            this.tb_passwd.Size = new System.Drawing.Size(248, 20);
            this.tb_passwd.TabIndex = 4;
            this.tb_passwd.TextChanged += new System.EventHandler(this.tb_passwd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó:";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(271, 24);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Tallózás";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_installPath
            // 
            this.tb_installPath.Location = new System.Drawing.Point(14, 26);
            this.tb_installPath.Name = "tb_installPath";
            this.tb_installPath.Size = new System.Drawing.Size(251, 20);
            this.tb_installPath.TabIndex = 1;
            this.tb_installPath.TextChanged += new System.EventHandler(this.tb_installPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telepítési útvonal kiválasztása:";
            // 
            // p_completed
            // 
            this.p_completed.Controls.Add(this.btn_close);
            this.p_completed.Controls.Add(this.btn_run);
            this.p_completed.Controls.Add(this.label4);
            this.p_completed.Location = new System.Drawing.Point(6, 314);
            this.p_completed.Name = "p_completed";
            this.p_completed.Size = new System.Drawing.Size(363, 37);
            this.p_completed.TabIndex = 2;
            // 
            // p_process
            // 
            this.p_process.Controls.Add(this.pb_fileComplete);
            this.p_process.Controls.Add(this.tb_log);
            this.p_process.Controls.Add(this.label3);
            this.p_process.Location = new System.Drawing.Point(4, 115);
            this.p_process.Name = "p_process";
            this.p_process.Size = new System.Drawing.Size(366, 193);
            this.p_process.TabIndex = 1;
            // 
            // pb_fileComplete
            // 
            this.pb_fileComplete.Location = new System.Drawing.Point(17, 116);
            this.pb_fileComplete.Name = "pb_fileComplete";
            this.pb_fileComplete.Size = new System.Drawing.Size(329, 23);
            this.pb_fileComplete.TabIndex = 2;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(17, 25);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ReadOnly = true;
            this.tb_log.Size = new System.Drawing.Size(329, 84);
            this.tb_log.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telepítés folyamatban...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "A telepítő sikeresen befejeződött!";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(278, 6);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Indítás";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(197, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Bezárás";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tlp_frame
            // 
            this.tlp_frame.ColumnCount = 2;
            this.tlp_frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.94455F));
            this.tlp_frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.05545F));
            this.tlp_frame.Controls.Add(this.p_frame_right, 1, 0);
            this.tlp_frame.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_frame.Location = new System.Drawing.Point(0, 0);
            this.tlp_frame.Name = "tlp_frame";
            this.tlp_frame.RowCount = 1;
            this.tlp_frame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_frame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_frame.Size = new System.Drawing.Size(541, 360);
            this.tlp_frame.TabIndex = 3;
            // 
            // p_frame_right
            // 
            this.p_frame_right.Controls.Add(this.p_completed);
            this.p_frame_right.Controls.Add(this.p_process);
            this.p_frame_right.Controls.Add(this.p_setup);
            this.p_frame_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_frame_right.Location = new System.Drawing.Point(165, 3);
            this.p_frame_right.Name = "p_frame_right";
            this.p_frame_right.Size = new System.Drawing.Size(373, 354);
            this.p_frame_right.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Setup.Properties.Resources.installer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 354);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 360);
            this.Controls.Add(this.tlp_frame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.p_setup.ResumeLayout(false);
            this.p_setup.PerformLayout();
            this.p_completed.ResumeLayout(false);
            this.p_completed.PerformLayout();
            this.p_process.ResumeLayout(false);
            this.p_process.PerformLayout();
            this.tlp_frame.ResumeLayout(false);
            this.p_frame_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_setup;
        private System.Windows.Forms.Panel p_completed;
        private System.Windows.Forms.FolderBrowserDialog fbd_installPath;
        private System.Windows.Forms.TextBox tb_installPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox tb_passwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Panel p_process;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.ProgressBar pb_fileComplete;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tlp_frame;
        private System.Windows.Forms.Panel p_frame_right;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

