namespace BarTelGSM
{
    partial class Rendeles_adat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rendeles_adat));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rendelo = new System.Windows.Forms.Label();
            this.lbl_termek = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_leiras = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // lbl_rendelo
            // 
            this.lbl_rendelo.AutoSize = true;
            this.lbl_rendelo.Location = new System.Drawing.Point(73, 9);
            this.lbl_rendelo.Name = "lbl_rendelo";
            this.lbl_rendelo.Size = new System.Drawing.Size(82, 13);
            this.lbl_rendelo.TabIndex = 1;
            this.lbl_rendelo.Text = "{nev} ({telszam}";
            // 
            // lbl_termek
            // 
            this.lbl_termek.AutoSize = true;
            this.lbl_termek.Location = new System.Drawing.Point(73, 38);
            this.lbl_termek.Name = "lbl_termek";
            this.lbl_termek.Size = new System.Drawing.Size(47, 13);
            this.lbl_termek.TabIndex = 3;
            this.lbl_termek.Text = "{termek}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Termék:";
            // 
            // lbl_leiras
            // 
            this.lbl_leiras.AutoSize = true;
            this.lbl_leiras.Location = new System.Drawing.Point(73, 62);
            this.lbl_leiras.Name = "lbl_leiras";
            this.lbl_leiras.Size = new System.Drawing.Size(39, 13);
            this.lbl_leiras.TabIndex = 4;
            this.lbl_leiras.Text = "{leiras}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Státusz:";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(76, 104);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(203, 102);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Rendeles_adat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 133);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_leiras);
            this.Controls.Add(this.lbl_termek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_rendelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rendeles_adat";
            this.Text = "Rendeles_adat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_rendelo;
        private System.Windows.Forms.Label lbl_termek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_leiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_save;
    }
}