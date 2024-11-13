using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
namespace bai03
{
    public partial class Form1 : Form
    {
        HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
        HtmlAgilityPack.HtmlDocument doc;
        public Form1()
        {
            InitializeComponent();
            
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.Navigate(textBox1.Text);
        }    
        private async void button1_Click(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.Navigate(textBox1.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox1.Text);
            form2.ShowDialog();
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            string downloadFolder = string.Empty;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    downloadFolder = folderBrowserDialog.SelectedPath;
                }
                doc = web.Load(textBox1.Text);
            }
            using (HttpClient client = new HttpClient())
            {
                var imageNodes = doc.DocumentNode.SelectNodes("//img[@src]");
                if (imageNodes != null)
                {

                    foreach (var img in imageNodes)
                    {
                        string imgUrl = img.GetAttributeValue("src", "");                 
                        await DownloadFile(client, imgUrl, downloadFolder);
                    }
                }
                var audioNodes = doc.DocumentNode.SelectNodes("//audio[@src] | //source[@src]");
                if (audioNodes != null)
                {

                    foreach (var audio in audioNodes)
                    {
                        string audioUrl = audio.GetAttributeValue("src", "");                 
                        await DownloadFile(client, audioUrl, downloadFolder);
                    }
                }
                var scriptNodes = doc.DocumentNode.SelectNodes("//script[@src]");
                if (scriptNodes != null)
                {

                    foreach (var script in scriptNodes)
                    {
                        string scriptUrl = script.GetAttributeValue("src", "");                  
                        await DownloadFile(client, scriptUrl, downloadFolder);
                    }
                }
                var cssNodes = doc.DocumentNode.SelectNodes("//link[@rel='stylesheet' and @href]");
                if (cssNodes != null)
                {

                    foreach (var css in cssNodes)
                    {
                        string  cssUrl = css.GetAttributeValue("src", "");
                        await DownloadFile(client, cssUrl, downloadFolder);
                    }
                }
                MessageBox.Show("Da tai xong");
            }
        }
        static async Task DownloadFile(HttpClient client, string fileUrl, string downloadFolder)
        {
            try
            {
                // Lấy tên file từ URL
                string fileName = Path.GetFileName(new Uri(fileUrl).LocalPath);
                string filePath = Path.Combine(downloadFolder, fileName);

                byte[] fileBytes = await client.GetByteArrayAsync(fileUrl);
                File.WriteAllBytes(filePath, fileBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webView_Click(object sender, EventArgs e)
        {

        }
    }
}

