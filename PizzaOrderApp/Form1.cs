using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            if (radioButton1.Checked)
            {
                price = price + 11;
            }
            if (radioButton2.Checked)
            {
                price = price + 16;
            }
            if (radioButton3.Checked)
            {
                price = price + 30;
            }
            if (radioButton4.Checked)
            {
                price = price + 2;
            }
            if (radioButton7.Checked)
            {
                price = price + 2;
            }
            if (radioButton8.Checked)
            {
                price = price + 3;
            }
            if (radioButton9.Checked)
            {
                price = price + 2;
            }

            string priceInString = price.ToString();

            textBox1.Text = priceInString + " TL";

        }

    }
}
