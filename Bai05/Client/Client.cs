using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Client
{
    public partial class Client : Form
    {
        int temp = 0;
        int count = 0;
        bool connected = false;
        private TcpClient client;
        private IPEndPoint serverIP;
        private StreamReader sr;
        private StreamWriter sw;
        private Packet packet;
        Dictionary<Button, bool> buttonAndStatus = new Dictionary<Button, bool>();
        List<Button> buttonList = new List<Button>();
        public Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            CreateButtons();
            packet = new Packet();
            packet.Code = "0";
            packet.Name = textBox3.Text;
        }
        void Choose(int x)
        {
            packet.Code = "1";
            packet.Pos.Add(x);
        }
        void Cancel(int x)
        {
            packet.Code = "1";
            packet.Pos.Remove(x);
        }
        private void Connect_Click(object sender, EventArgs e)
        {
                if(Connect.Text == @"CONNECT")
            {
                connected  = true;
                Connect.Text = @"STOP";

                client = new TcpClient();
                serverIP = new IPEndPoint(IPAddress.Parse(textBox4.Text), Convert.ToInt32(textBox2.Text));
                client.Connect(serverIP);

                NetworkStream ns = client.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);

                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();

                MessageBox.Show("Connected");
            }
            else
            {
                DisConnect();
                textBox3.Text = "";
                connected = false;
                Connect.Text = @"CONNECT";
                MessageBox.Show("Stop");
                client.Close();
            } 
        }
        void DisConnect()
        {
            packet.Code = "-2";
            packet.Name = textBox3.Text;
            Send(packet);
        }
        void Send(Packet info)
        {
            if (connected == true)
            {
                string messageInJson = JsonConvert.SerializeObject(info);
                try
                {
                    sw.WriteLine(messageInJson);
                    sw.Flush();
                }
                catch
                {
                    client.Close();
                }
            }
        }
        void Receive()
        {
            try
            {
                string responseInJson = string.Empty;
                while (true)
                {
                    responseInJson = sr.ReadLine();
                    Packet request = JsonConvert.DeserializeObject<Packet>(responseInJson);

                    switch (request.Code)
                    {
                        case "3":
                            LockButton(request);
                            break;

                    }
                }
            }
            catch 
            {
                client.Close();
            }
        }

        private void CreateButtons()
        {


            int buttonWidth = 60;    // Chiều rộng của mỗi nút
            int buttonHeight = 40;   // Chiều cao của mỗi nút
            int spacing = 10;        // Khoảng cách giữa các nút
          //  int rows = 5;            // Số hàng nút
            int cols = 5;            // Số cột nút

            for (int i = 0; i < 25; i++)
            {
                // Tạo một nút mới
                Button btn = new Button();

                // Thiết lập kích thước của nút
                btn.Width = buttonWidth;
                btn.Height = buttonHeight;

                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.LemonChiffon;

                // Đặt vị trí của nút theo tọa độ lưới
                btn.Left = 205 + (i % cols) * (buttonWidth + spacing);  // Xác định vị trí nút theo cột
                btn.Top = 10 + (i / cols) * (buttonHeight + spacing);  // Xác định vị trí nút theo hàng

                // Đặt nội dung text cho nút từ 1 đến 25
                btn.Text = (i + 1).ToString();
                buttonList.Add(btn);
                buttonAndStatus[btn] = true;
                // Xử lý sự kiện khi người dùng nhấn vào nút
                btn.Click += (sender, e) =>
                {
                    Button clickedButton = (Button)sender;
                    if(connected == true)
                    {
                        if (buttonAndStatus[clickedButton] == true)
                        {
                            clickedButton.BackColor = Color.LightSkyBlue;
                            Choose(Convert.ToInt32(clickedButton.Text));
                            buttonAndStatus[clickedButton] = false;
                        }
                        else
                        {
                            try
                            {
                                clickedButton.BackColor = Color.LemonChiffon;
                                Cancel(Convert.ToInt32(clickedButton.Text));
                                buttonAndStatus[clickedButton] = true;
                            }
                            catch
                            {

                            }

                        }
                    }
                    else MessageBox.Show("Please connect to the server !");

                };

                // Thêm nút vào form
                this.Controls.Add(btn);
            }
        }

        bool  CheckChoose()
        {
            temp = count;
            count = 0;
            foreach (Button button in buttonList)
                {
                    if (buttonAndStatus[button] == false)
                    {
                        count++;
                    }
                }
               if(temp != count) return true;
               else return false;

        }
        private void button26_Click(object sender, EventArgs e)
        {

                if (connected == true)
                {
                    if (textBox3.Text == "") MessageBox.Show("Please enter your name !");
                    else
                    {
                        if (!CheckChoose()) MessageBox.Show("Please choose seat ");
                        else
                        {
                            packet.Name = textBox3.Text;
                            LockButton(packet);
                            Send(packet);
                         }
                    }
                }
                else MessageBox.Show("Please connect to the server !");
            }
            
        

        void LockButton(Packet packet)
        {
            try
            {
                foreach (int pos in packet.Pos)
                {
                    foreach (Button button in buttonList)
                    {

                        if (button.Text == pos.ToString())
                        {
                            button.BackColor = Color.DarkGray;
                            button.Text = packet.Name.ToString();
                            button.Enabled = false;
                        }

                    }
                }
                
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisConnect();
        }
    }




}