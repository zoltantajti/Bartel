namespace BarTelGSM
{
    partial class Keszlet_Selejt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keszlet_Selejt));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.gb_result = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_selejt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_darabszam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_vonalkod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék név:";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(85, 6);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(261, 20);
            this.tb_name.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(352, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Keresés";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // gb_result
            // 
            this.gb_result.Controls.Add(this.btn_save);
            this.gb_result.Controls.Add(this.tb_selejt);
            this.gb_result.Controls.Add(this.label3);
            this.gb_result.Controls.Add(this.lbl_darabszam);
            this.gb_result.Controls.Add(this.label5);
            this.gb_result.Controls.Add(this.lbl_vonalkod);
            this.gb_result.Controls.Add(this.label4);
            this.gb_result.Controls.Add(this.lbl_name);
            this.gb_result.Controls.Add(this.label2);
            this.gb_result.Location = new System.Drawing.Point(15, 32);
            this.gb_result.Name = "gb_result";
            this.gb_result.Size = new System.Drawing.Size(412, 147);
            this.gb_result.TabIndex = 3;
            this.gb_result.TabStop = false;
            this.gb_result.Text = "Találat:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(198, 110);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_selejt
            // 
            this.tb_selejt.Location = new System.Drawing.Point(92, 112);
            this.tb_selejt.Name = "tb_selejt";
            this.tb_selejt.Size = new System.Drawing.Size(100, 20);
            this.tb_selejt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selejt darab:";
            // 
            // lbl_darabszam
            // 
            this.lbl_darabszam.AutoSize = true;
            this.lbl_darabszam.Location = new System.Drawing.Point(89, 71);
            this.lbl_darabszam.Name = "lbl_darabszam";
            this.lbl_darabszam.Size = new System.Drawing.Size(51, 13);
            this.lbl_darabszam.TabIndex = 9;
            this.lbl_darabszam.Text = "{dbszam}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Darabszám:";
            // 
            // lbl_vonalkod
            // 
            this.lbl_vonalkod.AutoSize = true;
            this.lbl_vonalkod.Location = new System.Drawing.Point(89, 49);
            this.lbl_vonalkod.Name = "lbl_vonalkod";
            this.lbl_vonalkod.Size = new System.Drawing.Size(59, 13);
            this.lbl_vonalkod.TabIndex = 7;
            this.lbl_vonalkod.Text = "{vonalkod}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vonalkód:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(89, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 13);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "{termeknev}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Termék név:";
            // 
            // Keszlet_Selejt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 183);
            this.Controls.Add(this.gb_result);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Keszlet_Selejt";
            this.Text = "Keszlet_Selejt";
            this.gb_result.ResumeLayout(false);
            this.gb_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox gb_result;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_vonalkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_darabszam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_selejt;
        private System.Windows.Forms.Label label3;
    }
}