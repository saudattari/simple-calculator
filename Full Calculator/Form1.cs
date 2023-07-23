using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Full_Calculator
{
    public partial class form1 : Form
    {
        float val1,val2;
        char sign = '\0';
        public form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            val1 = 0;
            val2 = 0;
            sign = '\0';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //minus button
            val1 = int.Parse(textBox1.Text);
            sign = '-';
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // multiply button
            val1 = int.Parse(textBox1.Text);
            sign = '*';
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //divion button
            val1 = int.Parse(textBox1.Text);
            sign = '/';
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //equal button
            float val3 = 0;
            if (sign == '-')
            {
              val2 = int.Parse(textBox1.Text);
                val3 = val1 - val2;
                textBox1.Text = val3.ToString();
            }
            else if(sign == '+')
            {
                val2 = int.Parse(textBox1.Text);
                val3 = val1 + val2;
                textBox1.Text = val3.ToString();
            }
            else if(sign == '*')
            {
                val2 = int.Parse(textBox1.Text);
                val3 = val1 * val2;
                textBox1.Text = val3.ToString();
            }
            else if(sign == '/')
            {
                val2 = int.Parse(textBox1.Text);
                val3 = val1 / val2;
                textBox1.Text = val3.ToString();
            }
            else
            {
                textBox1.Text = "error";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //plus button
            val1 = int.Parse(textBox1.Text);
            sign = '+';
            textBox1.Text = "";
        }
    }
}
