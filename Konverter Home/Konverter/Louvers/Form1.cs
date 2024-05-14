using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Louvers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Single w, h, s,
                c,
                cst;

            w = Convert.ToSingle(textBox1.Text);
            h = Convert.ToSingle(textBox2.Text);
            s = w * h / 10000;

            if (radioButton1.Checked)
            {
                c = 3600;

            }
            else c = 1800;

            cst = c * s;

            if (radioButton1.Checked)
            {
                label3.Text = "Size: " + w.ToString("N") + 
                    "cm x " + h.ToString("N") + "cm\n" +
                    "Matheril: " + radioButton1.Text + 
                    "\nPrice: " + cst.ToString("C");
            }
            else label3.Text = "Size: " + w.ToString("N") +
                    " x " + h.ToString("N") + "cm\n" +
                    "Matheril:" + radioButton2.Text +
                    "\nPrice: " + cst.ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            radioButton1.Checked = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (!(((char)e.KeyChar == '.') && (textBox1.Text.IndexOf('.') == -1)))
                {
                    e.Handled = true;
                }
                if ((char)e.KeyChar == (char)Keys.Escape)
                {
                    this.Close();
                }
                if ((char)e.KeyChar == (char)Keys.Enter)
                {
                    textBox2.Focus();
                }
                
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                if (!(((char)e.KeyChar == '.') && (textBox2.Text.IndexOf('.') == -1)))
                {
                    e.Handled = true;
                }
                if ((char)e.KeyChar == (char)Keys.Escape)
                {
                    this.Close();
                }
                if ((char)e.KeyChar == (char)Keys.Enter)
                {
                    textBox2.Focus();
                }

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox1.Text == "." || textBox2.Text == ".") 
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

    }
}
