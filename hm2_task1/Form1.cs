namespace hm2_task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DepositEntryNumeric.Minimum = 1000;
            DepositEntryNumeric.Maximum = 10000000;

            DepositTerms3RadioButton.Checked = true;
            InterestRate4RadioButton.Checked = true;

            ResultTextBox.Text = $"{0:C}";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal depositEntry = decimal
                .Parse(DepositEntryNumeric.Text);

            decimal interestRate = decimal
                .Parse(InterestRateGroupBox.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(el => el.Checked)
                .Tag.ToString());

            decimal depositTerm = decimal
                .Parse(DepositTermsGroupBox.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(el => el.Checked)
                .Tag.ToString());


            decimal finalAmount = CalculateFinalAmount(depositEntry, interestRate, depositTerm);
            ResultTextBox.Text = $"{finalAmount:C}";

        }

        private decimal CalculateFinalAmount(decimal depositEntry, decimal interestRate, decimal depositTerm)
        {
            return (depositEntry * (interestRate / 100) * depositTerm) + depositEntry;
        }
    }
}