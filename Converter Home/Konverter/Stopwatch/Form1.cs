namespace Stopwatch
{
    public partial class Form1 : Form
    {
        

        private int m, s, ms;

        private System.Windows.Forms.Timer timer1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;

                button1.Text = "Start";
                button2.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Stop";
                button2.Enabled= false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m = 0;
            s = 0;
            ms = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ms == 99)
            {
                if (s == 59)
                {
                    if (m == 99)
                    {
                        m = 0;
                    }
                    else m++;
                    ms = 0;
                }
                else s++;
                ms = 0;
            }
            else ms++;

            if (m.ToString().Length == 1)
            {
                label1.Text = "0" + m.ToString();

            }
            else label1.Text = m.ToString();

            if (s.ToString().Length == 1)
            {
                label2.Text = "0" + s.ToString();
            }
            else label2.Text = s.ToString();

            if (ms.ToString().Length == 1)
            {
                label3.Text = "0" + ms.ToString();
            }
            else label3.Text = ms.ToString();

            if (ms == 1)
            {
                label5.Text = ":";
            }
            if (ms == 50)
            {
                label5.Text = "";

            }
        }

        public Form1()
        {
            InitializeComponent();
            m = 0;
            s = 0;
            ms = 0;

            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";

            timer1.Interval = 10;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}