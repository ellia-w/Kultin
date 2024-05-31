namespace Reference_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //helpProvider1.SetHelpString(textBox1, "this is text box 1");

            helpProvider1.HelpNamespace = "usdToUah.chm";

            helpProvider1.SetHelpKeyword(this, "usdToUah_01.htm");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(this, true);

            helpProvider1.SetHelpKeyword(this.textBox1, "usdToUah_03.htm");
            helpProvider1.SetHelpNavigator(this.textBox1, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(this.textBox1, true);

            helpProvider1.SetHelpKeyword(this.textBox2, "usdToUah_04.htm");
            helpProvider1.SetHelpNavigator(this.textBox2, HelpNavigator.Topic);
            helpProvider1.SetShowHelp(this.textBox2, true);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "." && textBox1.Text.IndexOf(".") == -1))
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                textBox2.Focus();
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar.ToString() == "." && textBox2.Text.IndexOf(".") == -1))
                {
                    e.Handled = true;
                }
            }
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                button1.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k, usd, uah;

            label3.Text = string.Empty;

            try
            {
                usd = System.Convert.ToDouble(textBox1.Text);
                k = System.Convert.ToDouble(textBox2.Text);

                uah = usd * k;

                label3.Text = usd.ToString("N") + " USD = " + uah.ToString("C");


            }
            catch
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Error input data.\n" +
                        "Both fields must be filled.", "Converter",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Error input data.\n+" +
                        "Incorrect data format in one of the fields", "Converter",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace, "usdToUah_01.htm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            helpProvider1.SetHelpString(textBox1, "this is text box 1");
        }
    }
}