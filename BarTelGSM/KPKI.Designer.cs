namespace BarTelGSM
{
    partial class KPKI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KPKI));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mennyi = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            this.dgv_kpki = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kpki)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ki:";
            // 
            // tb_ki
            // 
            this.tb_ki.Location = new System.Drawing.Point(71, 10);
            this.tb_ki.Name = "tb_ki";
            this.tb_ki.Size = new System.Drawing.Size(280, 20);
            this.tb_ki.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mennyit:";
            // 
            // tb_mennyi
            // 
            this.tb_mennyi.Location = new System.Drawing.Point(71, 40);
            this.tb_mennyi.Name = "tb_mennyi";
            this.tb_mennyi.Size = new System.Drawing.Size(280, 20);
            this.tb_mennyi.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(357, 8);
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
            this.lbl_status.Location = new System.Drawing.Point(372, 44);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 13);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Mentve";
            // 
            // timer_status
            // 
            this.timer_status.Interval = 5000;
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick);
            // 
            // dgv_kpki
            // 
            this.dgv_kpki.AllowUserToAddRows = false;
            this.dgv_kpki.AllowUserToDeleteRows = false;
            this.dgv_kpki.AllowUserToResizeColumns = false;
            this.dgv_kpki.AllowUserToResizeRows = false;
            this.dgv_kpki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kpki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kpki.Location = new System.Drawing.Point(16, 69);
            this.dgv_kpki.Name = "dgv_kpki";
            this.dgv_kpki.Size = new System.Drawing.Size(416, 150);
            this.dgv_kpki.TabIndex = 6;
            // 
            // KPKI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 229);
            this.Controls.Add(this.dgv_kpki);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_mennyi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ki);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KPKI";
            this.Text = "KPKI";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kpki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mennyi;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer_status;
        private System.Windows.Forms.DataGridView dgv_kpki;
    }
}