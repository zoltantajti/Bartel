namespace BarTelGSM
{
    partial class Telefon_vetel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telefon_vetel));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.tb_besz_ar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_terv_elad_ar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon típusa:";
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(133, 10);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(216, 20);
            this.tb_tipus.TabIndex = 1;
            // 
            // tb_besz_ar
            // 
            this.tb_besz_ar.Location = new System.Drawing.Point(133, 36);
            this.tb_besz_ar.Name = "tb_besz_ar";
            this.tb_besz_ar.Size = new System.Drawing.Size(216, 20);
            this.tb_besz_ar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beszerzési ár:";
            // 
            // tb_terv_elad_ar
            // 
            this.tb_terv_elad_ar.Location = new System.Drawing.Point(133, 62);
            this.tb_terv_elad_ar.Name = "tb_terv_elad_ar";
            this.tb_terv_elad_ar.Size = new System.Drawing.Size(216, 20);
            this.tb_terv_elad_ar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tervezett eladási ár:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(274, 88);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(293, 115);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 13);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Mentve";
            // 
            // timer_status
            // 
            this.timer_status.Interval = 5000;
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick);
            // 
            // Telefon_vetel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 131);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_terv_elad_ar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_besz_ar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Telefon_vetel";
            this.Text = "Telefon_vetel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.TextBox tb_besz_ar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_terv_elad_ar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer_status;
    }
}