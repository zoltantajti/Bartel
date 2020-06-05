namespace BarTelGSM
{
    partial class Tetel_elad_uj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetel_elad_uj));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tetelnev = new System.Windows.Forms.TextBox();
            this.tb_vonalkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tetelar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_darab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_toList = new System.Windows.Forms.Button();
            this.dgv_lista = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.darab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_keres = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_vegosszeg = new System.Windows.Forms.Label();
            this.cms_termek = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eltávolításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mégseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).BeginInit();
            this.cms_termek.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terméknév:";
            // 
            // tb_tetelnev
            // 
            this.tb_tetelnev.Location = new System.Drawing.Point(12, 25);
            this.tb_tetelnev.Name = "tb_tetelnev";
            this.tb_tetelnev.Size = new System.Drawing.Size(148, 20);
            this.tb_tetelnev.TabIndex = 1;
            // 
            // tb_vonalkod
            // 
            this.tb_vonalkod.Location = new System.Drawing.Point(166, 25);
            this.tb_vonalkod.Name = "tb_vonalkod";
            this.tb_vonalkod.Size = new System.Drawing.Size(148, 20);
            this.tb_vonalkod.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vonalkód:";
            // 
            // tb_tetelar
            // 
            this.tb_tetelar.Location = new System.Drawing.Point(320, 25);
            this.tb_tetelar.Name = "tb_tetelar";
            this.tb_tetelar.Size = new System.Drawing.Size(88, 20);
            this.tb_tetelar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Termékár:";
            // 
            // tb_darab
            // 
            this.tb_darab.Location = new System.Drawing.Point(414, 25);
            this.tb_darab.Name = "tb_darab";
            this.tb_darab.Size = new System.Drawing.Size(88, 20);
            this.tb_darab.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Darabszám:";
            // 
            // btn_toList
            // 
            this.btn_toList.Location = new System.Drawing.Point(508, 51);
            this.btn_toList.Name = "btn_toList";
            this.btn_toList.Size = new System.Drawing.Size(75, 23);
            this.btn_toList.TabIndex = 8;
            this.btn_toList.Text = "Listára";
            this.btn_toList.UseVisualStyleBackColor = true;
            this.btn_toList.Click += new System.EventHandler(this.btn_toList_Click);
            // 
            // dgv_lista
            // 
            this.dgv_lista.AllowUserToAddRows = false;
            this.dgv_lista.AllowUserToDeleteRows = false;
            this.dgv_lista.AllowUserToResizeColumns = false;
            this.dgv_lista.AllowUserToResizeRows = false;
            this.dgv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.ean,
            this.price,
            this.darab,
            this.ar});
            this.dgv_lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_lista.Location = new System.Drawing.Point(12, 80);
            this.dgv_lista.MultiSelect = false;
            this.dgv_lista.Name = "dgv_lista";
            this.dgv_lista.ReadOnly = true;
            this.dgv_lista.ShowCellErrors = false;
            this.dgv_lista.ShowCellToolTips = false;
            this.dgv_lista.ShowEditingIcon = false;
            this.dgv_lista.ShowRowErrors = false;
            this.dgv_lista.Size = new System.Drawing.Size(571, 269);
            this.dgv_lista.TabIndex = 9;
            this.dgv_lista.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_lista_CellMouseDown);
            // 
            // name
            // 
            this.name.HeaderText = "Terméknév";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // ean
            // 
            this.ean.HeaderText = "Vonalkód";
            this.ean.Name = "ean";
            this.ean.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Egységár";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // darab
            // 
            this.darab.HeaderText = "Darab";
            this.darab.Name = "darab";
            this.darab.ReadOnly = true;
            // 
            // ar
            // 
            this.ar.HeaderText = "Ára";
            this.ar.Name = "ar";
            this.ar.ReadOnly = true;
            // 
            // btn_sale
            // 
            this.btn_sale.Location = new System.Drawing.Point(508, 355);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(75, 23);
            this.btn_sale.TabIndex = 10;
            this.btn_sale.Text = "Elad";
            this.btn_sale.UseVisualStyleBackColor = true;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // btn_keres
            // 
            this.btn_keres.Location = new System.Drawing.Point(508, 24);
            this.btn_keres.Name = "btn_keres";
            this.btn_keres.Size = new System.Drawing.Size(75, 23);
            this.btn_keres.TabIndex = 11;
            this.btn_keres.Text = "Keresés";
            this.btn_keres.UseVisualStyleBackColor = true;
            this.btn_keres.Click += new System.EventHandler(this.btn_keres_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Végösszeg:";
            // 
            // lbl_vegosszeg
            // 
            this.lbl_vegosszeg.AutoSize = true;
            this.lbl_vegosszeg.Location = new System.Drawing.Point(447, 360);
            this.lbl_vegosszeg.Name = "lbl_vegosszeg";
            this.lbl_vegosszeg.Size = new System.Drawing.Size(25, 13);
            this.lbl_vegosszeg.TabIndex = 13;
            this.lbl_vegosszeg.Text = "0 Ft";
            // 
            // cms_termek
            // 
            this.cms_termek.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eltávolításToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.mégseToolStripMenuItem});
            this.cms_termek.Name = "cms_termek";
            this.cms_termek.Size = new System.Drawing.Size(124, 70);
            // 
            // eltávolításToolStripMenuItem
            // 
            this.eltávolításToolStripMenuItem.Name = "eltávolításToolStripMenuItem";
            this.eltávolításToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.eltávolításToolStripMenuItem.Text = "Eltávolítás";
            this.eltávolításToolStripMenuItem.Click += new System.EventHandler(this.eltávolításToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // mégseToolStripMenuItem
            // 
            this.mégseToolStripMenuItem.Name = "mégseToolStripMenuItem";
            this.mégseToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mégseToolStripMenuItem.Text = "Mégse";
            this.mégseToolStripMenuItem.Click += new System.EventHandler(this.mégseToolStripMenuItem_Click);
            // 
            // Tetel_elad_uj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 380);
            this.Controls.Add(this.lbl_vegosszeg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_keres);
            this.Controls.Add(this.btn_sale);
            this.Controls.Add(this.dgv_lista);
            this.Controls.Add(this.btn_toList);
            this.Controls.Add(this.tb_darab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tetelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_vonalkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tetelnev);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tetel_elad_uj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetel_elad_uj";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lista)).EndInit();
            this.cms_termek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_toList;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.Button btn_keres;
        public System.Windows.Forms.TextBox tb_tetelnev;
        public System.Windows.Forms.TextBox tb_vonalkod;
        public System.Windows.Forms.TextBox tb_tetelar;
        public System.Windows.Forms.TextBox tb_darab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_vegosszeg;
        private System.Windows.Forms.DataGridView dgv_lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ean;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn darab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.ContextMenuStrip cms_termek;
        private System.Windows.Forms.ToolStripMenuItem eltávolításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mégseToolStripMenuItem;
    }
}