using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_track_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                MessageBox.Show("Yeah!!!");
            }
            if (e.KeyCode == Keys.End)
            {
                MessageBox.Show("End!!!");
            }
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter!!!");
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.A)
            {
                MessageBox.Show("Aaaaa!!!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.End)
            {
                textBox2.Focus();
            }
            if(e.KeyChar == (char)Keys.E)
            {
                MessageBox.Show("Woah!!!");
            }
        }
        private void textBox1_KeyPress1(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.PageDown)
            {
                MessageBox.Show("waayy!!!");
            }
        }
    }
}
