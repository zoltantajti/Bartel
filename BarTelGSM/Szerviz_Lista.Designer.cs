namespace BarTelGSM
{
    partial class Szerviz_Lista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_telszam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(13, 20);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_nev.TabIndex = 2;
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(134, 20);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(100, 20);
            this.tb_tipus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Típus:";
            // 
            // tb_telszam
            // 
            this.tb_telszam.Location = new System.Drawing.Point(251, 20);
            this.tb_telszam.Name = "tb_telszam";
            this.tb_telszam.Size = new System.Drawing.Size(100, 20);
            this.tb_telszam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefonszám:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(357, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Keresés";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_showAll
            // 
            this.btn_showAll.Location = new System.Drawing.Point(438, 18);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(84, 23);
            this.btn_showAll.TabIndex = 8;
            this.btn_showAll.Text = "Mindet mutat";
            this.btn_showAll.UseVisualStyleBackColor = true;
            // 
            // Szerviz_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 287);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_telszam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Szerviz_Lista";
            this.Text = "Szerviz_Lista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_telszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_showAll;
    }
}