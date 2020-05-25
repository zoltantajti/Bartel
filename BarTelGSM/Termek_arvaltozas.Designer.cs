namespace BarTelGSM
{
    partial class Termek_arvaltozas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Termek_arvaltozas));
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_ean = new System.Windows.Forms.Label();
            this.lbl_regiAr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ujAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(67, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Termék név:";
            // 
            // lbl_ean
            // 
            this.lbl_ean.AutoSize = true;
            this.lbl_ean.Location = new System.Drawing.Point(247, 9);
            this.lbl_ean.Name = "lbl_ean";
            this.lbl_ean.Size = new System.Drawing.Size(55, 13);
            this.lbl_ean.TabIndex = 1;
            this.lbl_ean.Text = "Vonalkód:";
            // 
            // lbl_regiAr
            // 
            this.lbl_regiAr.AutoSize = true;
            this.lbl_regiAr.Location = new System.Drawing.Point(12, 33);
            this.lbl_regiAr.Name = "lbl_regiAr";
            this.lbl_regiAr.Size = new System.Drawing.Size(44, 13);
            this.lbl_regiAr.TabIndex = 2;
            this.lbl_regiAr.Text = "Régi ár:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Új ár:";
            // 
            // tb_ujAr
            // 
            this.tb_ujAr.Location = new System.Drawing.Point(50, 56);
            this.tb_ujAr.Name = "tb_ujAr";
            this.tb_ujAr.Size = new System.Drawing.Size(103, 20);
            this.tb_ujAr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ft";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(181, 54);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(262, 54);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Mégse";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Termek_arvaltozas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 92);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ujAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_regiAr);
            this.Controls.Add(this.lbl_ean);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Termek_arvaltozas";
            this.Text = "Termek_arvaltozas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_ean;
        private System.Windows.Forms.Label lbl_regiAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ujAr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}