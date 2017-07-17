using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anket_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1 = -1;
        int sayı2 = -1;
        int sayı3 = -1;
        int sayı4 = -1;
        int sayı5 = -1;
        int sayı6 = -1;
        int sayı7 = -1;
        int sayı8 = -1;
        int sayı9 = -1;
        int sayı10 = -1;


        private void button1_Click(object sender, EventArgs e)
        {
                textBox1.Enabled = false;
                sayı1++;
                label1.Text = sayı1.ToString();          
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            sayı1 = 0;
            label1.Text = "0";
            textBox1.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button1.Enabled = false;
            button21.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            sayı2++;
            label2.Text = sayı2.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            sayı2 = 0;
            label2.Text = "0";
            textBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            button2.Enabled = false;
            button22.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;

            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            sayı3++;
            label3.Text = sayı3.ToString();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            sayı3 = 0;
            label3.Text = "0";
            textBox3.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            button3.Enabled = false;
            button23.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            sayı4++;
            label4.Text = sayı4.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            sayı4 = 0;
            textBox4.Clear();
            label4.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            button4.Enabled = false;
            button24.Enabled = false;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
            button21.Enabled = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            button2.Enabled = true;
            button22.Enabled = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            button3.Enabled = true;
            button23.Enabled = true;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            button4.Enabled = true;
            button24.Enabled = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            button5.Enabled = true;
            button25.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            sayı5++;
            label5.Text = sayı5.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            sayı5 = 0;
            textBox5.Clear();
            label5.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            button5.Enabled = false;
            button25.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
            sayı6++;
            label6.Text = sayı6.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            sayı6 = 0;
            textBox6.Clear();
            label6.Text = "0";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            button6.Enabled = true;
            button26.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
            button6.Enabled = false;
            button26.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
            sayı7++;
            label7.Text = sayı7.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            sayı7 = 0;
            textBox7.Clear();
            label7.Text = "0";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = true;
            button7.Enabled = true;
            button27.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
            button7.Enabled = false;
            button27.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = false;
            sayı8++;
            label8.Text = sayı8.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            sayı8 = 0;
            textBox8.Enabled = true;
            label8.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox9.Enabled = false;
            sayı9++;
            label9.Text = sayı9.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            sayı9 = 0;
            textBox9.Enabled = true;
            label9.Text = "0";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox9.Enabled = true;
            button9.Enabled = true;
            button29.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox9.Enabled = false;
            button9.Enabled = false;
            button29.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Enabled = false;
            sayı10++;
            label10.Text = sayı10.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            sayı10 = 0;
            textBox10.Enabled = true;
            label10.Text = "0";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox10.Enabled = true;
            button10.Enabled = true;
            button30.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox10.Enabled = false;
            button10.Enabled = false;
            button30.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            button8.Enabled = true;
            button28.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = false;
            button8.Enabled = false;
            button28.Enabled = false;
        }

       
    }
}
