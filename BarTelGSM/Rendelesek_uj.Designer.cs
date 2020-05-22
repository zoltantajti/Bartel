namespace BarTelGSM
{
    partial class Rendelesek_uj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rendelesek_uj));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_termek = new System.Windows.Forms.TextBox();
            this.tb_leiras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_telszam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék:";
            // 
            // tb_termek
            // 
            this.tb_termek.Location = new System.Drawing.Point(64, 6);
            this.tb_termek.Name = "tb_termek";
            this.tb_termek.Size = new System.Drawing.Size(198, 20);
            this.tb_termek.TabIndex = 1;
            // 
            // tb_leiras
            // 
            this.tb_leiras.Location = new System.Drawing.Point(15, 51);
            this.tb_leiras.Multiline = true;
            this.tb_leiras.Name = "tb_leiras";
            this.tb_leiras.Size = new System.Drawing.Size(247, 104);
            this.tb_leiras.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leírás:";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(83, 161);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(179, 20);
            this.tb_nev.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Név:";
            // 
            // tb_telszam
            // 
            this.tb_telszam.Location = new System.Drawing.Point(83, 187);
            this.tb_telszam.Name = "tb_telszam";
            this.tb_telszam.Size = new System.Drawing.Size(179, 20);
            this.tb_telszam.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel. szám:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(187, 213);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Rögzít";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(197, 239);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(54, 13);
            this.lbl_status.TabIndex = 9;
            this.lbl_status.Text = "Rögzítve!";
            // 
            // timer_status
            // 
            this.timer_status.Interval = 5000;
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick);
            // 
            // Rendelesek_uj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 257);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_telszam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_leiras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_termek);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rendelesek_uj";
            this.Text = "Rendelesek_uj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_termek;
        private System.Windows.Forms.TextBox tb_leiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_telszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer_status;
    }
}