namespace hm2_task5
{
    public partial class Form1 : Form
    {

        private char lastChar;
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char currentChar = e.KeyChar;

            if (currentChar == lastChar) { e.Handled = true; }
            else { lastChar = currentChar; }
        }
    }
}