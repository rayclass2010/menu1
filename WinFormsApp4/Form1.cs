namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string msg = "";
        public static double mon = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Text = msg;
        }
    }
}
