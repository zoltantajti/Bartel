namespace BarTelGSM
{
    partial class TulajForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TulajForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_today = new System.Windows.Forms.Label();
            this.gb_kisbolt = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_kb_nyitzar = new System.Windows.Forms.Label();
            this.lbl_nb_nyitzar = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_countDown = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_update = new System.Windows.Forms.Button();
            this.Timer_countdown = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_k_nyito = new System.Windows.Forms.Label();
            this.lbl_k_tetelszam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_k_tetel_ft = new System.Windows.Forms.Label();
            this.lbl_k_telVet_ft = new System.Windows.Forms.Label();
            this.lbl_k_telVet_db = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_k_tel_elad_ft = new System.Windows.Forms.Label();
            this.lbl_k_tel_elad_db = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_k_szerviz_ft = new System.Windows.Forms.Label();
            this.lbl_k_szerviz_db = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_k_kpki_ft = new System.Windows.Forms.Label();
            this.lbl_k_kpki_db = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_k_zaro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_n_zaro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_n_kpki_ft = new System.Windows.Forms.Label();
            this.lbl_n_kpki_db = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_n_szerviz_ft = new System.Windows.Forms.Label();
            this.lbl_n_szerviz_db = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_n_tel_elad_ft = new System.Windows.Forms.Label();
            this.lbl_n_tel_elad_db = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_n_tel_vetel_ft = new System.Windows.Forms.Label();
            this.lbl_n_tel_vetel_db = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_n_tetel_ft = new System.Windows.Forms.Label();
            this.lbl_n_tetel_db = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbl_n_nyito = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb_kisbolt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.lbl_today);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 28);
            this.panel1.TabIndex = 0;
            // 
            // lbl_today
            // 
            this.lbl_today.AutoSize = true;
            this.lbl_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_today.Location = new System.Drawing.Point(213, 7);
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(48, 13);
            this.lbl_today.TabIndex = 0;
            this.lbl_today.Text = "{today}";
            // 
            // gb_kisbolt
            // 
            this.gb_kisbolt.Controls.Add(this.lbl_k_zaro);
            this.gb_kisbolt.Controls.Add(this.label4);
            this.gb_kisbolt.Controls.Add(this.lbl_k_kpki_ft);
            this.gb_kisbolt.Controls.Add(this.lbl_k_kpki_db);
            this.gb_kisbolt.Controls.Add(this.label8);
            this.gb_kisbolt.Controls.Add(this.lbl_k_szerviz_ft);
            this.gb_kisbolt.Controls.Add(this.lbl_k_szerviz_db);
            this.gb_kisbolt.Controls.Add(this.label7);
            this.gb_kisbolt.Controls.Add(this.lbl_k_tel_elad_ft);
            this.gb_kisbolt.Controls.Add(this.lbl_k_tel_elad_db);
            this.gb_kisbolt.Controls.Add(this.label6);
            this.gb_kisbolt.Controls.Add(this.lbl_k_telVet_ft);
            this.gb_kisbolt.Controls.Add(this.lbl_k_telVet_db);
            this.gb_kisbolt.Controls.Add(this.label5);
            this.gb_kisbolt.Controls.Add(this.lbl_k_tetel_ft);
            this.gb_kisbolt.Controls.Add(this.lbl_k_tetelszam);
            this.gb_kisbolt.Controls.Add(this.label3);
            this.gb_kisbolt.Controls.Add(this.lbl_k_nyito);
            this.gb_kisbolt.Controls.Add(this.label1);
            this.gb_kisbolt.Controls.Add(this.lbl_kb_nyitzar);
            this.gb_kisbolt.Location = new System.Drawing.Point(0, 34);
            this.gb_kisbolt.Name = "gb_kisbolt";
            this.gb_kisbolt.Size = new System.Drawing.Size(239, 263);
            this.gb_kisbolt.TabIndex = 1;
            this.gb_kisbolt.TabStop = false;
            this.gb_kisbolt.Text = "Kisbolt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_n_zaro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_n_kpki_ft);
            this.groupBox2.Controls.Add(this.lbl_n_kpki_db);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbl_n_szerviz_ft);
            this.groupBox2.Controls.Add(this.lbl_n_szerviz_db);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbl_n_tel_elad_ft);
            this.groupBox2.Controls.Add(this.lbl_n_tel_elad_db);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbl_n_tel_vetel_ft);
            this.groupBox2.Controls.Add(this.lbl_n_tel_vetel_db);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lbl_n_tetel_ft);
            this.groupBox2.Controls.Add(this.lbl_n_tetel_db);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.lbl_n_nyito);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.lbl_nb_nyitzar);
            this.groupBox2.Location = new System.Drawing.Point(245, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 263);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nagybolt";
            // 
            // lbl_kb_nyitzar
            // 
            this.lbl_kb_nyitzar.AutoSize = true;
            this.lbl_kb_nyitzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_kb_nyitzar.Location = new System.Drawing.Point(98, 16);
            this.lbl_kb_nyitzar.Name = "lbl_kb_nyitzar";
            this.lbl_kb_nyitzar.Size = new System.Drawing.Size(41, 13);
            this.lbl_kb_nyitzar.TabIndex = 0;
            this.lbl_kb_nyitzar.Text = "label1";
            // 
            // lbl_nb_nyitzar
            // 
            this.lbl_nb_nyitzar.AutoSize = true;
            this.lbl_nb_nyitzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nb_nyitzar.Location = new System.Drawing.Point(105, 16);
            this.lbl_nb_nyitzar.Name = "lbl_nb_nyitzar";
            this.lbl_nb_nyitzar.Size = new System.Drawing.Size(41, 13);
            this.lbl_nb_nyitzar.TabIndex = 1;
            this.lbl_nb_nyitzar.Text = "label2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_countDown});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(483, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_countDown
            // 
            this.lbl_countDown.Name = "lbl_countDown";
            this.lbl_countDown.Size = new System.Drawing.Size(61, 17);
            this.lbl_countDown.Text = "countDown";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(405, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Frissítés";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // Timer_countdown
            // 
            this.Timer_countdown.Interval = 1000;
            this.Timer_countdown.Tick += new System.EventHandler(this.Timer_countdown_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nyitó kassza:";
            // 
            // lbl_k_nyito
            // 
            this.lbl_k_nyito.AutoSize = true;
            this.lbl_k_nyito.Location = new System.Drawing.Point(103, 40);
            this.lbl_k_nyito.Name = "lbl_k_nyito";
            this.lbl_k_nyito.Size = new System.Drawing.Size(25, 13);
            this.lbl_k_nyito.TabIndex = 2;
            this.lbl_k_nyito.Text = "0 Ft";
            // 
            // lbl_k_tetelszam
            // 
            this.lbl_k_tetelszam.AutoSize = true;
            this.lbl_k_tetelszam.Location = new System.Drawing.Point(103, 63);
            this.lbl_k_tetelszam.Name = "lbl_k_tetelszam";
            this.lbl_k_tetelszam.Size = new System.Drawing.Size(28, 13);
            this.lbl_k_tetelszam.TabIndex = 4;
            this.lbl_k_tetelszam.Text = "0 db";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tételszám";
            // 
            // lbl_k_tetel_ft
            // 
            this.lbl_k_tetel_ft.AutoSize = true;
            this.lbl_k_tetel_ft.Location = new System.Drawing.Point(168, 63);
            this.lbl_k_tetel_ft.Name = "lbl_k_tetel_ft";
            this.lbl_k_tetel_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_k_tetel_ft.TabIndex = 5;
            this.lbl_k_tetel_ft.Text = "0 Ft";
            // 
            // lbl_k_telVet_ft
            // 
            this.lbl_k_telVet_ft.AutoSize = true;
            this.lbl_k_telVet_ft.Location = new System.Drawing.Point(168, 85);
            this.lbl_k_telVet_ft.Name = "lbl_k_telVet_ft";
            this.lbl_k_telVet_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_k_telVet_ft.TabIndex = 8;
            this.lbl_k_telVet_ft.Text = "0 Ft";
            // 
            // lbl_k_telVet_db
            // 
            this.lbl_k_telVet_db.AutoSize = true;
            this.lbl_k_telVet_db.Location = new System.Drawing.Point(103, 85);
            this.lbl_k_telVet_db.Name = "lbl_k_telVet_db";
            this.lbl_k_telVet_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_k_telVet_db.TabIndex = 7;
            this.lbl_k_telVet_db.Text = "0 db";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefon vétel:";
            // 
            // lbl_k_tel_elad_ft
            // 
            this.lbl_k_tel_elad_ft.AutoSize = true;
            this.lbl_k_tel_elad_ft.Location = new System.Drawing.Point(168, 107);
            this.lbl_k_tel_elad_ft.Name = "lbl_k_tel_elad_ft";
            this.lbl_k_tel_elad_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_k_tel_elad_ft.TabIndex = 11;
            this.lbl_k_tel_elad_ft.Text = "0 Ft";
            // 
            // lbl_k_tel_elad_db
            // 
            this.lbl_k_tel_elad_db.AutoSize = true;
            this.lbl_k_tel_elad_db.Location = new System.Drawing.Point(103, 107);
            this.lbl_k_tel_elad_db.Name = "lbl_k_tel_elad_db";
            this.lbl_k_tel_elad_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_k_tel_elad_db.TabIndex = 10;
            this.lbl_k_tel_elad_db.Text = "0 db";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefon eladás:";
            // 
            // lbl_k_szerviz_ft
            // 
            this.lbl_k_szerviz_ft.AutoSize = true;
            this.lbl_k_szerviz_ft.Location = new System.Drawing.Point(168, 130);
            this.lbl_k_szerviz_ft.Name = "lbl_k_szerviz_ft";
            this.lbl_k_szerviz_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_k_szerviz_ft.TabIndex = 14;
            this.lbl_k_szerviz_ft.Text = "0 Ft";
            // 
            // lbl_k_szerviz_db
            // 
            this.lbl_k_szerviz_db.AutoSize = true;
            this.lbl_k_szerviz_db.Location = new System.Drawing.Point(103, 130);
            this.lbl_k_szerviz_db.Name = "lbl_k_szerviz_db";
            this.lbl_k_szerviz_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_k_szerviz_db.TabIndex = 13;
            this.lbl_k_szerviz_db.Text = "0 db";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Szervíz:";
            // 
            // lbl_k_kpki_ft
            // 
            this.lbl_k_kpki_ft.AutoSize = true;
            this.lbl_k_kpki_ft.Location = new System.Drawing.Point(168, 153);
            this.lbl_k_kpki_ft.Name = "lbl_k_kpki_ft";
            this.lbl_k_kpki_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_k_kpki_ft.TabIndex = 17;
            this.lbl_k_kpki_ft.Text = "0 Ft";
            // 
            // lbl_k_kpki_db
            // 
            this.lbl_k_kpki_db.AutoSize = true;
            this.lbl_k_kpki_db.Location = new System.Drawing.Point(103, 153);
            this.lbl_k_kpki_db.Name = "lbl_k_kpki_db";
            this.lbl_k_kpki_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_k_kpki_db.TabIndex = 16;
            this.lbl_k_kpki_db.Text = "0 db";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "KP KI:";
            // 
            // lbl_k_zaro
            // 
            this.lbl_k_zaro.AutoSize = true;
            this.lbl_k_zaro.Location = new System.Drawing.Point(103, 178);
            this.lbl_k_zaro.Name = "lbl_k_zaro";
            this.lbl_k_zaro.Size = new System.Drawing.Size(25, 13);
            this.lbl_k_zaro.TabIndex = 19;
            this.lbl_k_zaro.Text = "0 Ft";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Záró kassza:";
            // 
            // lbl_n_zaro
            // 
            this.lbl_n_zaro.AutoSize = true;
            this.lbl_n_zaro.Location = new System.Drawing.Point(109, 178);
            this.lbl_n_zaro.Name = "lbl_n_zaro";
            this.lbl_n_zaro.Size = new System.Drawing.Size(25, 13);
            this.lbl_n_zaro.TabIndex = 38;
            this.lbl_n_zaro.Text = "0 Ft";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Záró kassza:";
            // 
            // lbl_n_kpki_ft
            // 
            this.lbl_n_kpki_ft.AutoSize = true;
            this.lbl_n_kpki_ft.Location = new System.Drawing.Point(174, 153);
            this.lbl_n_kpki_ft.Name = "lbl_n_kpki_ft";
            this.lbl_n_kpki_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_n_kpki_ft.TabIndex = 36;
            this.lbl_n_kpki_ft.Text = "0 Ft";
            // 
            // lbl_n_kpki_db
            // 
            this.lbl_n_kpki_db.AutoSize = true;
            this.lbl_n_kpki_db.Location = new System.Drawing.Point(109, 153);
            this.lbl_n_kpki_db.Name = "lbl_n_kpki_db";
            this.lbl_n_kpki_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_n_kpki_db.TabIndex = 35;
            this.lbl_n_kpki_db.Text = "0 db";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "KP KI:";
            // 
            // lbl_n_szerviz_ft
            // 
            this.lbl_n_szerviz_ft.AutoSize = true;
            this.lbl_n_szerviz_ft.Location = new System.Drawing.Point(174, 130);
            this.lbl_n_szerviz_ft.Name = "lbl_n_szerviz_ft";
            this.lbl_n_szerviz_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_n_szerviz_ft.TabIndex = 33;
            this.lbl_n_szerviz_ft.Text = "0 Ft";
            // 
            // lbl_n_szerviz_db
            // 
            this.lbl_n_szerviz_db.AutoSize = true;
            this.lbl_n_szerviz_db.Location = new System.Drawing.Point(109, 130);
            this.lbl_n_szerviz_db.Name = "lbl_n_szerviz_db";
            this.lbl_n_szerviz_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_n_szerviz_db.TabIndex = 32;
            this.lbl_n_szerviz_db.Text = "0 db";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Szervíz:";
            // 
            // lbl_n_tel_elad_ft
            // 
            this.lbl_n_tel_elad_ft.AutoSize = true;
            this.lbl_n_tel_elad_ft.Location = new System.Drawing.Point(174, 107);
            this.lbl_n_tel_elad_ft.Name = "lbl_n_tel_elad_ft";
            this.lbl_n_tel_elad_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_n_tel_elad_ft.TabIndex = 30;
            this.lbl_n_tel_elad_ft.Text = "0 Ft";
            // 
            // lbl_n_tel_elad_db
            // 
            this.lbl_n_tel_elad_db.AutoSize = true;
            this.lbl_n_tel_elad_db.Location = new System.Drawing.Point(109, 107);
            this.lbl_n_tel_elad_db.Name = "lbl_n_tel_elad_db";
            this.lbl_n_tel_elad_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_n_tel_elad_db.TabIndex = 29;
            this.lbl_n_tel_elad_db.Text = "0 db";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Telefon eladás:";
            // 
            // lbl_n_tel_vetel_ft
            // 
            this.lbl_n_tel_vetel_ft.AutoSize = true;
            this.lbl_n_tel_vetel_ft.Location = new System.Drawing.Point(174, 85);
            this.lbl_n_tel_vetel_ft.Name = "lbl_n_tel_vetel_ft";
            this.lbl_n_tel_vetel_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_n_tel_vetel_ft.TabIndex = 27;
            this.lbl_n_tel_vetel_ft.Text = "0 Ft";
            // 
            // lbl_n_tel_vetel_db
            // 
            this.lbl_n_tel_vetel_db.AutoSize = true;
            this.lbl_n_tel_vetel_db.Location = new System.Drawing.Point(109, 85);
            this.lbl_n_tel_vetel_db.Name = "lbl_n_tel_vetel_db";
            this.lbl_n_tel_vetel_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_n_tel_vetel_db.TabIndex = 26;
            this.lbl_n_tel_vetel_db.Text = "0 db";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = "Telefon vétel:";
            // 
            // lbl_n_tetel_ft
            // 
            this.lbl_n_tetel_ft.AutoSize = true;
            this.lbl_n_tetel_ft.Location = new System.Drawing.Point(174, 63);
            this.lbl_n_tetel_ft.Name = "lbl_n_tetel_ft";
            this.lbl_n_tetel_ft.Size = new System.Drawing.Size(25, 13);
            this.lbl_n_tetel_ft.TabIndex = 24;
            this.lbl_n_tetel_ft.Text = "0 Ft";
            // 
            // lbl_n_tetel_db
            // 
            this.lbl_n_tetel_db.AutoSize = true;
            this.lbl_n_tetel_db.Location = new System.Drawing.Point(109, 63);
            this.lbl_n_tetel_db.Name = "lbl_n_tetel_db";
            this.lbl_n_tetel_db.Size = new System.Drawing.Size(28, 13);
            this.lbl_n_tetel_db.TabIndex = 23;
            this.lbl_n_tetel_db.Text = "0 db";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 22;
            this.label24.Text = "Tételszám";
            // 
            // lbl_n_nyito
            // 
            this.lbl_n_nyito.AutoSize = true;
            this.lbl_n_nyito.Location = new System.Drawing.Point(109, 40);
            this.lbl_n_nyito.Name = "lbl_n_nyito";
            this.lbl_n_nyito.Size = new System.Drawing.Size(25, 13);
            this.lbl_n_nyito.TabIndex = 21;
            this.lbl_n_nyito.Text = "0 Ft";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 13);
            this.label26.TabIndex = 20;
            this.label26.Text = "Nyitó kassza:";
            // 
            // TulajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 322);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_kisbolt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TulajForm";
            this.Text = "TulajForm";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_kisbolt.ResumeLayout(false);
            this.gb_kisbolt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_today;
        private System.Windows.Forms.GroupBox gb_kisbolt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_kb_nyitzar;
        private System.Windows.Forms.Label lbl_nb_nyitzar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_countDown;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Timer Timer_countdown;
        private System.Windows.Forms.Label lbl_k_tetelszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_k_nyito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_k_tetel_ft;
        private System.Windows.Forms.Label lbl_k_telVet_ft;
        private System.Windows.Forms.Label lbl_k_telVet_db;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_k_tel_elad_ft;
        private System.Windows.Forms.Label lbl_k_tel_elad_db;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_k_szerviz_ft;
        private System.Windows.Forms.Label lbl_k_szerviz_db;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_k_kpki_ft;
        private System.Windows.Forms.Label lbl_k_kpki_db;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_k_zaro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_n_zaro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_n_kpki_ft;
        private System.Windows.Forms.Label lbl_n_kpki_db;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_n_szerviz_ft;
        private System.Windows.Forms.Label lbl_n_szerviz_db;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_n_tel_elad_ft;
        private System.Windows.Forms.Label lbl_n_tel_elad_db;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_n_tel_vetel_ft;
        private System.Windows.Forms.Label lbl_n_tel_vetel_db;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_n_tetel_ft;
        private System.Windows.Forms.Label lbl_n_tetel_db;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbl_n_nyito;
        private System.Windows.Forms.Label label26;
    }
}