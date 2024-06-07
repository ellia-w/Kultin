using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fa = new Form3();
            fa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(); 
            fm.ShowDialog();
            label2.Text = "Message received: " + fm.msg;
        }
    }
}
