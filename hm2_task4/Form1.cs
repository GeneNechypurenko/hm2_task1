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
                    MessageBox.Show($"����� �������� � ���� {FileNameTextBox.Text}.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("�� ������� ��� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}