using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electric_Energy
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
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            float curr;
            float prev;
            float traf;
            float price;

            label5 .Text = "";

            try
            {
                prev = float.Parse(textBox1.Text);
                curr = float.Parse(textBox2.Text);
                traf = float.Parse(textBox3.Text);

                if (curr >= prev)
                {
                    price = (curr - prev) * traf;
                    label5.Text = "Bill to pay is " + price.ToString("C");
                }
                else MessageBox.Show("Input data error\n" +
                    "Current measure is less than previous\n" +
                    "Electricity");
            }
            
            catch (Exception exc)
            {
                MessageBox.Show("Input data error\n" + 
                    "Input data is of wrong type.\n" + 
                    exc.Message, "Electricity",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString() + (e.KeyChar == '.').ToString() + (!Char.IsDigit(e.KeyChar)).ToString() + (Char.IsControl(e.KeyChar)).ToString());
             
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))// || !(e.KeyChar == '.'))
            {
                
                if (!((e.KeyChar.ToString() == ".") && (textBox1.Text.IndexOf(".") == -1)))
                {
                    e.Handled = true;
                }
                MessageBox.Show("Not a digit or dot");

            }
            if (e.KeyChar.Equals((char)Keys.Enter)) //Oemcomma
            {
                textBox2.Focus();
            }
            if (e.KeyChar != '.')
            {
                e.Handled = true;
            }
            

            //MessageBox.Show(e.KeyChar.Equals((char)Keys.Decimal).ToString());
            //MessageBox.Show(e.KeyChar.Equals((char)Keys.N).ToString());

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                //MessageBox.Show("Not a digit");
                e.Handled = true;
            }
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                textBox3.Focus();
                //MessageBox.Show(Keys.Enter.ToString());
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                //MessageBox.Show("Not a digit");
                e.Handled = true;
            }
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                button1.Focus();
                //textBox1.Focus();

            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        
    }
}
