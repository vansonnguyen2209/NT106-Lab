using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using System.Net.Mail;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Net.Imap;
using MailKit;
namespace Bai04
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        bool exit = false;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (exit)
            {
                LoginButton.Text = @"Đăng nhập";
                exit = false;
               
                listView1.Clear();
                passwordtbx.Clear();
                emailtbx.Clear();
                this.Invoke(new Action(() =>
                {
                    SendButton.Visible = false;
                    RefreshButton.Visible = false;
                }));
                //
                MessageBox.Show("Đã đăng xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LoginButton.Text = @"Đăng xuất";
                exit = true;

                string email = emailtbx.Text;
                string password = passwordtbx.Text;
                int port = (int)portimaptbx.Value;
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    // Kết nối tới IMAP server
                    using (var client = new ImapClient())
                    {
                        // Kết nối đến server IMAP của Gmail (Sử dụng SSL)
                        client.Connect(imaptbx.Text, port, true);
                        client.Authenticate(email, password);  // Sử dụng app password cho Gmail

                        // Truy cập Inbox
                        var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadOnly);  // Mở Inbox ở chế độ chỉ đọc

                        // Lấy danh sách email (giới hạn lấy 20 email gần nhất)
                        int limit = Math.Min(inbox.Count, 10); // Giới hạn số lượng email cần lấy
                        listView1.Items.Clear();  // Xóa danh sách cũ trước khi tải mới
                        for (int i = inbox.Count - 1; i >= inbox.Count - limit; i--)
                        {
                            var message = inbox.GetMessage(i);
                            ListViewItem item = new ListViewItem(message.From.ToString());
                            item.SubItems.Add(message.Subject);
                            item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm:ss"));
                            listView1.Items.Add(item);

                        }
                        // Đóng kết nối
                        client.Disconnect(true);
                        this.Invoke(new Action(() =>
                        {
                            SendButton.Visible = true;
                            RefreshButton.Visible = true;
                        }));
                        MessageBox.Show("Đăng nhập thành công và tải email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đăng nhập hoặc tải email thất bại!: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                //
            }
        }


      

        

        private void SendButton_Click(object sender, EventArgs e)
        {
            int port = (int)portsmtptbx.Value;
           Form2 sendMail = new Form2(emailtbx.Text.ToString(), passwordtbx.Text.ToString(), smtptbx.Text.ToString(), port);
            sendMail.ShowDialog();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Kết nối tới IMAP server để lấy nội dung chi tiết của email
                using (var client = new ImapClient())
                {
                    int port = (int)portimaptbx.Value;
                    try
                    {
                        client.Connect(imaptbx.Text, port, true);
                        client.Authenticate(emailtbx.Text, passwordtbx.Text);
                        var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadOnly);

                        // Tìm email theo index trong ListView
                        int index = listView1.Items.IndexOf(selectedItem);
                        var message = inbox.GetMessage(inbox.Count - 1 - index);

                        // Hiển thị chi tiết email trong form mới
                        EmailDetailForm detailForm = new EmailDetailForm(
                            message.From.ToString(),
                            message.To.ToString(),
                            message.Subject,
                       
                            message.HtmlBody
                        );
                        detailForm.ShowDialog();

                        client.Disconnect(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải email!: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            string email = emailtbx.Text;
            string password = passwordtbx.Text;
            int port = (int)portimaptbx.Value;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Kết nối tới IMAP server
                using (var client = new ImapClient())
                {
                    // Kết nối đến server IMAP của Gmail (Sử dụng SSL)
                    client.Connect(imaptbx.Text, port, true);
                    client.Authenticate(email, password);  // Sử dụng app password cho Gmail

                    // Truy cập Inbox
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);  // Mở Inbox ở chế độ chỉ đọc

                    // Lấy danh sách email (giới hạn lấy 20 email gần nhất)
                    int limit = Math.Min(inbox.Count, 10); // Giới hạn số lượng email cần lấy
                    listView1.Items.Clear();  // Xóa danh sách cũ trước khi tải mới
                    for (int i = inbox.Count - 1; i >= inbox.Count - limit; i--)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem item = new ListViewItem(message.From.ToString());
                        item.SubItems.Add(message.Subject);
                        item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm:ss"));
                        listView1.Items.Add(item);
                    }
                    // Đóng kết nối
                    client.Disconnect(true);
                    this.Invoke(new Action(() =>
                    {
                        SendButton.Visible = true;
                        RefreshButton.Visible = true;
                    }));
                    MessageBox.Show($"Tải lại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tải lại thất bại!: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
