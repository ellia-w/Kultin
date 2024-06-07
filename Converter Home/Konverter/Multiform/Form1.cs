namespace Multiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (/*button1.Focus() == true &&*/ !textBox1.Focus() && textBox1.Text == "")
            {
                textBox1.Focus();
            }
            //textBox1.Focus();
        }

        public string msg = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            this.msg = textBox1.Text;
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                button1.Focus();
            }
        }
    }
}