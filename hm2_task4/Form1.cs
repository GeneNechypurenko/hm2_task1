namespace hm2_task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string textToSave = InputTextBox.Text;
            string fileName = FileNameTextBox.Text;

            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    File.WriteAllText(fileName, textToSave);
                    MessageBox.Show($"Текст сохранен в файл {FileNameTextBox.Text}.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не введено имя файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}