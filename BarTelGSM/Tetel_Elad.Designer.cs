namespace BarTelGSM
{
    partial class Tetel_Elad
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tetelnev = new System.Windows.Forms.TextBox();
            this.tb_tetelar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_elad = new System.Windows.Forms.Button();
            this.timer_kiir = new System.Windows.Forms.Timer(this.components);
            this.lbl_status = new System.Windows.Forms.Label();
            this.dgv_napiElad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_napiElad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tétel neve:";
            // 
            // tb_tetelnev
            // 
            this.tb_tetelnev.Location = new System.Drawing.Point(80, 10);
            this.tb_tetelnev.Name = "tb_tetelnev";
            this.tb_tetelnev.Size = new System.Drawing.Size(198, 20);
            this.tb_tetelnev.TabIndex = 1;
            // 
            // tb_tetelar
            // 
            this.tb_tetelar.Location = new System.Drawing.Point(80, 36);
            this.tb_tetelar.Name = "tb_tetelar";
            this.tb_tetelar.Size = new System.Drawing.Size(198, 20);
            this.tb_tetelar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tétel ára:";
            // 
            // btn_elad
            // 
            this.btn_elad.Location = new System.Drawing.Point(284, 9);
            this.btn_elad.Name = "btn_elad";
            this.btn_elad.Size = new System.Drawing.Size(75, 23);
            this.btn_elad.TabIndex = 4;
            this.btn_elad.Text = "Elad";
            this.btn_elad.UseVisualStyleBackColor = true;
            this.btn_elad.Click += new System.EventHandler(this.btn_elad_Click);
            // 
            // timer_kiir
            // 
            this.timer_kiir.Interval = 5000;
            this.timer_kiir.Tick += new System.EventHandler(this.timer_kiir_Tick);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(285, 42);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(84, 13);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "Eladás rögzítve!";
            // 
            // dgv_napiElad
            // 
            this.dgv_napiElad.AllowUserToAddRows = false;
            this.dgv_napiElad.AllowUserToDeleteRows = false;
            this.dgv_napiElad.AllowUserToResizeColumns = false;
            this.dgv_napiElad.AllowUserToResizeRows = false;
            this.dgv_napiElad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_napiElad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_napiElad.Location = new System.Drawing.Point(16, 70);
            this.dgv_napiElad.Name = "dgv_napiElad";
            this.dgv_napiElad.Size = new System.Drawing.Size(495, 222);
            this.dgv_napiElad.TabIndex = 6;
            // 
            // Tetel_Elad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 304);
            this.Controls.Add(this.dgv_napiElad);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_elad);
            this.Controls.Add(this.tb_tetelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tetelnev);
            this.Controls.Add(this.label1);
            this.Name = "Tetel_Elad";
            this.Text = "Tétel eladás | Bar-Tel GSM";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_napiElad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tetelnev;
        private System.Windows.Forms.TextBox tb_tetelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_elad;
        private System.Windows.Forms.Timer timer_kiir;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.DataGridView dgv_napiElad;
    }
}