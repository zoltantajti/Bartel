namespace BarTelGSM
{
    partial class Telefon_eladas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telefon_eladas));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_telefon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_eladasi_ar = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon:";
            // 
            // cb_telefon
            // 
            this.cb_telefon.FormattingEnabled = true;
            this.cb_telefon.Location = new System.Drawing.Point(85, 10);
            this.cb_telefon.Name = "cb_telefon";
            this.cb_telefon.Size = new System.Drawing.Size(280, 21);
            this.cb_telefon.TabIndex = 1;
            this.cb_telefon.SelectedValueChanged += new System.EventHandler(this.cb_telefon_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eladási ár:";
            // 
            // tb_eladasi_ar
            // 
            this.tb_eladasi_ar.Location = new System.Drawing.Point(85, 45);
            this.tb_eladasi_ar.Name = "tb_eladasi_ar";
            this.tb_eladasi_ar.Size = new System.Drawing.Size(280, 20);
            this.tb_eladasi_ar.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(290, 71);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(307, 97);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 13);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Mentve";
            // 
            // timer_status
            // 
            this.timer_status.Interval = 5000;
            this.timer_status.Tick += new System.EventHandler(this.status_timer_Tick);
            // 
            // Telefon_eladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 114);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_eladasi_ar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_telefon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Telefon_eladas";
            this.Text = "Telefon_eladas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_telefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_eladasi_ar;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer_status;
    }
}