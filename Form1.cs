namespace LIFDCUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Title = "Select source file to load";
            ofd1.Filter = "All Files (*.*)|*.*";

            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = Path.GetFileName(ofd1.FileName).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Title = "Select driving file to load";
            ofd2.Filter = "All Files (*.*)|*.*";

            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = Path.GetFileName(ofd2.FileName).ToString();
            }
        }
    }
}
