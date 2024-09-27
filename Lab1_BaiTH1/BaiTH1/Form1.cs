using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTH1
{
    public partial class Form1 : Form
    {
        float x, y, z;
        bool isButtonClicked;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (check(Sothunhat.Text) == false)
            {
                MessageBox.Show("Gia tri khong hop le !");
                Sothunhat.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            float.TryParse(Sothunhat.Text, out x);
            float.TryParse(Sothuhai.Text, out y);
            float.TryParse(Sothuba.Text, out z);

            if (x > y && y > z)
            {
                Solonnhat.Text = x.ToString();
                Sonhonhat.Text = z.ToString();
            }
            else if (x >= z && z >= y)
            {
                Solonnhat.Text = x.ToString();
                Sonhonhat.Text = y.ToString();
            }
            else if (y >= x && x >= z)
            {
                Solonnhat.Text = y.ToString();
                Sonhonhat.Text = z.ToString();
            }
            else if (y >= z && z >= x)
            {
                Solonnhat.Text = y.ToString();
                Sonhonhat.Text = x.ToString();
            }
            else if (z >= y && y >= x)
            {
                Solonnhat.Text = z.ToString();
                Sonhonhat.Text = x.ToString();
            }
            else if (z >= x && x >= y)
            {
                Solonnhat.Text = z.ToString();
                Sonhonhat.Text = y.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Solonnhat.Clear();
            Sonhonhat.Clear();
            Sothunhat.Clear();
            Sothuhai.Clear();
            Sothuba.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (check(Sothuhai.Text) == false)
            {
                MessageBox.Show("Gia tri khong hop le !");
                Sothuhai.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (check(Sothuba.Text) == false)
            {
                MessageBox.Show("Gia tri khong hop le !");
                Sothuba.Clear();
            }
        }
        private bool check(string s)
        {
            if (s.Length == 0) return true;
            for(int i = 0 ;i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
