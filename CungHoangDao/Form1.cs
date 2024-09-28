using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CungHoangDao
{
    public partial class Form1 : Form
    {
        int x, z, y = 0;
        string datestr = "";
        string[] str;
        string day, month, year;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datestr = maskedTextBox2.Text;
            if(datestr == "  /  /")
            {
                MessageBox.Show("Vui long nhap ngay sinh");
            }
            else
            {

            str = datestr.Split('/');
            day = str[0];
            month = str[1];
            year = str[2];
            x = Convert.ToInt32(day);
            y = Convert.ToInt32(month);
            z = Convert.ToInt32(year);

            if (z > 0 && z < 2025)
            {
                switch (y)
                {
                    case 1:
                        {
                            if (x > 0 && x <= 20)
                            {
                                textBox1.Text = "Ma Kết";
                            }
                            else if (x > 20 && x <= 31)

                            {
                                textBox1.Text = "Bảo Bình";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                        break;
                        }
                    case 2:
                        {
                            if (x > 0 && x <= 19)
                            {
                                textBox1.Text = "Bảo Bình";
                            }
                            else if (x > 19 && x <= 28)

                            {
                                textBox1.Text = "Song Ngư";
                            }
                            else if(x == 29 && ((z % 4 == 0 && z % 100 != 0) || z % 400 == 0))    
                            {
                                textBox1.Text = "Song Ngư";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (x > 0 && x <= 20)
                            {
                                textBox1.Text = "Song ngư";
                            }
                            else if (x > 20 && x <= 31)

                            {
                                textBox1.Text = "Bạch Dương";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (x > 0 && x <= 20)
                            {
                                textBox1.Text = "Bạch Dương";
                            }
                            else if (x > 20 && x <= 30)

                            {
                                textBox1.Text = "Kim Ngưu";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (x > 0 && x <= 21)
                            {
                                textBox1.Text = "Kim Ngưu";
                            }
                            else if (x > 21 && x <= 31)

                            {
                                textBox1.Text = "Song Tử";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 6:
                        {
                            if (x > 0 && x <= 21)
                            {
                                textBox1.Text = "Song Tử";
                            }
                            else if (x > 21 && x <= 30)

                            {
                                textBox1.Text = "Cự Giải";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 7:
                        {
                            if (x > 0 && x <= 22)
                            {
                                textBox1.Text = "Cự Giải";                           
                            }
                            else if (x > 22 && x <= 31)

                            {
                                textBox1.Text = "Sư Tử";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 8:
                        {
                            if (x > 0 && x <= 22)
                            {                              
                                textBox1.Text = "Sư Tử";
                            }
                            else if (x > 22 && x <= 31)

                            {
                                textBox1.Text = "Xử Nữ";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 9:
                        {
                            if (x > 0 && x <= 23)
                            {
                                textBox1.Text = "Xử Nữ";
                            }
                            else if (x > 23 && x <= 30)

                            {
                                textBox1.Text = "Thiên Bình";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 10:
                        {
                            if (x > 0 && x <= 23)
                            {
                                textBox1.Text = "Thiên Bình";
                            }
                            else if (x > 23 && x <= 31)

                            {
                                textBox1.Text = "Thân Nông";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 11:
                        {
                            if (x > 0 && x <= 22)
                            {
                                textBox1.Text = "Thần Nông";
                            }
                            else if (x > 22 && x <= 30)

                            {
                                textBox1.Text = "Nhân Mã";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                    case 12:
                        {
                            if (x > 0 && x <= 21)
                            {
                                textBox1.Text = "Nhân Mã";
                            }
                            else if (x > 21 && x <= 31)

                            {
                                textBox1.Text = "Ma Kết";
                            }
                            else
                            {
                                MessageBox.Show("Ngay sinh khong hop le !");
                                maskedTextBox2.Clear();
                                break;
                            }
                            break;
                        }
                     default :
                                MessageBox.Show("Ngay sinh khong hop le !");
                            maskedTextBox2.Clear();
                            break;

                        }
                }


            else
            {
                MessageBox.Show("Ngay sinh khong hop le !");

            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Clear();
            textBox1.Clear();
            datestr = " / / ";
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
 
        
    }
}
