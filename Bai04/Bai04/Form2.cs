using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.InteropServices;

namespace Bai04
{
    public partial class Form2 : Form
    {
        string email;
        string password;
        string host;
        int port;
        public Form2(string acc, string passwd, string smtp, int port1)
        {
            InitializeComponent();
            email = acc;
            password = passwd;
            host = smtp;
            port = port1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fromtbx.Text = email.ToString();
            fromtbx.Enabled = true;
        }

        private void fromtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string from = fromtbx.Text;
            string to = totbx.Text;
            string subject = subjecttbx.Text;
            string body = bodytbx.Text;
           

            try
            {
                // Kiểm tra các trường nhập liệu
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thiết lập SmtpClient để gửi email qua Gmail
                using (SmtpClient client = new SmtpClient(host, port))
                {
                    client.EnableSsl = true; // Sử dụng SSL
                    client.Credentials = new NetworkCredential(email, password);

                    // Tạo đối tượng MailMessage
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(from);
                    message.To.Add(new MailAddress(to));
                    message.Subject = subject;
                    message.Body = body;
                    message.IsBodyHtml = HTML.Checked; // Gửi email dạng plain text
                    if(OK == true)  // kiểm tra có đính kèm file hay không
                    {
                        Attachment attachment = new Attachment(filePathtbx.Text); // Đường dẫn đến tệp
                        message.Attachments.Add(attachment);
                        OK = false;
                      
                    }
                    
                    // Gửi email
                    client.Send(message);
                    MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gửi email thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool OK = false;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog.Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt|Image Files (*.jpg;*.png)|*.jpg;*.png";
            openFileDialog.Title = "Chọn một tệp";
            openFileDialog.Multiselect = false; // Cho phép chọn một tệp

            // Hiển thị hộp thoại
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp được chọn
                filePathtbx.Text = openFileDialog.FileName;
                OK = true;
            }
            
        }

        private void HTML_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
