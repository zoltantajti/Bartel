namespace BarTelGSM
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
            this.components = new System.ComponentModel.Container();
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_lablec = new System.Windows.Forms.StatusStrip();
            this.lbl_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_bolt = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_ido = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_pontosIdo = new System.Windows.Forms.Timer(this.components);
            this.eladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tételEladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonEladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonVételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összessítőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kPKIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.ms_menu.SuspendLayout();
            this.ss_lablec.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eladásToolStripMenuItem,
            this.vételToolStripMenuItem,
            this.kPKIToolStripMenuItem,
            this.termékekToolStripMenuItem,
            this.összessítőkToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(429, 24);
            this.ms_menu.TabIndex = 0;
            this.ms_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kijelentkezésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // kijelentkezésToolStripMenuItem
            // 
            this.kijelentkezésToolStripMenuItem.Name = "kijelentkezésToolStripMenuItem";
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kijelentkezésToolStripMenuItem.Text = "Kijelentkezés";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // ss_lablec
            // 
            this.ss_lablec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_user,
            this.lbl_bolt,
            this.lbl_ido});
            this.ss_lablec.Location = new System.Drawing.Point(0, 244);
            this.ss_lablec.Name = "ss_lablec";
            this.ss_lablec.Size = new System.Drawing.Size(429, 22);
            this.ss_lablec.TabIndex = 1;
            this.ss_lablec.Text = "statusStrip1";
            // 
            // lbl_user
            // 
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(60, 17);
            this.lbl_user.Text = "Szia {user}";
            // 
            // lbl_bolt
            // 
            this.lbl_bolt.Name = "lbl_bolt";
            this.lbl_bolt.Size = new System.Drawing.Size(53, 17);
            this.lbl_bolt.Text = "{boltnev}";
            // 
            // lbl_ido
            // 
            this.lbl_ido.Name = "lbl_ido";
            this.lbl_ido.Size = new System.Drawing.Size(31, 17);
            this.lbl_ido.Text = "{ido}";
            // 
            // t_pontosIdo
            // 
            this.t_pontosIdo.Interval = 1000;
            this.t_pontosIdo.Tick += new System.EventHandler(this.t_pontosIdo_Tick);
            // 
            // eladásToolStripMenuItem
            // 
            this.eladásToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tételEladásToolStripMenuItem,
            this.telefonEladásToolStripMenuItem});
            this.eladásToolStripMenuItem.Name = "eladásToolStripMenuItem";
            this.eladásToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.eladásToolStripMenuItem.Text = "Eladás";
            // 
            // tételEladásToolStripMenuItem
            // 
            this.tételEladásToolStripMenuItem.Name = "tételEladásToolStripMenuItem";
            this.tételEladásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tételEladásToolStripMenuItem.Text = "Tétel eladás";
            // 
            // telefonEladásToolStripMenuItem
            // 
            this.telefonEladásToolStripMenuItem.Name = "telefonEladásToolStripMenuItem";
            this.telefonEladásToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telefonEladásToolStripMenuItem.Text = "Telefon eladás";
            // 
            // vételToolStripMenuItem
            // 
            this.vételToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telefonVételToolStripMenuItem});
            this.vételToolStripMenuItem.Name = "vételToolStripMenuItem";
            this.vételToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.vételToolStripMenuItem.Text = "Vétel";
            // 
            // telefonVételToolStripMenuItem
            // 
            this.telefonVételToolStripMenuItem.Name = "telefonVételToolStripMenuItem";
            this.telefonVételToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telefonVételToolStripMenuItem.Text = "Telefon vétel";
            // 
            // termékekToolStripMenuItem
            // 
            this.termékekToolStripMenuItem.Name = "termékekToolStripMenuItem";
            this.termékekToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.termékekToolStripMenuItem.Text = "Termékek";
            // 
            // összessítőkToolStripMenuItem
            // 
            this.összessítőkToolStripMenuItem.Name = "összessítőkToolStripMenuItem";
            this.összessítőkToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.összessítőkToolStripMenuItem.Text = "Összessítők";
            // 
            // kPKIToolStripMenuItem
            // 
            this.kPKIToolStripMenuItem.Name = "kPKIToolStripMenuItem";
            this.kPKIToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.kPKIToolStripMenuItem.Text = "KP KI";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(12, 27);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Bolt nyitás";
            this.btn_open.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 56);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Bolt zárás";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 266);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.ss_lablec);
            this.Controls.Add(this.ms_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar-Tel GSM";
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ss_lablec.ResumeLayout(false);
            this.ss_lablec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ss_lablec;
        private System.Windows.Forms.ToolStripStatusLabel lbl_user;
        private System.Windows.Forms.ToolStripStatusLabel lbl_bolt;
        private System.Windows.Forms.ToolStripStatusLabel lbl_ido;
        private System.Windows.Forms.Timer t_pontosIdo;
        private System.Windows.Forms.ToolStripMenuItem eladásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tételEladásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonEladásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vételToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonVételToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kPKIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termékekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összessítőkToolStripMenuItem;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_close;
    }
}

