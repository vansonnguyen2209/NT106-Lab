using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace Bai04
{
    public partial class EmailDetailForm : Form
    {
        public EmailDetailForm(string sender, string recceiver, string subject, string body)
        {
            InitializeComponent();
            // Gán dữ liệu vào các điều khiển trên form
            fromLb.Text = "From: " + sender;
            toLb.Text = "To: " + recceiver;
            subjectLb.Text = subject;
            
            webBrowser1.DocumentText = body; // TextBox hoặc RichTextBox để hiển thị nội dung email
        }

        private void EmailDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void senderLabel_Click(object sender, EventArgs e)
        {

        }

        private void subjectLb_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
