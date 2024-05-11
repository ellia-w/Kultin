using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            checkBox3.Enabled = false;
        }

        private double sum;


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sum += 54.00;
            }
            else sum -= 54.00;

            label2.Refresh();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                sum += 24.50;
                if (!checkBox3.Enabled)
                {
                    checkBox3.Enabled = true;
                }
            }
            else
            {
                sum -= 24.50;
                if (checkBox3.Checked) 
                {
                    checkBox3.Checked = false;
                }
                checkBox3.Enabled = false;
            }
            label2.Refresh();
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                sum += 10.50;
            }
            else sum -= 10.50;
            label2.Refresh();
        }



        private void label2_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = sum.ToString();
            if (sum > 0) button1.Enabled = true;
            else button1.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                sum += 18.00;
            }
            else sum -= 18.00;
            label2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                MessageBox.Show("You have a discount in 10%\n" +
                    "Order summ:" + (sum * 0.9).ToString("C"),
                    "Cafe");
            }
            else
            {
                if (checkBox1.Checked || checkBox2.Checked || checkBox4.Checked)
                {
                    MessageBox.Show("Order Sum: " + sum.ToString("C"),
                        "Cafe");
                }
            }
        }
    }
}
