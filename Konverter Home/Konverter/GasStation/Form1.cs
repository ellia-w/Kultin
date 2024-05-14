using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox1.Items.Add("92");
            comboBox1.Items.Add("95");
            comboBox1.Items.Add("98");
            comboBox1.Items.Add("DF");

            button1.Enabled = false;
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
                //MessageBox.Show(((char)e.KeyChar == '.').ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != ".") && (textBox1.TextLength > 0) && (comboBox1.SelectedIndex != -1))
            {
                button1.Enabled = true;
            }
            else if (!button1.Enabled) button1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != ".") && (textBox1.TextLength > 0 ))
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lp = 17.12F;
            double lt;
            double cash;
            double nb;

            switch (comboBox1.SelectedIndex)
            {
                case 0: lp = 17.12F; break;
                case 1: lp = 19.45F; break;
                case 2: lp = 20.25F; break;
                case 3: lp = 17.00F; break;
            }

            cash = Convert.ToSingle(textBox1.Text);
            lt = (double)Decimal.Truncate((Decimal)(cash * 10 / lp)) / 10;
            nb = cash - lt * lp;

            label3.Text = "Liters: " + lt.ToString("N") +
                "\nSum: " + cash.ToString("C") +
                "\nNickle Back: " + nb.ToString("C") +
                "\nLiter Price: " + lp.ToString("C");
        }
    }
}
