namespace GuessTheNumbers_Test
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;

        private const int CN = 3;

        private int t, s;

        private int[] n = new int[CN];

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!timer1.Enabled)
            {
                Random rnd = new Random();

                n[0] = rnd.Next(9) + 1;

                for (int i = 0; i < CN; i++)
                {
                    n[i] = rnd.Next(10);

                }
                t = 0;
                s = 0;
                textBox1.Text = string.Empty;
                label5.Text = textBox1.Text;
                button1.Text = "Stop";

                //textBox1.Focus();

                

                groupBox1.Enabled = true;
                timer1.Enabled = true;
                
                textBox1.Select();


            }
            else
            {
                timer1.Enabled = false;
                groupBox1.Enabled = false;
                textBox1.Text = string.Empty;
                label5.Text = textBox1.Text;
                button1.Text = "Start";
                label2.Text = "Guessed numbers: 0";
                label3.Text = "Digits on right positions: 0";
                StatusPanel1.Text = "Tries: 0";
                StatusPanel2.Text = "Time: 0 s";
                

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean[] r = new Boolean[CN];
            int pn = 0, //number position
                rn = 0; //right numbers
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                
                if (e.KeyChar.Equals((char)Keys.Enter))
                {                    
                    t++;

                    StatusPanel1.Text = "Tries: " + t.ToString();



                    for (int i = 0; i < textBox1.TextLength; i++)
                    {
                        for (int j = 0; j < CN; j++)
                        {
                            if ((Convert.ToInt16(textBox1.Text.Substring(i, 1)) == n[j]) && !r[j])
                            {
                                rn++;
                                r[j] = true;
                                break;
                            }
                        }
                        if (Convert.ToInt16(textBox1.Text.Substring(i, 1)) == n[i])
                        {
                            pn++;
                        }
                    }

                    label2.Text = "Guessed numbers: " + rn.ToString();
                    label3.Text = "Numbers on the right positions: " + pn.ToString();

                    if (pn == CN)
                    {
                        timer1.Enabled = false;
                        groupBox1.Enabled = false;

                        //if (s > 60)
                        //{

                        //}

                        MessageBox.Show("You right!\n" +
                            "The number is: " + textBox1.Text +
                            "\nTries realize: " + t.ToString() +
                            "\nSpent time: " + s.ToString() + "s", "Guess The Number",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox1.Text = string.Empty;
                        label5.Text = textBox1.Text;
                        button1.Text = "Start";

                        label2.Text = "Guessed numbers: 0";
                        label3.Text = "Numbers on right positions: 0";

                        StatusPanel1.Text = "Tries: 0";
                        StatusPanel2.Text = "Time: 0 s";
                        label6.Visible = true;
                        label7.Text = "Tries realize: " + t.ToString() + "\nSpent time: " + s.ToString() + "s";
                    }
                    if (textBox1.Text.Length == 3)
                    {
                        label5.Text = textBox1.Text;
                        textBox1.Text = string.Empty;

                    }
                }
            }
            else e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //private void timer1_TimerTick(object sender, EventArgs e)
        //{
        //    s++;
        //    StatusPanel2.Text = "Time: " + s.ToString() + "s";
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            StatusPanel2.Text = "Time: " + s.ToString() + "s";
        }

        public Form1()
        {
            InitializeComponent();
            statusStrip1.SizingGrip = false;

            StatusPanel1.Text = "Tries: 0";
            StatusPanel2.Text = "Time: 0 s";

            groupBox1.Enabled = false;

            timer1.Enabled = false;
            timer1.Interval = 1000;


            

            textBox1.MaxLength = CN;

        }
        
        
    }
}