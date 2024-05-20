namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int pbh, pbw;

        private Boolean FillListBox(string aPath)
        {
            DirectoryInfo  di = new DirectoryInfo(aPath);

            FileInfo[] fi = di.GetFiles("*.jpg");

            listBox1.Items.Clear();

            foreach (FileInfo fc in fi)
            {
                listBox1.Items.Add(fc.Name);
            }

            label1.Text = aPath;

            if (fi.Length == 0) return false;
            else
            {
                listBox1.SelectedIndex = 0;
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbh = pictureBox1.Height;
            pbw = pictureBox1.Width;

            listBox1.Sorted = true;

            FillListBox(Application.StartupPath + "\\");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Chose the folder";
            fb.ShowNewFolderButton = false;

            if (fb.ShowDialog() == DialogResult.OK)
            {
                if (!FillListBox(fb.SelectedPath + "\\"))
                {
                    pictureBox1.Image = null;

                }
            }
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double mh, mw;

            pictureBox1.Image = new Bitmap(label1.Text + listBox1.SelectedItem.ToString());

            if (pictureBox1.Image.Width > pbw || pictureBox1.Image.Height > pbh)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                mh = (double)pbh / (double)pictureBox1.Image.Height;
                mw = (double)pbw / (double)pictureBox1.Image.Width;

                if (mh < mw)
                {
                    pictureBox1.Width = Convert.ToInt16(pictureBox1.Image.Width * mh);
                    pictureBox1.Height = pbh;

                }
                else
                {
                    pictureBox1.Width = pbw;
                    pictureBox1.Height = Convert.ToInt16(pictureBox1.Image.Height * mw);
                }
            }
            else if (pictureBox1.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }
    }
}