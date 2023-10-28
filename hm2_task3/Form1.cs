namespace hm2_task3
{
    public partial class Form1 : Form
    {
        int[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            EvenListBox.Items.Clear();
            OddListBox.Items.Clear();

            if (array != null)
            {
                foreach (int number in array)
                {
                    if (number % 2 == 0) { EvenListBox.Items.Add(number); }
                    else { OddListBox.Items.Add(number); }
                }
            }
        }
    }
}