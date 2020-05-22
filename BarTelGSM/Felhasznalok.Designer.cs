namespace BarTelGSM
{
    partial class Felhasznalok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Felhasznalok));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delUser = new System.Windows.Forms.Button();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.cb_ranks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_passwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delUser);
            this.groupBox1.Controls.Add(this.btn_newUser);
            this.groupBox1.Controls.Add(this.cb_ranks);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_passwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új felhasználó";
            // 
            // btn_delUser
            // 
            this.btn_delUser.Location = new System.Drawing.Point(351, 13);
            this.btn_delUser.Name = "btn_delUser";
            this.btn_delUser.Size = new System.Drawing.Size(75, 23);
            this.btn_delUser.TabIndex = 7;
            this.btn_delUser.Text = "Törlés";
            this.btn_delUser.UseVisualStyleBackColor = true;
            this.btn_delUser.Click += new System.EventHandler(this.btn_delUser_Click);
            // 
            // btn_newUser
            // 
            this.btn_newUser.Location = new System.Drawing.Point(351, 42);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(75, 23);
            this.btn_newUser.TabIndex = 6;
            this.btn_newUser.Text = "Mentés";
            this.btn_newUser.UseVisualStyleBackColor = true;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // cb_ranks
            // 
            this.cb_ranks.FormattingEnabled = true;
            this.cb_ranks.Location = new System.Drawing.Point(224, 31);
            this.cb_ranks.Name = "cb_ranks";
            this.cb_ranks.Size = new System.Drawing.Size(121, 21);
            this.cb_ranks.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jogosultság";
            // 
            // tb_passwd
            // 
            this.tb_passwd.Location = new System.Drawing.Point(118, 32);
            this.tb_passwd.Name = "tb_passwd";
            this.tb_passwd.PasswordChar = '*';
            this.tb_passwd.Size = new System.Drawing.Size(100, 20);
            this.tb_passwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(12, 32);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 20);
            this.tb_user.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_users);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Felhasználók";
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.AllowUserToResizeColumns = false;
            this.dgv_users.AllowUserToResizeRows = false;
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_users.Location = new System.Drawing.Point(3, 16);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.ShowCellErrors = false;
            this.dgv_users.ShowCellToolTips = false;
            this.dgv_users.ShowEditingIcon = false;
            this.dgv_users.ShowRowErrors = false;
            this.dgv_users.Size = new System.Drawing.Size(437, 246);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellDoubleClick);
            // 
            // Felhasznalok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 336);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Felhasznalok";
            this.Text = "Felhasznalok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_newUser;
        private System.Windows.Forms.ComboBox cb_ranks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_passwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Button btn_delUser;
    }
}