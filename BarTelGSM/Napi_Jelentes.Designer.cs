namespace BarTelGSM
{
    partial class Napi_Jelentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Napi_Jelentes));
            this.gb_tEald = new System.Windows.Forms.GroupBox();
            this.dgv_tetel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.gb_telVetel = new System.Windows.Forms.GroupBox();
            this.dgv_tel_vetel = new System.Windows.Forms.DataGridView();
            this.gb_tel_elad = new System.Windows.Forms.GroupBox();
            this.dgv_telElad = new System.Windows.Forms.DataGridView();
            this.gb_szerviz = new System.Windows.Forms.GroupBox();
            this.dgv_szerviz = new System.Windows.Forms.DataGridView();
            this.gb_kpki = new System.Windows.Forms.GroupBox();
            this.dgv_kpki = new System.Windows.Forms.DataGridView();
            this.gb_sum = new System.Windows.Forms.GroupBox();
            this.lbl_kassza_ft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nyito_kassza = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_export_Excel = new System.Windows.Forms.Button();
            this.gb_tEald.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tetel)).BeginInit();
            this.gb_telVetel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel_vetel)).BeginInit();
            this.gb_tel_elad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telElad)).BeginInit();
            this.gb_szerviz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_szerviz)).BeginInit();
            this.gb_kpki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kpki)).BeginInit();
            this.gb_sum.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_tEald
            // 
            this.gb_tEald.Controls.Add(this.dgv_tetel);
            this.gb_tEald.Location = new System.Drawing.Point(12, 24);
            this.gb_tEald.Name = "gb_tEald";
            this.gb_tEald.Size = new System.Drawing.Size(244, 350);
            this.gb_tEald.TabIndex = 0;
            this.gb_tEald.TabStop = false;
            this.gb_tEald.Text = "Termék eladás:";
            // 
            // dgv_tetel
            // 
            this.dgv_tetel.AllowUserToAddRows = false;
            this.dgv_tetel.AllowUserToDeleteRows = false;
            this.dgv_tetel.AllowUserToResizeColumns = false;
            this.dgv_tetel.AllowUserToResizeRows = false;
            this.dgv_tetel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tetel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tetel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tetel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tetel.Enabled = false;
            this.dgv_tetel.Location = new System.Drawing.Point(3, 16);
            this.dgv_tetel.MultiSelect = false;
            this.dgv_tetel.Name = "dgv_tetel";
            this.dgv_tetel.ReadOnly = true;
            this.dgv_tetel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_tetel.ShowCellErrors = false;
            this.dgv_tetel.ShowCellToolTips = false;
            this.dgv_tetel.ShowEditingIcon = false;
            this.dgv_tetel.ShowRowErrors = false;
            this.dgv_tetel.Size = new System.Drawing.Size(238, 331);
            this.dgv_tetel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dátum:";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(78, 8);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(44, 13);
            this.lbl_datum.TabIndex = 2;
            this.lbl_datum.Text = "{datum}";
            // 
            // gb_telVetel
            // 
            this.gb_telVetel.Controls.Add(this.dgv_tel_vetel);
            this.gb_telVetel.Location = new System.Drawing.Point(262, 24);
            this.gb_telVetel.Name = "gb_telVetel";
            this.gb_telVetel.Size = new System.Drawing.Size(207, 93);
            this.gb_telVetel.TabIndex = 1;
            this.gb_telVetel.TabStop = false;
            this.gb_telVetel.Text = "Telefon vétel:";
            // 
            // dgv_tel_vetel
            // 
            this.dgv_tel_vetel.AllowUserToAddRows = false;
            this.dgv_tel_vetel.AllowUserToDeleteRows = false;
            this.dgv_tel_vetel.AllowUserToResizeColumns = false;
            this.dgv_tel_vetel.AllowUserToResizeRows = false;
            this.dgv_tel_vetel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tel_vetel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tel_vetel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tel_vetel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tel_vetel.Enabled = false;
            this.dgv_tel_vetel.Location = new System.Drawing.Point(3, 16);
            this.dgv_tel_vetel.MultiSelect = false;
            this.dgv_tel_vetel.Name = "dgv_tel_vetel";
            this.dgv_tel_vetel.ReadOnly = true;
            this.dgv_tel_vetel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_tel_vetel.ShowCellErrors = false;
            this.dgv_tel_vetel.ShowCellToolTips = false;
            this.dgv_tel_vetel.ShowEditingIcon = false;
            this.dgv_tel_vetel.ShowRowErrors = false;
            this.dgv_tel_vetel.Size = new System.Drawing.Size(201, 74);
            this.dgv_tel_vetel.TabIndex = 3;
            // 
            // gb_tel_elad
            // 
            this.gb_tel_elad.Controls.Add(this.dgv_telElad);
            this.gb_tel_elad.Location = new System.Drawing.Point(475, 24);
            this.gb_tel_elad.Name = "gb_tel_elad";
            this.gb_tel_elad.Size = new System.Drawing.Size(207, 90);
            this.gb_tel_elad.TabIndex = 2;
            this.gb_tel_elad.TabStop = false;
            this.gb_tel_elad.Text = "Telefon eladás:";
            // 
            // dgv_telElad
            // 
            this.dgv_telElad.AllowUserToAddRows = false;
            this.dgv_telElad.AllowUserToDeleteRows = false;
            this.dgv_telElad.AllowUserToResizeColumns = false;
            this.dgv_telElad.AllowUserToResizeRows = false;
            this.dgv_telElad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_telElad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telElad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_telElad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_telElad.Enabled = false;
            this.dgv_telElad.Location = new System.Drawing.Point(3, 16);
            this.dgv_telElad.MultiSelect = false;
            this.dgv_telElad.Name = "dgv_telElad";
            this.dgv_telElad.ReadOnly = true;
            this.dgv_telElad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_telElad.ShowCellErrors = false;
            this.dgv_telElad.ShowCellToolTips = false;
            this.dgv_telElad.ShowEditingIcon = false;
            this.dgv_telElad.ShowRowErrors = false;
            this.dgv_telElad.Size = new System.Drawing.Size(201, 71);
            this.dgv_telElad.TabIndex = 4;
            // 
            // gb_szerviz
            // 
            this.gb_szerviz.Controls.Add(this.dgv_szerviz);
            this.gb_szerviz.Location = new System.Drawing.Point(262, 123);
            this.gb_szerviz.Name = "gb_szerviz";
            this.gb_szerviz.Size = new System.Drawing.Size(207, 91);
            this.gb_szerviz.TabIndex = 2;
            this.gb_szerviz.TabStop = false;
            this.gb_szerviz.Text = "Szervíz:";
            // 
            // dgv_szerviz
            // 
            this.dgv_szerviz.AllowUserToAddRows = false;
            this.dgv_szerviz.AllowUserToDeleteRows = false;
            this.dgv_szerviz.AllowUserToResizeColumns = false;
            this.dgv_szerviz.AllowUserToResizeRows = false;
            this.dgv_szerviz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_szerviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_szerviz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_szerviz.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_szerviz.Enabled = false;
            this.dgv_szerviz.Location = new System.Drawing.Point(3, 16);
            this.dgv_szerviz.MultiSelect = false;
            this.dgv_szerviz.Name = "dgv_szerviz";
            this.dgv_szerviz.ReadOnly = true;
            this.dgv_szerviz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_szerviz.ShowCellErrors = false;
            this.dgv_szerviz.ShowCellToolTips = false;
            this.dgv_szerviz.ShowEditingIcon = false;
            this.dgv_szerviz.ShowRowErrors = false;
            this.dgv_szerviz.Size = new System.Drawing.Size(201, 72);
            this.dgv_szerviz.TabIndex = 2;
            // 
            // gb_kpki
            // 
            this.gb_kpki.Controls.Add(this.dgv_kpki);
            this.gb_kpki.Location = new System.Drawing.Point(262, 220);
            this.gb_kpki.Name = "gb_kpki";
            this.gb_kpki.Size = new System.Drawing.Size(207, 154);
            this.gb_kpki.TabIndex = 3;
            this.gb_kpki.TabStop = false;
            this.gb_kpki.Text = "KP KI:";
            // 
            // dgv_kpki
            // 
            this.dgv_kpki.AllowUserToAddRows = false;
            this.dgv_kpki.AllowUserToDeleteRows = false;
            this.dgv_kpki.AllowUserToResizeColumns = false;
            this.dgv_kpki.AllowUserToResizeRows = false;
            this.dgv_kpki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kpki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kpki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_kpki.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_kpki.Enabled = false;
            this.dgv_kpki.Location = new System.Drawing.Point(3, 16);
            this.dgv_kpki.MultiSelect = false;
            this.dgv_kpki.Name = "dgv_kpki";
            this.dgv_kpki.ReadOnly = true;
            this.dgv_kpki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_kpki.ShowCellErrors = false;
            this.dgv_kpki.ShowCellToolTips = false;
            this.dgv_kpki.ShowEditingIcon = false;
            this.dgv_kpki.ShowRowErrors = false;
            this.dgv_kpki.Size = new System.Drawing.Size(201, 135);
            this.dgv_kpki.TabIndex = 1;
            // 
            // gb_sum
            // 
            this.gb_sum.Controls.Add(this.lbl_kassza_ft);
            this.gb_sum.Controls.Add(this.label3);
            this.gb_sum.Controls.Add(this.lbl_nyito_kassza);
            this.gb_sum.Controls.Add(this.label6);
            this.gb_sum.Location = new System.Drawing.Point(475, 123);
            this.gb_sum.Name = "gb_sum";
            this.gb_sum.Size = new System.Drawing.Size(207, 197);
            this.gb_sum.TabIndex = 4;
            this.gb_sum.TabStop = false;
            this.gb_sum.Text = "Összesítés:";
            // 
            // lbl_kassza_ft
            // 
            this.lbl_kassza_ft.AutoSize = true;
            this.lbl_kassza_ft.Location = new System.Drawing.Point(82, 40);
            this.lbl_kassza_ft.Name = "lbl_kassza_ft";
            this.lbl_kassza_ft.Size = new System.Drawing.Size(24, 13);
            this.lbl_kassza_ft.TabIndex = 22;
            this.lbl_kassza_ft.Text = "{Ft}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kassza:";
            // 
            // lbl_nyito_kassza
            // 
            this.lbl_nyito_kassza.AutoSize = true;
            this.lbl_nyito_kassza.Location = new System.Drawing.Point(82, 16);
            this.lbl_nyito_kassza.Name = "lbl_nyito_kassza";
            this.lbl_nyito_kassza.Size = new System.Drawing.Size(24, 13);
            this.lbl_nyito_kassza.TabIndex = 20;
            this.lbl_nyito_kassza.Text = "{Ft}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nyitó kassza:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_export_Excel);
            this.groupBox1.Location = new System.Drawing.Point(475, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funkciók:";
            // 
            // btn_export_Excel
            // 
            this.btn_export_Excel.Enabled = false;
            this.btn_export_Excel.Location = new System.Drawing.Point(6, 19);
            this.btn_export_Excel.Name = "btn_export_Excel";
            this.btn_export_Excel.Size = new System.Drawing.Size(75, 23);
            this.btn_export_Excel.TabIndex = 0;
            this.btn_export_Excel.Text = "Excelbe";
            this.btn_export_Excel.UseVisualStyleBackColor = true;
            this.btn_export_Excel.Click += new System.EventHandler(this.btn_export_Excel_Click);
            // 
            // Napi_Jelentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_sum);
            this.Controls.Add(this.gb_kpki);
            this.Controls.Add(this.gb_szerviz);
            this.Controls.Add(this.gb_tel_elad);
            this.Controls.Add(this.gb_telVetel);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_tEald);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Napi_Jelentes";
            this.Text = "Napi_Jelentes";
            this.gb_tEald.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tetel)).EndInit();
            this.gb_telVetel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel_vetel)).EndInit();
            this.gb_tel_elad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telElad)).EndInit();
            this.gb_szerviz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_szerviz)).EndInit();
            this.gb_kpki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kpki)).EndInit();
            this.gb_sum.ResumeLayout(false);
            this.gb_sum.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_tEald;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.GroupBox gb_telVetel;
        private System.Windows.Forms.GroupBox gb_tel_elad;
        private System.Windows.Forms.GroupBox gb_szerviz;
        private System.Windows.Forms.GroupBox gb_kpki;
        private System.Windows.Forms.GroupBox gb_sum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_export_Excel;
        private System.Windows.Forms.DataGridView dgv_tetel;
        private System.Windows.Forms.DataGridView dgv_kpki;
        private System.Windows.Forms.DataGridView dgv_tel_vetel;
        private System.Windows.Forms.DataGridView dgv_telElad;
        private System.Windows.Forms.DataGridView dgv_szerviz;
        private System.Windows.Forms.Label lbl_nyito_kassza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_kassza_ft;
        private System.Windows.Forms.Label label3;
    }
}