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
            this.eladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tételEladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonEladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonVételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kPKIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szervizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újSzervízToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szervízListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összessítőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_lablec = new System.Windows.Forms.StatusStrip();
            this.lbl_user = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_bolt = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_ido = new System.Windows.Forms.ToolStripStatusLabel();
            this.t_pontosIdo = new System.Windows.Forms.Timer(this.components);
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_napiAdatok = new System.Windows.Forms.GroupBox();
            this.lbl_nyito_kassza = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_kassza_ft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_kpki_ft = new System.Windows.Forms.Label();
            this.lbl_kpki_db = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_szerviz_ft = new System.Windows.Forms.Label();
            this.lbl_szerviz_db = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_tel_vetel_ft = new System.Windows.Forms.Label();
            this.lbl_tel_vetel_db = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_tel_elad_ft = new System.Windows.Forms.Label();
            this.lbl_tel_elad_db = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_napi_tetel_ft = new System.Windows.Forms.Label();
            this.lbl_napi_tetelszam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nyitokassza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ms_menu.SuspendLayout();
            this.ss_lablec.SuspendLayout();
            this.gb_napiAdatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eladásToolStripMenuItem,
            this.vételToolStripMenuItem,
            this.kPKIToolStripMenuItem,
            this.szervizToolStripMenuItem,
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
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kijelentkezésToolStripMenuItem.Text = "Kijelentkezés";
            this.kijelentkezésToolStripMenuItem.Click += new System.EventHandler(this.kijelentkezésToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
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
            this.tételEladásToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tételEladásToolStripMenuItem.Text = "Tétel eladás";
            this.tételEladásToolStripMenuItem.Click += new System.EventHandler(this.tételEladásToolStripMenuItem_Click);
            // 
            // telefonEladásToolStripMenuItem
            // 
            this.telefonEladásToolStripMenuItem.Name = "telefonEladásToolStripMenuItem";
            this.telefonEladásToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.telefonEladásToolStripMenuItem.Text = "Telefon eladás";
            this.telefonEladásToolStripMenuItem.Click += new System.EventHandler(this.telefonEladásToolStripMenuItem_Click);
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
            this.telefonVételToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.telefonVételToolStripMenuItem.Text = "Telefon vétel";
            this.telefonVételToolStripMenuItem.Click += new System.EventHandler(this.telefonVételToolStripMenuItem_Click);
            // 
            // kPKIToolStripMenuItem
            // 
            this.kPKIToolStripMenuItem.Name = "kPKIToolStripMenuItem";
            this.kPKIToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.kPKIToolStripMenuItem.Text = "KP KI";
            this.kPKIToolStripMenuItem.Click += new System.EventHandler(this.kPKIToolStripMenuItem_Click);
            // 
            // szervizToolStripMenuItem
            // 
            this.szervizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újSzervízToolStripMenuItem,
            this.szervízListaToolStripMenuItem});
            this.szervizToolStripMenuItem.Name = "szervizToolStripMenuItem";
            this.szervizToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.szervizToolStripMenuItem.Text = "Szervíz";
            // 
            // újSzervízToolStripMenuItem
            // 
            this.újSzervízToolStripMenuItem.Name = "újSzervízToolStripMenuItem";
            this.újSzervízToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.újSzervízToolStripMenuItem.Text = "Új szervíz";
            this.újSzervízToolStripMenuItem.Click += new System.EventHandler(this.újSzervízToolStripMenuItem_Click);
            // 
            // szervízListaToolStripMenuItem
            // 
            this.szervízListaToolStripMenuItem.Name = "szervízListaToolStripMenuItem";
            this.szervízListaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.szervízListaToolStripMenuItem.Text = "Szervíz lista";
            this.szervízListaToolStripMenuItem.Click += new System.EventHandler(this.szervízListaToolStripMenuItem_Click);
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
            // ss_lablec
            // 
            this.ss_lablec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_user,
            this.lbl_bolt,
            this.lbl_ido});
            this.ss_lablec.Location = new System.Drawing.Point(0, 189);
            this.ss_lablec.Name = "ss_lablec";
            this.ss_lablec.Size = new System.Drawing.Size(429, 22);
            this.ss_lablec.SizingGrip = false;
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
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(214, 28);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Bolt nyitás";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(295, 28);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Bolt zárás";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // gb_napiAdatok
            // 
            this.gb_napiAdatok.Controls.Add(this.lbl_nyito_kassza);
            this.gb_napiAdatok.Controls.Add(this.label6);
            this.gb_napiAdatok.Controls.Add(this.lbl_kassza_ft);
            this.gb_napiAdatok.Controls.Add(this.label3);
            this.gb_napiAdatok.Controls.Add(this.lbl_kpki_ft);
            this.gb_napiAdatok.Controls.Add(this.lbl_kpki_db);
            this.gb_napiAdatok.Controls.Add(this.label14);
            this.gb_napiAdatok.Controls.Add(this.lbl_szerviz_ft);
            this.gb_napiAdatok.Controls.Add(this.lbl_szerviz_db);
            this.gb_napiAdatok.Controls.Add(this.label11);
            this.gb_napiAdatok.Controls.Add(this.lbl_tel_vetel_ft);
            this.gb_napiAdatok.Controls.Add(this.lbl_tel_vetel_db);
            this.gb_napiAdatok.Controls.Add(this.label8);
            this.gb_napiAdatok.Controls.Add(this.lbl_tel_elad_ft);
            this.gb_napiAdatok.Controls.Add(this.lbl_tel_elad_db);
            this.gb_napiAdatok.Controls.Add(this.label5);
            this.gb_napiAdatok.Controls.Add(this.lbl_napi_tetel_ft);
            this.gb_napiAdatok.Controls.Add(this.lbl_napi_tetelszam);
            this.gb_napiAdatok.Controls.Add(this.label2);
            this.gb_napiAdatok.Location = new System.Drawing.Point(13, 57);
            this.gb_napiAdatok.Name = "gb_napiAdatok";
            this.gb_napiAdatok.Size = new System.Drawing.Size(404, 128);
            this.gb_napiAdatok.TabIndex = 4;
            this.gb_napiAdatok.TabStop = false;
            this.gb_napiAdatok.Text = "Napi adatok";
            // 
            // lbl_nyito_kassza
            // 
            this.lbl_nyito_kassza.AutoSize = true;
            this.lbl_nyito_kassza.Location = new System.Drawing.Point(345, 20);
            this.lbl_nyito_kassza.Name = "lbl_nyito_kassza";
            this.lbl_nyito_kassza.Size = new System.Drawing.Size(24, 13);
            this.lbl_nyito_kassza.TabIndex = 18;
            this.lbl_nyito_kassza.Text = "{Ft}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nyitó kassza:";
            // 
            // lbl_kassza_ft
            // 
            this.lbl_kassza_ft.AutoSize = true;
            this.lbl_kassza_ft.Location = new System.Drawing.Point(345, 106);
            this.lbl_kassza_ft.Name = "lbl_kassza_ft";
            this.lbl_kassza_ft.Size = new System.Drawing.Size(24, 13);
            this.lbl_kassza_ft.TabIndex = 16;
            this.lbl_kassza_ft.Text = "{Ft}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kassza:";
            // 
            // lbl_kpki_ft
            // 
            this.lbl_kpki_ft.AutoSize = true;
            this.lbl_kpki_ft.Location = new System.Drawing.Point(136, 106);
            this.lbl_kpki_ft.Name = "lbl_kpki_ft";
            this.lbl_kpki_ft.Size = new System.Drawing.Size(24, 13);
            this.lbl_kpki_ft.TabIndex = 14;
            this.lbl_kpki_ft.Text = "{Ft}";
            // 
            // lbl_kpki_db
            // 
            this.lbl_kpki_db.AutoSize = true;
            this.lbl_kpki_db.Location = new System.Drawing.Point(103, 106);
            this.lbl_kpki_db.Name = "lbl_kpki_db";
            this.lbl_kpki_db.Size = new System.Drawing.Size(27, 13);
            this.lbl_kpki_db.TabIndex = 13;
            this.lbl_kpki_db.Text = "{db}";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "KP ki:";
            // 
            // lbl_szerviz_ft
            // 
            this.lbl_szerviz_ft.AutoSize = true;
            this.lbl_szerviz_ft.Location = new System.Drawing.Point(135, 84);
            this.lbl_szerviz_ft.Name = "lbl_szerviz_ft";
            this.lbl_szerviz_ft.Size = new System.Drawing.Size(24, 13);
            this.lbl_szerviz_ft.TabIndex = 11;
            this.lbl_szerviz_ft.Text = "{Ft}";
            // 
            // lbl_szerviz_db
            // 
            this.lbl_szerviz_db.AutoSize = true;
            this.lbl_szerviz_db.Location = new System.Drawing.Point(102, 84);
            this.lbl_szerviz_db.Name = "lbl_szerviz_db";
            this.lbl_szerviz_db.Size = new System.Drawing.Size(27, 13);
            this.lbl_szerviz_db.TabIndex = 10;
            this.lbl_szerviz_db.Text = "{db}";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Szervíz:";
            // 
            // lbl_tel_vetel_ft
            // 
            this.lbl_tel_vetel_ft.AutoSize = true;
            this.lbl_tel_vetel_ft.Location = new System.Drawing.Point(136, 62);
            this.lbl_tel_vetel_ft.Name = "lbl_tel_vetel_ft";
            this.lbl_tel_vetel_ft.Size = new System.Drawing.Size(24, 13);
            this.lbl_tel_vetel_ft.TabIndex = 8;
            this.lbl_tel_vetel_ft.Text = "{Ft}";
            // 
            // lbl_tel_vetel_db
            // 
            this.lbl_tel_vetel_db.AutoSize = true;
            this.lbl_tel_vetel_db.Location = new System.Drawing.Point(103, 62);
            this.lbl_tel_vetel_db.Name = "lbl_tel_vetel_db";
            this.lbl_tel_vetel_db.Size = new System.Drawing.Size(27, 13);
            this.lbl_tel_vetel_db.TabIndex = 7;
            this.lbl_tel_vetel_db.Text = "{db}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Telefon vásárlás:";
            // 
            // lbl_tel_elad_ft
            // 
            this.lbl_tel_elad_ft.AutoSize = true;
            this.lbl_tel_elad_ft.Location = new System.Drawing.Point(136, 40);
            this.lbl_tel_elad_ft.Name = "lbl_tel_elad_ft";
            this.lbl_tel_elad_ft.Size = new System.Drawing.Size(24, 13);
            this.lbl_tel_elad_ft.TabIndex = 5;
            this.lbl_tel_elad_ft.Text = "{Ft}";
            // 
            // lbl_tel_elad_db
            // 
            this.lbl_tel_elad_db.AutoSize = true;
            this.lbl_tel_elad_db.Location = new System.Drawing.Point(103, 40);
            this.lbl_tel_elad_db.Name = "lbl_tel_elad_db";
            this.lbl_tel_elad_db.Size = new System.Drawing.Size(27, 13);
            this.lbl_tel_elad_db.TabIndex = 4;
            this.lbl_tel_elad_db.Text = "{db}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefon eladás:";
            // 
            // lbl_napi_tetel_ft
            // 
            this.lbl_napi_tetel_ft.AutoSize = true;
            this.lbl_napi_tetel_ft.Location = new System.Drawing.Point(136, 20);
            this.lbl_napi_tetel_ft.Name = "lbl_napi_tetel_ft";
            this.lbl_napi_tetel_ft.Size = new System.Drawing.Size(24, 13);
            this.lbl_napi_tetel_ft.TabIndex = 2;
            this.lbl_napi_tetel_ft.Text = "{Ft}";
            // 
            // lbl_napi_tetelszam
            // 
            this.lbl_napi_tetelszam.AutoSize = true;
            this.lbl_napi_tetelszam.Location = new System.Drawing.Point(103, 20);
            this.lbl_napi_tetelszam.Name = "lbl_napi_tetelszam";
            this.lbl_napi_tetelszam.Size = new System.Drawing.Size(27, 13);
            this.lbl_napi_tetelszam.TabIndex = 1;
            this.lbl_napi_tetelszam.Text = "{db}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Eladott tételszám:";
            // 
            // tb_nyitokassza
            // 
            this.tb_nyitokassza.Location = new System.Drawing.Point(86, 29);
            this.tb_nyitokassza.Name = "tb_nyitokassza";
            this.tb_nyitokassza.Size = new System.Drawing.Size(122, 20);
            this.tb_nyitokassza.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nyitó kassza:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nyitokassza);
            this.Controls.Add(this.gb_napiAdatok);
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
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ss_lablec.ResumeLayout(false);
            this.ss_lablec.PerformLayout();
            this.gb_napiAdatok.ResumeLayout(false);
            this.gb_napiAdatok.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem szervizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újSzervízToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szervízListaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_napiAdatok;
        private System.Windows.Forms.TextBox tb_nyitokassza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_napi_tetelszam;
        private System.Windows.Forms.Label lbl_napi_tetel_ft;
        private System.Windows.Forms.Label lbl_kpki_ft;
        private System.Windows.Forms.Label lbl_kpki_db;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_szerviz_ft;
        private System.Windows.Forms.Label lbl_szerviz_db;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_tel_vetel_ft;
        private System.Windows.Forms.Label lbl_tel_vetel_db;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_tel_elad_ft;
        private System.Windows.Forms.Label lbl_tel_elad_db;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_kassza_ft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nyito_kassza;
        private System.Windows.Forms.Label label6;
    }
}

