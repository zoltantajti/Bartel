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
            this.gb_fncs = new System.Windows.Forms.GroupBox();
            this.btn_export_Excel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_bolt = new System.Windows.Forms.Label();
            this.p_loading = new System.Windows.Forms.Panel();
            this.lbl_process = new System.Windows.Forms.Label();
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
            this.gb_fncs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_tEald
            // 
            this.gb_tEald.Controls.Add(this.dgv_tetel);
            this.gb_tEald.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_tEald.Location = new System.Drawing.Point(0, 0);
            this.gb_tEald.Name = "gb_tEald";
            this.gb_tEald.Size = new System.Drawing.Size(256, 375);
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
            this.dgv_tetel.Size = new System.Drawing.Size(250, 356);
            this.dgv_tetel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dátum:";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(68, 6);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(44, 13);
            this.lbl_datum.TabIndex = 2;
            this.lbl_datum.Text = "{datum}";
            // 
            // gb_telVetel
            // 
            this.gb_telVetel.Controls.Add(this.dgv_tel_vetel);
            this.gb_telVetel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_telVetel.Location = new System.Drawing.Point(0, 0);
            this.gb_telVetel.Name = "gb_telVetel";
            this.gb_telVetel.Size = new System.Drawing.Size(239, 190);
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
            this.dgv_tel_vetel.Size = new System.Drawing.Size(233, 171);
            this.dgv_tel_vetel.TabIndex = 3;
            // 
            // gb_tel_elad
            // 
            this.gb_tel_elad.Controls.Add(this.dgv_telElad);
            this.gb_tel_elad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_tel_elad.Location = new System.Drawing.Point(0, 209);
            this.gb_tel_elad.Name = "gb_tel_elad";
            this.gb_tel_elad.Size = new System.Drawing.Size(239, 166);
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
            this.dgv_telElad.Size = new System.Drawing.Size(233, 147);
            this.dgv_telElad.TabIndex = 4;
            // 
            // gb_szerviz
            // 
            this.gb_szerviz.Controls.Add(this.dgv_szerviz);
            this.gb_szerviz.Dock = System.Windows.Forms.DockStyle.Top;
            this.gb_szerviz.Location = new System.Drawing.Point(0, 0);
            this.gb_szerviz.Name = "gb_szerviz";
            this.gb_szerviz.Size = new System.Drawing.Size(237, 115);
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
            this.dgv_szerviz.Size = new System.Drawing.Size(231, 96);
            this.dgv_szerviz.TabIndex = 2;
            // 
            // gb_kpki
            // 
            this.gb_kpki.Controls.Add(this.dgv_kpki);
            this.gb_kpki.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_kpki.Location = new System.Drawing.Point(0, 131);
            this.gb_kpki.Name = "gb_kpki";
            this.gb_kpki.Size = new System.Drawing.Size(237, 109);
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
            this.dgv_kpki.Size = new System.Drawing.Size(231, 90);
            this.dgv_kpki.TabIndex = 1;
            // 
            // gb_sum
            // 
            this.gb_sum.Controls.Add(this.lbl_kassza_ft);
            this.gb_sum.Controls.Add(this.label3);
            this.gb_sum.Controls.Add(this.lbl_nyito_kassza);
            this.gb_sum.Controls.Add(this.label6);
            this.gb_sum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_sum.Location = new System.Drawing.Point(0, 240);
            this.gb_sum.Name = "gb_sum";
            this.gb_sum.Size = new System.Drawing.Size(237, 87);
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
            // gb_fncs
            // 
            this.gb_fncs.Controls.Add(this.btn_export_Excel);
            this.gb_fncs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_fncs.Location = new System.Drawing.Point(0, 327);
            this.gb_fncs.Name = "gb_fncs";
            this.gb_fncs.Size = new System.Drawing.Size(237, 48);
            this.gb_fncs.TabIndex = 3;
            this.gb_fncs.TabStop = false;
            this.gb_fncs.Text = "Funkciók:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_process);
            this.panel1.Controls.Add(this.lbl_bolt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_datum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 24);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gb_tEald);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 375);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gb_telVetel);
            this.panel3.Controls.Add(this.gb_tel_elad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(256, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 375);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gb_szerviz);
            this.panel4.Controls.Add(this.gb_kpki);
            this.panel4.Controls.Add(this.gb_sum);
            this.panel4.Controls.Add(this.gb_fncs);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(496, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 375);
            this.panel4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bolt:";
            // 
            // lbl_bolt
            // 
            this.lbl_bolt.AutoSize = true;
            this.lbl_bolt.Location = new System.Drawing.Point(380, 6);
            this.lbl_bolt.Name = "lbl_bolt";
            this.lbl_bolt.Size = new System.Drawing.Size(32, 13);
            this.lbl_bolt.TabIndex = 4;
            this.lbl_bolt.Text = "{bolt}";
            // 
            // p_loading
            // 
            this.p_loading.Location = new System.Drawing.Point(441, 24);
            this.p_loading.Name = "p_loading";
            this.p_loading.Size = new System.Drawing.Size(260, 240);
            this.p_loading.TabIndex = 9;
            // 
            // lbl_process
            // 
            this.lbl_process.AutoSize = true;
            this.lbl_process.Location = new System.Drawing.Point(613, 6);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(108, 13);
            this.lbl_process.TabIndex = 0;
            this.lbl_process.Text = "Betöltés folyamatban!";
            // 
            // Napi_Jelentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 399);
            this.Controls.Add(this.p_loading);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.gb_fncs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox gb_fncs;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_bolt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel p_loading;
        private System.Windows.Forms.Label lbl_process;
    }
}