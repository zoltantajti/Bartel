﻿namespace BarTelGSM
{
    partial class Uj_szerviz
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.tb_pin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_jelkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_hiba = new System.Windows.Forms.TextBox();
            this.tb_tulaj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_telszam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Típus:";
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(68, 10);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(187, 20);
            this.tb_tipus.TabIndex = 1;
            // 
            // tb_pin
            // 
            this.tb_pin.Location = new System.Drawing.Point(68, 36);
            this.tb_pin.Name = "tb_pin";
            this.tb_pin.Size = new System.Drawing.Size(187, 20);
            this.tb_pin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PIN kód:";
            // 
            // tb_jelkod
            // 
            this.tb_jelkod.Location = new System.Drawing.Point(68, 62);
            this.tb_jelkod.Name = "tb_jelkod";
            this.tb_jelkod.Size = new System.Drawing.Size(187, 20);
            this.tb_jelkod.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jelkód:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hiba leírása:";
            // 
            // tb_hiba
            // 
            this.tb_hiba.Location = new System.Drawing.Point(16, 112);
            this.tb_hiba.Multiline = true;
            this.tb_hiba.Name = "tb_hiba";
            this.tb_hiba.Size = new System.Drawing.Size(239, 138);
            this.tb_hiba.TabIndex = 7;
            // 
            // tb_tulaj
            // 
            this.tb_tulaj.Location = new System.Drawing.Point(81, 256);
            this.tb_tulaj.Name = "tb_tulaj";
            this.tb_tulaj.Size = new System.Drawing.Size(174, 20);
            this.tb_tulaj.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tulajdonos:";
            // 
            // tb_telszam
            // 
            this.tb_telszam.Location = new System.Drawing.Point(81, 282);
            this.tb_telszam.Name = "tb_telszam";
            this.tb_telszam.Size = new System.Drawing.Size(174, 20);
            this.tb_telszam.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefonszám";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(180, 308);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(198, 335);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(46, 13);
            this.lbl_status.TabIndex = 13;
            this.lbl_status.Text = "Mentve!";
            // 
            // Uj_szerviz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 357);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_telszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_tulaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_hiba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_jelkod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Uj_szerviz";
            this.Text = "Uj_szerviz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.TextBox tb_pin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_jelkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_hiba;
        private System.Windows.Forms.TextBox tb_tulaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_telszam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_status;
    }
}