namespace BarTelGSM
{
    partial class Keszlet_Transzfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keszlet_Transzfer));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_termeknev = new System.Windows.Forms.Label();
            this.lbl_ean = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_from = new System.Windows.Forms.ComboBox();
            this.cb_to = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_darab = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék:";
            // 
            // lbl_termeknev
            // 
            this.lbl_termeknev.AutoSize = true;
            this.lbl_termeknev.Location = new System.Drawing.Point(73, 9);
            this.lbl_termeknev.Name = "lbl_termeknev";
            this.lbl_termeknev.Size = new System.Drawing.Size(65, 13);
            this.lbl_termeknev.TabIndex = 1;
            this.lbl_termeknev.Text = "{termeknev}";
            // 
            // lbl_ean
            // 
            this.lbl_ean.AutoSize = true;
            this.lbl_ean.Location = new System.Drawing.Point(73, 31);
            this.lbl_ean.Name = "lbl_ean";
            this.lbl_ean.Size = new System.Drawing.Size(59, 13);
            this.lbl_ean.TabIndex = 3;
            this.lbl_ean.Text = "{vonalkod}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vonalkód:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Melyik boltból?";
            // 
            // cb_from
            // 
            this.cb_from.AutoCompleteCustomSource.AddRange(new string[] {
            "Kisbolt",
            "Nagybolt"});
            this.cb_from.FormattingEnabled = true;
            this.cb_from.Location = new System.Drawing.Point(95, 65);
            this.cb_from.Name = "cb_from";
            this.cb_from.Size = new System.Drawing.Size(121, 21);
            this.cb_from.TabIndex = 5;
            // 
            // cb_to
            // 
            this.cb_to.AutoCompleteCustomSource.AddRange(new string[] {
            "Kisbolt",
            "Nagybolt"});
            this.cb_to.FormattingEnabled = true;
            this.cb_to.Location = new System.Drawing.Point(95, 95);
            this.cb_to.Name = "cb_to";
            this.cb_to.Size = new System.Drawing.Size(121, 21);
            this.cb_to.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Melyik boltba?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hány darabot?";
            // 
            // tb_darab
            // 
            this.tb_darab.Location = new System.Drawing.Point(95, 127);
            this.tb_darab.Name = "tb_darab";
            this.tb_darab.Size = new System.Drawing.Size(121, 20);
            this.tb_darab.TabIndex = 9;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(141, 153);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 10;
            this.btn_send.Text = "Átad";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Keszlet_Transzfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 183);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_darab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_to);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_from);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_termeknev);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Keszlet_Transzfer";
            this.Text = "Keszlet_Transzfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_termeknev;
        private System.Windows.Forms.Label lbl_ean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_from;
        private System.Windows.Forms.ComboBox cb_to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_darab;
        private System.Windows.Forms.Button btn_send;
    }
}