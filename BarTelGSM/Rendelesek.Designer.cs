namespace BarTelGSM
{
    partial class Rendelesek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rendelesek));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_telszam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.dgv_orders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(12, 25);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_nev.TabIndex = 1;
            // 
            // tb_telszam
            // 
            this.tb_telszam.Location = new System.Drawing.Point(133, 25);
            this.tb_telszam.Name = "tb_telszam";
            this.tb_telszam.Size = new System.Drawing.Size(100, 20);
            this.tb_telszam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefonszám:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(239, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Keresés";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_showAll
            // 
            this.btn_showAll.Location = new System.Drawing.Point(320, 23);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(80, 23);
            this.btn_showAll.TabIndex = 5;
            this.btn_showAll.Text = "Mindet mutat";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // dgv_orders
            // 
            this.dgv_orders.AllowUserToAddRows = false;
            this.dgv_orders.AllowUserToDeleteRows = false;
            this.dgv_orders.AllowUserToResizeColumns = false;
            this.dgv_orders.AllowUserToResizeRows = false;
            this.dgv_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_orders.Location = new System.Drawing.Point(12, 52);
            this.dgv_orders.MultiSelect = false;
            this.dgv_orders.Name = "dgv_orders";
            this.dgv_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_orders.ShowCellErrors = false;
            this.dgv_orders.ShowCellToolTips = false;
            this.dgv_orders.ShowEditingIcon = false;
            this.dgv_orders.ShowRowErrors = false;
            this.dgv_orders.Size = new System.Drawing.Size(673, 291);
            this.dgv_orders.TabIndex = 6;
            this.dgv_orders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orders_CellDoubleClick);
            // 
            // Rendelesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 355);
            this.Controls.Add(this.dgv_orders);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_telszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rendelesek";
            this.Text = "Rendelesek";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_telszam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.DataGridView dgv_orders;
    }
}