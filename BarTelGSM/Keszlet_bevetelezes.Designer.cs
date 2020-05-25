namespace BarTelGSM
{
    partial class Keszlet_bevetelezes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keszlet_bevetelezes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_keres_ean = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_keres_nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_termek_box = new System.Windows.Forms.GroupBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.tb_db = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ean = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb_termek_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.tb_keres_ean);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_keres_nev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tétel keresése";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(224, 23);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Törlés";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(224, 52);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Keresés";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_keres_ean
            // 
            this.tb_keres_ean.Location = new System.Drawing.Point(118, 32);
            this.tb_keres_ean.Name = "tb_keres_ean";
            this.tb_keres_ean.Size = new System.Drawing.Size(100, 20);
            this.tb_keres_ean.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vonalkód";
            // 
            // tb_keres_nev
            // 
            this.tb_keres_nev.Location = new System.Drawing.Point(12, 32);
            this.tb_keres_nev.Name = "tb_keres_nev";
            this.tb_keres_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_keres_nev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terméknév";
            // 
            // gb_termek_box
            // 
            this.gb_termek_box.Controls.Add(this.btn_modify);
            this.gb_termek_box.Controls.Add(this.btn_new);
            this.gb_termek_box.Controls.Add(this.tb_db);
            this.gb_termek_box.Controls.Add(this.label6);
            this.gb_termek_box.Controls.Add(this.tb_ar);
            this.gb_termek_box.Controls.Add(this.label5);
            this.gb_termek_box.Controls.Add(this.tb_ean);
            this.gb_termek_box.Controls.Add(this.label4);
            this.gb_termek_box.Controls.Add(this.tb_nev);
            this.gb_termek_box.Controls.Add(this.label3);
            this.gb_termek_box.Location = new System.Drawing.Point(0, 113);
            this.gb_termek_box.Name = "gb_termek_box";
            this.gb_termek_box.Size = new System.Drawing.Size(311, 153);
            this.gb_termek_box.TabIndex = 1;
            this.gb_termek_box.TabStop = false;
            this.gb_termek_box.Text = "Termék hozzáadása";
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(142, 120);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 9;
            this.btn_modify.Text = "Módosít";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(224, 120);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 8;
            this.btn_new.Text = "Új termék";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // tb_db
            // 
            this.tb_db.Location = new System.Drawing.Point(91, 94);
            this.tb_db.Name = "tb_db";
            this.tb_db.Size = new System.Drawing.Size(208, 20);
            this.tb_db.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Darabszám:";
            // 
            // tb_ar
            // 
            this.tb_ar.Location = new System.Drawing.Point(91, 68);
            this.tb_ar.Name = "tb_ar";
            this.tb_ar.Size = new System.Drawing.Size(208, 20);
            this.tb_ar.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Elad. ár:";
            // 
            // tb_ean
            // 
            this.tb_ean.Location = new System.Drawing.Point(91, 42);
            this.tb_ean.Name = "tb_ean";
            this.tb_ean.Size = new System.Drawing.Size(208, 20);
            this.tb_ean.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vonalkód";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(91, 13);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(208, 20);
            this.tb_nev.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Termék neve:";
            // 
            // Keszlet_bevetelezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 266);
            this.Controls.Add(this.gb_termek_box);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Keszlet_bevetelezes";
            this.Text = "Keszlet_bevetelezes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_termek_box.ResumeLayout(false);
            this.gb_termek_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_keres_ean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_keres_nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_termek_box;
        private System.Windows.Forms.TextBox tb_db;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_clear;
    }
}