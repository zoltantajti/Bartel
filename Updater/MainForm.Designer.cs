namespace Updater
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_frame_right = new System.Windows.Forms.Panel();
            this.lbl_lver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_cver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_chlog = new System.Windows.Forms.TextBox();
            this.lbl_reldt = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.p_preUpdate = new System.Windows.Forms.Panel();
            this.p_doUpdate = new System.Windows.Forms.Panel();
            this.p_postUpdate = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.pb_process = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_frame_right.SuspendLayout();
            this.p_preUpdate.SuspendLayout();
            this.p_doUpdate.SuspendLayout();
            this.p_postUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81388F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.18612F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.p_frame_right, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Updater.Properties.Resources.installer;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 349);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // p_frame_right
            // 
            this.p_frame_right.Controls.Add(this.p_postUpdate);
            this.p_frame_right.Controls.Add(this.p_doUpdate);
            this.p_frame_right.Controls.Add(this.p_preUpdate);
            this.p_frame_right.Location = new System.Drawing.Point(173, 3);
            this.p_frame_right.Name = "p_frame_right";
            this.p_frame_right.Size = new System.Drawing.Size(458, 349);
            this.p_frame_right.TabIndex = 1;
            // 
            // lbl_lver
            // 
            this.lbl_lver.AutoSize = true;
            this.lbl_lver.Location = new System.Drawing.Point(91, 49);
            this.lbl_lver.Name = "lbl_lver";
            this.lbl_lver.Size = new System.Drawing.Size(32, 13);
            this.lbl_lver.TabIndex = 4;
            this.lbl_lver.Text = "{lver}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Új verzió:";
            // 
            // lbl_cver
            // 
            this.lbl_cver.AutoSize = true;
            this.lbl_cver.Location = new System.Drawing.Point(91, 33);
            this.lbl_cver.Name = "lbl_cver";
            this.lbl_cver.Size = new System.Drawing.Size(36, 13);
            this.lbl_cver.TabIndex = 2;
            this.lbl_cver.Text = "{cver}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelenlegi verzió:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A program most frissíteni fogja a kliens szoftvert!";
            // 
            // tb_chlog
            // 
            this.tb_chlog.Location = new System.Drawing.Point(156, 30);
            this.tb_chlog.Multiline = true;
            this.tb_chlog.Name = "tb_chlog";
            this.tb_chlog.ReadOnly = true;
            this.tb_chlog.Size = new System.Drawing.Size(274, 82);
            this.tb_chlog.TabIndex = 5;
            // 
            // lbl_reldt
            // 
            this.lbl_reldt.AutoSize = true;
            this.lbl_reldt.Location = new System.Drawing.Point(3, 62);
            this.lbl_reldt.Name = "lbl_reldt";
            this.lbl_reldt.Size = new System.Drawing.Size(35, 13);
            this.lbl_reldt.TabIndex = 6;
            this.lbl_reldt.Text = "{reldt}";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(355, 118);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Frissítés";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(274, 118);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Kilépés";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // p_preUpdate
            // 
            this.p_preUpdate.Controls.Add(this.label1);
            this.p_preUpdate.Controls.Add(this.btn_exit);
            this.p_preUpdate.Controls.Add(this.label2);
            this.p_preUpdate.Controls.Add(this.btn_update);
            this.p_preUpdate.Controls.Add(this.lbl_cver);
            this.p_preUpdate.Controls.Add(this.lbl_reldt);
            this.p_preUpdate.Controls.Add(this.label4);
            this.p_preUpdate.Controls.Add(this.tb_chlog);
            this.p_preUpdate.Controls.Add(this.lbl_lver);
            this.p_preUpdate.Location = new System.Drawing.Point(3, 3);
            this.p_preUpdate.Name = "p_preUpdate";
            this.p_preUpdate.Size = new System.Drawing.Size(452, 28);
            this.p_preUpdate.TabIndex = 9;
            // 
            // p_doUpdate
            // 
            this.p_doUpdate.Controls.Add(this.pb_process);
            this.p_doUpdate.Controls.Add(this.tb_log);
            this.p_doUpdate.Controls.Add(this.label3);
            this.p_doUpdate.Location = new System.Drawing.Point(3, 36);
            this.p_doUpdate.Name = "p_doUpdate";
            this.p_doUpdate.Size = new System.Drawing.Size(452, 55);
            this.p_doUpdate.TabIndex = 10;
            // 
            // p_postUpdate
            // 
            this.p_postUpdate.Controls.Add(this.btn_close);
            this.p_postUpdate.Controls.Add(this.btn_run);
            this.p_postUpdate.Controls.Add(this.label5);
            this.p_postUpdate.Location = new System.Drawing.Point(3, 97);
            this.p_postUpdate.Name = "p_postUpdate";
            this.p_postUpdate.Size = new System.Drawing.Size(452, 243);
            this.p_postUpdate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Frissítés folyamatban...";
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(6, 20);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ReadOnly = true;
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log.Size = new System.Drawing.Size(440, 145);
            this.tb_log.TabIndex = 9;
            // 
            // pb_process
            // 
            this.pb_process.Location = new System.Drawing.Point(6, 171);
            this.pb_process.Name = "pb_process";
            this.pb_process.Size = new System.Drawing.Size(440, 23);
            this.pb_process.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "A frissítés elkészült!";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(374, 217);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "Indítás";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(293, 217);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Bezárás";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_frame_right.ResumeLayout(false);
            this.p_preUpdate.ResumeLayout(false);
            this.p_preUpdate.PerformLayout();
            this.p_doUpdate.ResumeLayout(false);
            this.p_doUpdate.PerformLayout();
            this.p_postUpdate.ResumeLayout(false);
            this.p_postUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel p_frame_right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_lver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_chlog;
        private System.Windows.Forms.Label lbl_reldt;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel p_preUpdate;
        private System.Windows.Forms.Panel p_doUpdate;
        private System.Windows.Forms.Panel p_postUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb_process;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_close;
    }
}

