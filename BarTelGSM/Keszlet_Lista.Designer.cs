namespace BarTelGSM
{
    partial class Keszlet_Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keszlet_Lista));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cb_hol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_vonalkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_termekek = new System.Windows.Forms.DataGridView();
            this.rowMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bevételezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selejtezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boltokKöztiÁtadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.árváltozásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_termekek)).BeginInit();
            this.rowMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.cb_hol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.tb_vonalkod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_nev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(522, 33);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Mindet mutat";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cb_hol
            // 
            this.cb_hol.FormattingEnabled = true;
            this.cb_hol.Items.AddRange(new object[] {
            "Kisbolt",
            "Nagybolt",
            "Mind"});
            this.cb_hol.Location = new System.Drawing.Point(314, 35);
            this.cb_hol.Name = "cb_hol";
            this.cb_hol.Size = new System.Drawing.Size(121, 21);
            this.cb_hol.TabIndex = 6;
            this.cb_hol.Text = "Mind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hol keres?";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(441, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Keresés";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_vonalkod
            // 
            this.tb_vonalkod.Location = new System.Drawing.Point(163, 36);
            this.tb_vonalkod.Name = "tb_vonalkod";
            this.tb_vonalkod.Size = new System.Drawing.Size(145, 20);
            this.tb_vonalkod.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vonalód";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(12, 36);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(145, 20);
            this.tb_nev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_termekek);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termékek";
            // 
            // dgv_termekek
            // 
            this.dgv_termekek.AllowUserToAddRows = false;
            this.dgv_termekek.AllowUserToDeleteRows = false;
            this.dgv_termekek.AllowUserToResizeColumns = false;
            this.dgv_termekek.AllowUserToResizeRows = false;
            this.dgv_termekek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_termekek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_termekek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_termekek.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_termekek.Location = new System.Drawing.Point(3, 16);
            this.dgv_termekek.MultiSelect = false;
            this.dgv_termekek.Name = "dgv_termekek";
            this.dgv_termekek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_termekek.ShowCellErrors = false;
            this.dgv_termekek.ShowCellToolTips = false;
            this.dgv_termekek.ShowEditingIcon = false;
            this.dgv_termekek.ShowRowErrors = false;
            this.dgv_termekek.Size = new System.Drawing.Size(730, 297);
            this.dgv_termekek.TabIndex = 0;
            this.dgv_termekek.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_termekek_CellMouseClick);
            // 
            // rowMenuStrip
            // 
            this.rowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eladásToolStripMenuItem,
            this.bevételezésToolStripMenuItem,
            this.selejtezésToolStripMenuItem,
            this.boltokKöztiÁtadásToolStripMenuItem,
            this.árváltozásToolStripMenuItem});
            this.rowMenuStrip.Name = "rowMenuStrip";
            this.rowMenuStrip.Size = new System.Drawing.Size(165, 114);
            // 
            // eladásToolStripMenuItem
            // 
            this.eladásToolStripMenuItem.Name = "eladásToolStripMenuItem";
            this.eladásToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eladásToolStripMenuItem.Text = "Eladás";
            this.eladásToolStripMenuItem.Click += new System.EventHandler(this.eladásToolStripMenuItem_Click);
            // 
            // bevételezésToolStripMenuItem
            // 
            this.bevételezésToolStripMenuItem.Name = "bevételezésToolStripMenuItem";
            this.bevételezésToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.bevételezésToolStripMenuItem.Text = "Bevételezés";
            this.bevételezésToolStripMenuItem.Click += new System.EventHandler(this.bevételezésToolStripMenuItem_Click);
            // 
            // selejtezésToolStripMenuItem
            // 
            this.selejtezésToolStripMenuItem.Name = "selejtezésToolStripMenuItem";
            this.selejtezésToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selejtezésToolStripMenuItem.Text = "Selejtezés";
            this.selejtezésToolStripMenuItem.Click += new System.EventHandler(this.selejtezésToolStripMenuItem_Click);
            // 
            // boltokKöztiÁtadásToolStripMenuItem
            // 
            this.boltokKöztiÁtadásToolStripMenuItem.Name = "boltokKöztiÁtadásToolStripMenuItem";
            this.boltokKöztiÁtadásToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.boltokKöztiÁtadásToolStripMenuItem.Text = "Boltok közti átadás";
            this.boltokKöztiÁtadásToolStripMenuItem.Click += new System.EventHandler(this.boltokKöztiÁtadásToolStripMenuItem_Click);
            // 
            // árváltozásToolStripMenuItem
            // 
            this.árváltozásToolStripMenuItem.Name = "árváltozásToolStripMenuItem";
            this.árváltozásToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.árváltozásToolStripMenuItem.Text = "Árváltozás";
            this.árváltozásToolStripMenuItem.Click += new System.EventHandler(this.árváltozásToolStripMenuItem_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(610, 33);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 8;
            this.btn_new.Text = "Új termék";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Keszlet_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 395);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Keszlet_Lista";
            this.Text = "Keszlet_Lista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_termekek)).EndInit();
            this.rowMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_hol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_vonalkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_termekek;
        private System.Windows.Forms.ContextMenuStrip rowMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eladásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selejtezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boltokKöztiÁtadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem árváltozásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bevételezésToolStripMenuItem;
        private System.Windows.Forms.Button btn_new;
    }
}