using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konverter
{
    public partial class Konverter : Form
    {
        public Konverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && 
                !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && 
                    (textBox1.Text.IndexOf(",") == -1 )))                
                    e.Handled = true;                
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") &&
                    (textBox1.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double k;
            double usd;
            double uah;

            label4.Text = "";
            try
            {
                usd = System.Convert.ToDouble(textBox1.Text);
                k = System.Convert.ToDouble(textBox2.Text);
                uah = usd * k;
                label4.Text = usd.ToString("N") + "USD = " + uah.ToString("C");

                
            }
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("An Error input data.\n + " +
                        "Both data must be filled.",
                        "Converter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Input Data error.\n" +
                        "A wrong data format in one of the rows.",
                        "Converter", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double k;
            double usd;
            double uah;

            label4.Text = "";
            try
            {
                usd = System.Convert.ToDouble(textBox1.Text);
                k = System.Convert.ToDouble(textBox2.Text);
                uah = usd * k;
                label4.Text = usd.ToString("N") + "USD = " + uah.ToString("C");


            }
            catch
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                {
                    MessageBox.Show("An Error input data.\n + " +
                        "Both data must be filled.",
                        "Converter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Input Data error.\n" +
                        "A wrong data format in one of the rows.",
                        "Converter", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
