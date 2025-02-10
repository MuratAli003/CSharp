using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            textBox1.Text += btn.Text;
        }

        string islem = "";
        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            islem = btn.Text;

            if (label1.Text == "")
            {
                label1.Text = textBox1.Text;
                textBox1.Text = "";
                
            }
            else
            {
                if(textBox1.Text != "")
                {
                    double sayi1 = Convert.ToInt32(label1.Text);
                    double sayi2 = Convert.ToInt32(textBox1.Text);
                    switch(btn.Text)
                    {
                        case "+":
                            double toplam = sayi1 + sayi2;
                            textBox1.Text = Convert.ToInt32(toplam).ToString();
                            label1.Text = "";
                            break;

                        case "-":
                            double fark = sayi1 - sayi2;
                            textBox1.Text = Convert.ToInt32(fark).ToString();
                            label1.Text = "";
                            break;

                        case "*":
                            double sonuc = sayi1 * sayi2;
                            textBox1.Text = Convert.ToInt32(sonuc).ToString();
                            label1.Text = "";
                            break;

                        case "/":
                            double bolum = sayi1 / sayi2;
                            textBox1.Text = bolum.ToString();
                            label1.Text = "";
                            break;

                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if(label1.Text != "")
                {
                    double sayi1 = Convert.ToInt32(label1.Text);
                    double sayi2 = Convert.ToInt32(textBox1.Text);
                    switch (islem)                    
                    {
                        case "+":
                            double toplam = sayi1 + sayi2;
                            textBox1.Text = Convert.ToInt32(toplam).ToString();
                            label1.Text = "";
                            break;

                        case "-":
                            double fark = sayi1 - sayi2;
                            textBox1.Text = Convert.ToInt32(fark).ToString();
                            label1.Text = "";
                            break;

                        case "*":
                            double sonuc = sayi1 * sayi2;
                            textBox1.Text = Convert.ToInt32(sonuc).ToString();
                            label1.Text = "";
                            break;

                        case "/":
                            double bolum = sayi1 / sayi2;
                            textBox1.Text = bolum.ToString();
                            label1.Text = "";
                            break;

                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
    }
}
