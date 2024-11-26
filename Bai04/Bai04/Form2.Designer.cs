namespace Bai04
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.totbx = new System.Windows.Forms.TextBox();
            this.fromtbx = new System.Windows.Forms.TextBox();
            this.subjecttbx = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.filePathtbx = new System.Windows.Forms.TextBox();
            this.bodytbx = new System.Windows.Forms.RichTextBox();
            this.HTML = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 36;
            this.label4.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "From: ";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(397, 243);
            this.a.Multiline = true;
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(16, 10);
            this.a.TabIndex = 39;
            // 
            // totbx
            // 
            this.totbx.Location = new System.Drawing.Point(116, 65);
            this.totbx.Multiline = true;
            this.totbx.Name = "totbx";
            this.totbx.Size = new System.Drawing.Size(428, 26);
            this.totbx.TabIndex = 40;
            this.totbx.Text = "23521357@gm.uit.edu.vn";
            // 
            // fromtbx
            // 
            this.fromtbx.Location = new System.Drawing.Point(116, 26);
            this.fromtbx.Multiline = true;
            this.fromtbx.Name = "fromtbx";
            this.fromtbx.Size = new System.Drawing.Size(428, 26);
            this.fromtbx.TabIndex = 41;
            this.fromtbx.TextChanged += new System.EventHandler(this.fromtbx_TextChanged);
            // 
            // subjecttbx
            // 
            this.subjecttbx.Location = new System.Drawing.Point(116, 107);
            this.subjecttbx.Multiline = true;
            this.subjecttbx.Name = "subjecttbx";
            this.subjecttbx.Size = new System.Drawing.Size(428, 26);
            this.subjecttbx.TabIndex = 42;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(438, 604);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(106, 35);
            this.SendButton.TabIndex = 43;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 45;
            this.button2.Text = "Browse... ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(22, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "Attachment:";
            // 
            // filePathtbx
            // 
            this.filePathtbx.Location = new System.Drawing.Point(133, 567);
            this.filePathtbx.Multiline = true;
            this.filePathtbx.Name = "filePathtbx";
            this.filePathtbx.Size = new System.Drawing.Size(299, 26);
            this.filePathtbx.TabIndex = 47;
            // 
            // bodytbx
            // 
            this.bodytbx.Location = new System.Drawing.Point(116, 187);
            this.bodytbx.Name = "bodytbx";
            this.bodytbx.Size = new System.Drawing.Size(428, 352);
            this.bodytbx.TabIndex = 48;
            this.bodytbx.Text = "";
            // 
            // HTML
            // 
            this.HTML.AutoSize = true;
            this.HTML.Location = new System.Drawing.Point(116, 157);
            this.HTML.Name = "HTML";
            this.HTML.Size = new System.Drawing.Size(78, 24);
            this.HTML.TabIndex = 50;
            this.HTML.Text = "HTML";
            this.HTML.UseVisualStyleBackColor = true;
            this.HTML.CheckedChanged += new System.EventHandler(this.HTML_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 655);
            this.Controls.Add(this.HTML);
            this.Controls.Add(this.bodytbx);
            this.Controls.Add(this.filePathtbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.subjecttbx);
            this.Controls.Add(this.fromtbx);
            this.Controls.Add(this.totbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a);
            this.Name = "Form2";
            this.Text = "Send Mail";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox totbx;
        private System.Windows.Forms.TextBox fromtbx;
        private System.Windows.Forms.TextBox subjecttbx;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filePathtbx;
        private System.Windows.Forms.RichTextBox bodytbx;
        private System.Windows.Forms.CheckBox HTML;
    }
}