namespace BarTelGSM
{
    partial class Keszlet_keres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keszlet_keres));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_ean = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rowMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selejtezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eladásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.rowMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tétel neve";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(12, 25);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(174, 20);
            this.tb_nev.TabIndex = 1;
            // 
            // tb_ean
            // 
            this.tb_ean.Location = new System.Drawing.Point(204, 25);
            this.tb_ean.Name = "tb_ean";
            this.tb_ean.Size = new System.Drawing.Size(174, 20);
            this.tb_ean.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vonalkód";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(384, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Keresés";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.AllowUserToResizeColumns = false;
            this.dgv_result.AllowUserToResizeRows = false;
            this.dgv_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_result.Location = new System.Drawing.Point(12, 51);
            this.dgv_result.MultiSelect = false;
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_result.ShowCellErrors = false;
            this.dgv_result.ShowCellToolTips = false;
            this.dgv_result.ShowEditingIcon = false;
            this.dgv_result.ShowRowErrors = false;
            this.dgv_result.Size = new System.Drawing.Size(696, 187);
            this.dgv_result.TabIndex = 5;
            this.dgv_result.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_result_CellDoubleClick);
            this.dgv_result.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_result_CellMouseClick);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(633, 244);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Mégse";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rowMenuStrip
            // 
            this.rowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selejtezésToolStripMenuItem,
            this.eladásToolStripMenuItem});
            this.rowMenuStrip.Name = "rowMenuStrip";
            this.rowMenuStrip.Size = new System.Drawing.Size(124, 48);
            this.rowMenuStrip.Text = "Menü";
            // 
            // selejtezésToolStripMenuItem
            // 
            this.selejtezésToolStripMenuItem.Name = "selejtezésToolStripMenuItem";
            this.selejtezésToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.selejtezésToolStripMenuItem.Text = "Selejtezés";
            this.selejtezésToolStripMenuItem.Click += new System.EventHandler(this.selejtezésToolStripMenuItem_Click);
            // 
            // eladásToolStripMenuItem
            // 
            this.eladásToolStripMenuItem.Name = "eladásToolStripMenuItem";
            this.eladásToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.eladásToolStripMenuItem.Text = "Eladás";
            this.eladásToolStripMenuItem.Click += new System.EventHandler(this.eladásToolStripMenuItem_Click);
            // 
            // Keszlet_keres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 279);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dgv_result);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_ean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Keszlet_keres";
            this.Text = "Keszlet_keres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.rowMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_ean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ContextMenuStrip rowMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selejtezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eladásToolStripMenuItem;
    }
}