namespace Bai04
{
    partial class EmailDetailForm
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
            this.fromLb = new System.Windows.Forms.Label();
            this.subjectLb = new System.Windows.Forms.Label();
            this.toLb = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // fromLb
            // 
            this.fromLb.AutoSize = true;
            this.fromLb.Location = new System.Drawing.Point(23, 26);
            this.fromLb.Name = "fromLb";
            this.fromLb.Size = new System.Drawing.Size(54, 20);
            this.fromLb.TabIndex = 0;
            this.fromLb.Text = "From: ";
            this.fromLb.Click += new System.EventHandler(this.senderLabel_Click);
            // 
            // subjectLb
            // 
            this.subjectLb.AutoSize = true;
            this.subjectLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectLb.Location = new System.Drawing.Point(22, 104);
            this.subjectLb.Name = "subjectLb";
            this.subjectLb.Size = new System.Drawing.Size(94, 29);
            this.subjectLb.TabIndex = 1;
            this.subjectLb.Text = "Subject";
            this.subjectLb.Click += new System.EventHandler(this.subjectLb_Click);
            // 
            // toLb
            // 
            this.toLb.AutoSize = true;
            this.toLb.Location = new System.Drawing.Point(23, 66);
            this.toLb.Name = "toLb";
            this.toLb.Size = new System.Drawing.Size(35, 20);
            this.toLb.TabIndex = 2;
            this.toLb.Text = "To: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(27, 158);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(714, 371);
            this.webBrowser1.TabIndex = 50;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // EmailDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 541);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toLb);
            this.Controls.Add(this.subjectLb);
            this.Controls.Add(this.fromLb);
            this.Name = "EmailDetailForm";
            this.Text = "Email Detail";
            this.Load += new System.EventHandler(this.EmailDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLb;
        private System.Windows.Forms.Label subjectLb;
        private System.Windows.Forms.Label toLb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}