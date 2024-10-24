using Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server
{
    public partial class Server : Form
    {
        List<int> seatList = new List<int>();
        List<Button> buttonList = new List<Button>();
        private TcpListener listener;
        private TcpClient client;
        private List<User> userList = new List<User>();
        Packet packet1 = new Packet();
        Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
        int q = 0;
        public Server()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Server_Load(object sender, EventArgs e)
        {
             CreateButtons();
             CreateSeats();
        }
  
        void Listen()
        {
            try
            {
                while (true)
                {
                    client = listener.AcceptTcpClient();
                    Thread receiver = new Thread(Receive);
                    receiver.IsBackground = true;
                    receiver.Start(client);
                }
            }
            catch
            {               
            }
        }   
            void Receive(object obj)
            {
                TcpClient client = obj as TcpClient;
                User user = new User(client);
                if(!userList.Contains(user)) userList.Add(user);

                label7.Text = userList.Count.ToString();          

                SendToClients();

                try
                {

                    while (true)
                    {
                        Packet request = JsonConvert.DeserializeObject<Packet>(user.Reader.ReadLine());
                        switch (request.Code)
                        {
                            case "1":

                                Choose(request);                           
                                label1.Text = (25 - NumberOfSeat(request.Pos)).ToString();
                                label6.Text = NumberOfSeat(request.Pos).ToString();
                                break;
                            case "-2":
                            DisConnect(user);
                            break;
                        }      
                    }
                }
                catch 
                {      
                }
            }
         void DisConnect(User user)
        {
            userList.Remove(user);
            label7.Text = userList.Count.ToString();   
        }
        void Choose(Packet packet)
            {
                
                
                dictionary[packet.Name] = packet.Pos;
                      
                LockButton(packet);
                SendToClients();
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
            void SendToClients()
            {
                packet1.Code = "3";
                foreach (User user in userList)
                {
                    foreach (string name in dictionary.Keys)
                    {
                        packet1.Name = name;
                        packet1.Pos = dictionary[name];
                        Send(user, packet1);
                    }
                }

            }
            void Send(User user, Packet info)
            {
                string messageInJson = JsonConvert.SerializeObject(info);
                try
                {
                    user.Writer.WriteLine(messageInJson);
                    user.Writer.Flush();
                }
                catch
                {
                }
            }

            void CreateSeats()
            {
                for (int i = 1; i < 26; i++)
            {
                seatList.Add(i);
            }
            }
            int NumberOfSeat(List<int> pos)
            {
            try
            {
                foreach (int s in pos)
                {
                    seatList.Remove(s);
                }
                return seatList.Count;
            }
            catch
            {
                return seatList.Count;
            }
            }
        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.Text == @"LISTEN")
            {
                button26.Text = @"STOP";
                listener = new TcpListener(IPAddress.Any, Convert.ToInt32(textBox1.Text));
                listener.Start();
                Thread clientThread = new Thread(Listen);
                clientThread.IsBackground = true;
                clientThread.Start();
                MessageBox.Show("Lisening...");
            }
            else
            {
                button26.Text = @"LISTEN";
                listener.Stop();
            }
        }

            private void CreateButtons()
            {
                int buttonWidth = 60;    // Chiều rộng của mỗi nút
                int buttonHeight = 40;   // Chiều cao của mỗi nút
                int spacing = 10;        // Khoảng cách giữa các nút
                int rows = 5;            // Số hàng nút
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
                    buttonList.Add(btn);
                    // Đặt nội dung text cho nút từ 1 đến 25
                    btn.Text = (i + 1).ToString();

                    // Xử lý sự kiện khi người dùng nhấn vào nút


                    // Thêm nút vào form
                    this.Controls.Add(btn);
                }
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button25_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

