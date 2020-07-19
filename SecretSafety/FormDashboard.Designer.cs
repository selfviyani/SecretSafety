namespace SecretSafety
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.list_passwords = new System.Windows.Forms.ListView();
            this.col_site = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col__note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_new_passwd = new System.Windows.Forms.TextBox();
            this.bn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 46);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Secret Safety";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bt_search
            // 
            this.bt_search.Image = ((System.Drawing.Image)(resources.GetObject("bt_search.Image")));
            this.bt_search.Location = new System.Drawing.Point(41, 390);
            this.bt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(84, 64);
            this.bt_search.TabIndex = 3;
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Image = ((System.Drawing.Image)(resources.GetObject("bt_add.Image")));
            this.bt_add.Location = new System.Drawing.Point(171, 390);
            this.bt_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(84, 63);
            this.bt_add.TabIndex = 4;
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(600, 10);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(36, 27);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.Text = "X";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // list_passwords
            // 
            this.list_passwords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_site,
            this.col_password,
            this.col__note});
            this.list_passwords.FullRowSelect = true;
            this.list_passwords.GridLines = true;
            this.list_passwords.HideSelection = false;
            this.list_passwords.Location = new System.Drawing.Point(292, 129);
            this.list_passwords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_passwords.Name = "list_passwords";
            this.list_passwords.Size = new System.Drawing.Size(316, 303);
            this.list_passwords.TabIndex = 8;
            this.list_passwords.UseCompatibleStateImageBehavior = false;
            this.list_passwords.View = System.Windows.Forms.View.Details;
            this.list_passwords.SelectedIndexChanged += new System.EventHandler(this.list_passwords_SelectedIndexChanged);
            // 
            // col_site
            // 
            this.col_site.Text = "Site";
            // 
            // col_password
            // 
            this.col_password.Text = "Password";
            // 
            // col__note
            // 
            this.col__note.Text = "Note";
            // 
            // tb_new_passwd
            // 
            this.tb_new_passwd.Location = new System.Drawing.Point(41, 336);
            this.tb_new_passwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_new_passwd.Name = "tb_new_passwd";
            this.tb_new_passwd.Size = new System.Drawing.Size(132, 22);
            this.tb_new_passwd.TabIndex = 9;
            // 
            // bn_save
            // 
            this.bn_save.Location = new System.Drawing.Point(194, 336);
            this.bn_save.Name = "bn_save";
            this.bn_save.Size = new System.Drawing.Size(75, 23);
            this.bn_save.TabIndex = 10;
            this.bn_save.Text = "Save";
            this.bn_save.UseVisualStyleBackColor = true;
            this.bn_save.Click += new System.EventHandler(this.bn_save_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 495);
            this.Controls.Add(this.bn_save);
            this.Controls.Add(this.tb_new_passwd);
            this.Controls.Add(this.list_passwords);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.ListView list_passwords;
        private System.Windows.Forms.ColumnHeader col_site;
        private System.Windows.Forms.ColumnHeader col_password;
        private System.Windows.Forms.ColumnHeader col__note;
        private System.Windows.Forms.TextBox tb_new_passwd;
        private System.Windows.Forms.Button bn_save;
    }
}