namespace Bai04
{
    partial class Main
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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.From = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datatime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.portsmtptbx = new System.Windows.Forms.NumericUpDown();
            this.portimaptbx = new System.Windows.Forms.NumericUpDown();
            this.imaptbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.smtptbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.passwordtbx = new System.Windows.Forms.TextBox();
            this.emailtbx = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portsmtptbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portimaptbx)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Email,
            this.From,
            this.Datatime});
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Email";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 189);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(920, 499);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 236;
            // 
            // From
            // 
            this.From.Text = "From";
            this.From.Width = 215;
            // 
            // Datatime
            // 
            this.Datatime.Text = "Thời gian";
            this.Datatime.Width = 363;
            // 
            // portsmtptbx
            // 
            this.portsmtptbx.Location = new System.Drawing.Point(740, 86);
            this.portsmtptbx.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.portsmtptbx.Name = "portsmtptbx";
            this.portsmtptbx.Size = new System.Drawing.Size(175, 26);
            this.portsmtptbx.TabIndex = 32;
            this.portsmtptbx.Value = new decimal(new int[] {
            587,
            0,
            0,
            0});
            // 
            // portimaptbx
            // 
            this.portimaptbx.Location = new System.Drawing.Point(472, 86);
            this.portimaptbx.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.portimaptbx.Name = "portimaptbx";
            this.portimaptbx.Size = new System.Drawing.Size(175, 26);
            this.portimaptbx.TabIndex = 31;
            this.portimaptbx.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // imaptbx
            // 
            this.imaptbx.Location = new System.Drawing.Point(472, 35);
            this.imaptbx.Multiline = true;
            this.imaptbx.Name = "imaptbx";
            this.imaptbx.Size = new System.Drawing.Size(175, 26);
            this.imaptbx.TabIndex = 30;
            this.imaptbx.Text = "imap.gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "IMAP";
            // 
            // smtptbx
            // 
            this.smtptbx.Location = new System.Drawing.Point(740, 35);
            this.smtptbx.Multiline = true;
            this.smtptbx.Name = "smtptbx";
            this.smtptbx.Size = new System.Drawing.Size(175, 26);
            this.smtptbx.TabIndex = 27;
            this.smtptbx.Text = "smtp.gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "SMTP";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(42, 130);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(112, 36);
            this.SendButton.TabIndex = 39;
            this.SendButton.Text = "Send Mail";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Visible = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(160, 130);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(112, 36);
            this.RefreshButton.TabIndex = 38;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Visible = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // passwordtbx
            // 
            this.passwordtbx.Location = new System.Drawing.Point(131, 85);
            this.passwordtbx.Multiline = true;
            this.passwordtbx.Name = "passwordtbx";
            this.passwordtbx.PasswordChar = '*';
            this.passwordtbx.Size = new System.Drawing.Size(256, 26);
            this.passwordtbx.TabIndex = 37;
            this.passwordtbx.Text = "fkixjpdhqgriplrv";
            // 
            // emailtbx
            // 
            this.emailtbx.Location = new System.Drawing.Point(131, 35);
            this.emailtbx.Multiline = true;
            this.emailtbx.Name = "emailtbx";
            this.emailtbx.Size = new System.Drawing.Size(256, 26);
            this.emailtbx.TabIndex = 36;
            this.emailtbx.Text = "vansonnguyen220905@gmail.com";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(276, 130);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(112, 36);
            this.LoginButton.TabIndex = 35;
            this.LoginButton.Text = "Đăng nhập";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Account";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(950, 704);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.passwordtbx);
            this.Controls.Add(this.emailtbx);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.portsmtptbx);
            this.Controls.Add(this.portimaptbx);
            this.Controls.Add(this.imaptbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.smtptbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portsmtptbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portimaptbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader From;
        private System.Windows.Forms.ColumnHeader Datatime;
        private System.Windows.Forms.NumericUpDown portsmtptbx;
        private System.Windows.Forms.NumericUpDown portimaptbx;
        private System.Windows.Forms.TextBox imaptbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox smtptbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox passwordtbx;
        private System.Windows.Forms.TextBox emailtbx;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

