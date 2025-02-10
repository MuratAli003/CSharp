using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int genislik = groupBox1.Width;
            
            Random random = new Random();

            pictureBox1.Left += random.Next(8, 25);
            pictureBox2.Left += random.Next(8, 25);
            pictureBox3.Left += random.Next(8, 25);

            if(pictureBox1.Left + pictureBox1.Width - 30 >= genislik)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numaralı at yarışı kazandı");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;
            }
            else if(pictureBox2.Left + pictureBox2.Width - 30 >= genislik)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numaralı at yarışı kazandı");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;
            }
            else if (pictureBox3.Left + pictureBox3.Width - 30 >= genislik)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numaralı at yarışı kazandı");
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
                pictureBox3.Left = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
