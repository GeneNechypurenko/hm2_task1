namespace hm2_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InputTextBox.Text = "Abrakadabra!!!";
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            int countA = 0;
            int countB = 0;

            foreach (char c in InputTextBox.Text)
            {
                if (c == 'a' || c == 'A') { countA++; }
                else if (c == 'b' || c == 'B') { countB++; }
            }

            ResultLabel.Text = $"Количество 'a': {countA}, Количество 'b': {countB}";
        }
    }
}