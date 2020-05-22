namespace BarTelGSM
{
    partial class Szerviz_megtekint
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
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tipus = new System.Windows.Forms.Label();
            this.lbl_hiba = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_jelkod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tulaj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.gb_szervizdij = new System.Windows.Forms.GroupBox();
            this.tb_szAr = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_megjegyz = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_szervizdij.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(458, 362);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 0;
            this.btn_modify.Text = "Módosít";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(377, 362);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Bezár";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_tulaj);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_jelkod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_pin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_hiba);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_tipus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szervíz adatok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Típus:";
            // 
            // lbl_tipus
            // 
            this.lbl_tipus.AutoSize = true;
            this.lbl_tipus.Location = new System.Drawing.Point(53, 16);
            this.lbl_tipus.Name = "lbl_tipus";
            this.lbl_tipus.Size = new System.Drawing.Size(37, 13);
            this.lbl_tipus.TabIndex = 1;
            this.lbl_tipus.Text = "{tipus}";
            // 
            // lbl_hiba
            // 
            this.lbl_hiba.AutoSize = true;
            this.lbl_hiba.Location = new System.Drawing.Point(53, 38);
            this.lbl_hiba.Name = "lbl_hiba";
            this.lbl_hiba.Size = new System.Drawing.Size(35, 13);
            this.lbl_hiba.TabIndex = 3;
            this.lbl_hiba.Text = "{hiba}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hiba:";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Location = new System.Drawing.Point(190, 16);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(29, 13);
            this.lbl_pin.TabIndex = 5;
            this.lbl_pin.Text = "{pin}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PIN:";
            // 
            // lbl_jelkod
            // 
            this.lbl_jelkod.AutoSize = true;
            this.lbl_jelkod.Location = new System.Drawing.Point(312, 16);
            this.lbl_jelkod.Name = "lbl_jelkod";
            this.lbl_jelkod.Size = new System.Drawing.Size(43, 13);
            this.lbl_jelkod.TabIndex = 7;
            this.lbl_jelkod.Text = "{jelkod}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jelkód:";
            // 
            // lbl_tulaj
            // 
            this.lbl_tulaj.AutoSize = true;
            this.lbl_tulaj.Location = new System.Drawing.Point(77, 58);
            this.lbl_tulaj.Name = "lbl_tulaj";
            this.lbl_tulaj.Size = new System.Drawing.Size(86, 13);
            this.lbl_tulaj.TabIndex = 9;
            this.lbl_tulaj.Text = "{tulaj} ({telszam})";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tulajdonos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_status);
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Állapot";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(10, 16);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 0;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // gb_szervizdij
            // 
            this.gb_szervizdij.Controls.Add(this.tb_szAr);
            this.gb_szervizdij.Location = new System.Drawing.Point(150, 89);
            this.gb_szervizdij.Name = "gb_szervizdij";
            this.gb_szervizdij.Size = new System.Drawing.Size(116, 45);
            this.gb_szervizdij.TabIndex = 4;
            this.gb_szervizdij.TabStop = false;
            this.gb_szervizdij.Text = "Szervízdíj";
            // 
            // tb_szAr
            // 
            this.tb_szAr.Location = new System.Drawing.Point(6, 16);
            this.tb_szAr.Name = "tb_szAr";
            this.tb_szAr.Size = new System.Drawing.Size(100, 20);
            this.tb_szAr.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_megjegyz);
            this.groupBox3.Location = new System.Drawing.Point(3, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 215);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Megjegyzés";
            // 
            // tb_megjegyz
            // 
            this.tb_megjegyz.Location = new System.Drawing.Point(10, 19);
            this.tb_megjegyz.Multiline = true;
            this.tb_megjegyz.Name = "tb_megjegyz";
            this.tb_megjegyz.Size = new System.Drawing.Size(511, 180);
            this.tb_megjegyz.TabIndex = 0;
            // 
            // Szerviz_megtekint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_szervizdij);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_modify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Szerviz_megtekint";
            this.Text = "Szerviz_megtekint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gb_szervizdij.ResumeLayout(false);
            this.gb_szervizdij.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_hiba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tipus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_jelkod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tulaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.GroupBox gb_szervizdij;
        private System.Windows.Forms.TextBox tb_szAr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_megjegyz;
    }
}