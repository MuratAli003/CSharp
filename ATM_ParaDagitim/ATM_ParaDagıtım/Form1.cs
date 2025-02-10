using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_ParaDagıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            
            Button buttons = (Button)sender;
            string button = buttons.Text;
            string number = "";

            int index = 0;
            while (index < 3)
            {
                if (button[index].Equals(' '))
                {
                    break;
                }

                number += button[index];
                index++;
            }
            index = 0;

            if (textBox1.Text == "")
            {
                textBox1.Text = number ;
            }
            else
            {
                int num1 = Convert.ToInt32(number);
                int num2 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(num1 + num2);
            }

        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] numArray = { 200, 100, 50, 20, 10, 5 };

            int number = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < numArray.Length; i++)
            {
                if(number == 0)
                {
                    break;
                }

                int adet = number / numArray[i];

                if (adet != 0)
                {
                    number -= numArray[i] * adet;
                    listBox1.Items.Add(adet + " x " + numArray[i] + " TL");
                }
            }
            listBox1.Items.Add("---------------------------------");
            listBox1.Items.Add("      Paraniz Yatirildi");
            listBox1.Items.Add("---------------------------------");
            textBox1.Text = "";
        }
    }
}
