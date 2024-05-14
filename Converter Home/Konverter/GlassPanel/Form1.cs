namespace GlassPanel
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
                    button1.Focus();
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (label5.Text != string.Empty)
            {
                label5.Text = string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (label5.Text != string.Empty)
            {
                label5.Text = string.Empty;
            }
            //label5.Text = (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox1.Text == "." || textBox2.Text == ".").ToString() + "\n" +
            //    (textBox1.TextLength == 0).ToString() + "\n" + (textBox2.TextLength == 0).ToString() + "\n" + (textBox1.Text == ".").ToString() + 
            //    "\n" + (textBox2.Text == ".").ToString();
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox1.Text == "." || textBox2.Text == ".")
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single w, h, s, price, cost;

            w = Convert.ToSingle(textBox1.Text);
            h = Convert.ToSingle(textBox2.Text);
            s = w * h / 10000;

            if (radioButton1.Checked)
            {
                price = 5000;
            }
            else price = 6000;

            cost = s * price;

            if (checkBox1.Checked)
            {
                cost += 20 * w;
            }

            if (radioButton1.Checked)
            {
                label5.Text = "Glass Pane Size:+" + w.ToString("N") +
                    "x" + h.ToString("N") + "cm\n" +
                    "Panel: " + radioButton1.Text +
                    "\nTotal Cost: " + cost.ToString("C"); 
            }
            else
            {
                label5.Text = "Glass Pane Size:+" + w.ToString("N") +
                    "x" + h.ToString("N") + "cm\n" +
                    "Panel: " + radioButton2.Text +
                    "\nTotal Cost: " + cost.ToString("C");
            }
        }
    }
}