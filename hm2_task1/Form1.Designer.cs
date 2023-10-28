namespace hm2_task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SelectionPanel = new Panel();
            pictureBox1 = new PictureBox();
            InterestRateGroupBox = new GroupBox();
            InterestRate16RadioButton = new RadioButton();
            InterestRate12RadioButton = new RadioButton();
            InterestRate8RadioButton = new RadioButton();
            InterestRate4RadioButton = new RadioButton();
            DepositTermsGroupBox = new GroupBox();
            DepositTerms24RadioButton = new RadioButton();
            DepositTerms12RadioButton = new RadioButton();
            DepositTerms6RadioButton = new RadioButton();
            DepositTerms3RadioButton = new RadioButton();
            DepositEntryNumeric = new NumericUpDown();
            DepositAmountLabel = new Label();
            panel1 = new Panel();
            ResultTextBox = new TextBox();
            CalculateButton = new Button();
            SelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            InterestRateGroupBox.SuspendLayout();
            DepositTermsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DepositEntryNumeric).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectionPanel
            // 
            SelectionPanel.BackColor = Color.Ivory;
            SelectionPanel.Controls.Add(pictureBox1);
            SelectionPanel.Controls.Add(InterestRateGroupBox);
            SelectionPanel.Controls.Add(DepositTermsGroupBox);
            SelectionPanel.Controls.Add(DepositEntryNumeric);
            SelectionPanel.Controls.Add(DepositAmountLabel);
            SelectionPanel.Dock = DockStyle.Top;
            SelectionPanel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SelectionPanel.ForeColor = Color.Navy;
            SelectionPanel.Location = new Point(0, 0);
            SelectionPanel.Name = "SelectionPanel";
            SelectionPanel.Size = new Size(558, 405);
            SelectionPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // InterestRateGroupBox
            // 
            InterestRateGroupBox.Controls.Add(InterestRate16RadioButton);
            InterestRateGroupBox.Controls.Add(InterestRate12RadioButton);
            InterestRateGroupBox.Controls.Add(InterestRate8RadioButton);
            InterestRateGroupBox.Controls.Add(InterestRate4RadioButton);
            InterestRateGroupBox.ForeColor = Color.Black;
            InterestRateGroupBox.Location = new Point(284, 133);
            InterestRateGroupBox.Name = "InterestRateGroupBox";
            InterestRateGroupBox.Size = new Size(257, 252);
            InterestRateGroupBox.TabIndex = 5;
            InterestRateGroupBox.TabStop = false;
            InterestRateGroupBox.Text = "Interest Rate:";
            // 
            // InterestRate16RadioButton
            // 
            InterestRate16RadioButton.AutoSize = true;
            InterestRate16RadioButton.ForeColor = Color.Navy;
            InterestRate16RadioButton.Location = new Point(6, 199);
            InterestRate16RadioButton.Name = "InterestRate16RadioButton";
            InterestRate16RadioButton.Size = new Size(233, 45);
            InterestRate16RadioButton.TabIndex = 7;
            InterestRate16RadioButton.TabStop = true;
            InterestRate16RadioButton.Tag = "16";
            InterestRate16RadioButton.Text = "16% of wages";
            InterestRate16RadioButton.UseVisualStyleBackColor = true;
            // 
            // InterestRate12RadioButton
            // 
            InterestRate12RadioButton.AutoSize = true;
            InterestRate12RadioButton.ForeColor = Color.Navy;
            InterestRate12RadioButton.Location = new Point(6, 148);
            InterestRate12RadioButton.Name = "InterestRate12RadioButton";
            InterestRate12RadioButton.Size = new Size(233, 45);
            InterestRate12RadioButton.TabIndex = 6;
            InterestRate12RadioButton.TabStop = true;
            InterestRate12RadioButton.Tag = "12";
            InterestRate12RadioButton.Text = "12% of wages";
            InterestRate12RadioButton.UseVisualStyleBackColor = true;
            // 
            // InterestRate8RadioButton
            // 
            InterestRate8RadioButton.AutoSize = true;
            InterestRate8RadioButton.ForeColor = Color.Navy;
            InterestRate8RadioButton.Location = new Point(6, 97);
            InterestRate8RadioButton.Name = "InterestRate8RadioButton";
            InterestRate8RadioButton.Size = new Size(216, 45);
            InterestRate8RadioButton.TabIndex = 5;
            InterestRate8RadioButton.TabStop = true;
            InterestRate8RadioButton.Tag = "8";
            InterestRate8RadioButton.Text = "8% of wages";
            InterestRate8RadioButton.UseVisualStyleBackColor = true;
            // 
            // InterestRate4RadioButton
            // 
            InterestRate4RadioButton.AutoSize = true;
            InterestRate4RadioButton.ForeColor = Color.Navy;
            InterestRate4RadioButton.Location = new Point(6, 46);
            InterestRate4RadioButton.Name = "InterestRate4RadioButton";
            InterestRate4RadioButton.Size = new Size(216, 45);
            InterestRate4RadioButton.TabIndex = 4;
            InterestRate4RadioButton.TabStop = true;
            InterestRate4RadioButton.Tag = "4";
            InterestRate4RadioButton.Text = "4% of wages";
            InterestRate4RadioButton.UseVisualStyleBackColor = true;
            // 
            // DepositTermsGroupBox
            // 
            DepositTermsGroupBox.Controls.Add(DepositTerms24RadioButton);
            DepositTermsGroupBox.Controls.Add(DepositTerms12RadioButton);
            DepositTermsGroupBox.Controls.Add(DepositTerms6RadioButton);
            DepositTermsGroupBox.Controls.Add(DepositTerms3RadioButton);
            DepositTermsGroupBox.ForeColor = Color.Black;
            DepositTermsGroupBox.Location = new Point(12, 133);
            DepositTermsGroupBox.Name = "DepositTermsGroupBox";
            DepositTermsGroupBox.Size = new Size(257, 252);
            DepositTermsGroupBox.TabIndex = 4;
            DepositTermsGroupBox.TabStop = false;
            DepositTermsGroupBox.Text = "Deposit Terms:";
            // 
            // DepositTerms24RadioButton
            // 
            DepositTerms24RadioButton.AutoSize = true;
            DepositTerms24RadioButton.ForeColor = Color.Navy;
            DepositTerms24RadioButton.Location = new Point(6, 199);
            DepositTerms24RadioButton.Name = "DepositTerms24RadioButton";
            DepositTerms24RadioButton.Size = new Size(203, 45);
            DepositTerms24RadioButton.TabIndex = 3;
            DepositTerms24RadioButton.TabStop = true;
            DepositTerms24RadioButton.Tag = "24";
            DepositTerms24RadioButton.Text = "24 monthes";
            DepositTerms24RadioButton.UseVisualStyleBackColor = true;
            // 
            // DepositTerms12RadioButton
            // 
            DepositTerms12RadioButton.AutoSize = true;
            DepositTerms12RadioButton.ForeColor = Color.Navy;
            DepositTerms12RadioButton.Location = new Point(6, 148);
            DepositTerms12RadioButton.Name = "DepositTerms12RadioButton";
            DepositTerms12RadioButton.Size = new Size(203, 45);
            DepositTerms12RadioButton.TabIndex = 2;
            DepositTerms12RadioButton.TabStop = true;
            DepositTerms12RadioButton.Tag = "12";
            DepositTerms12RadioButton.Text = "12 monthes";
            DepositTerms12RadioButton.UseVisualStyleBackColor = true;
            // 
            // DepositTerms6RadioButton
            // 
            DepositTerms6RadioButton.AutoSize = true;
            DepositTerms6RadioButton.ForeColor = Color.Navy;
            DepositTerms6RadioButton.Location = new Point(6, 97);
            DepositTerms6RadioButton.Name = "DepositTerms6RadioButton";
            DepositTerms6RadioButton.Size = new Size(186, 45);
            DepositTerms6RadioButton.TabIndex = 1;
            DepositTerms6RadioButton.TabStop = true;
            DepositTerms6RadioButton.Tag = "6";
            DepositTerms6RadioButton.Text = "6 monthes";
            DepositTerms6RadioButton.UseVisualStyleBackColor = true;
            // 
            // DepositTerms3RadioButton
            // 
            DepositTerms3RadioButton.AutoSize = true;
            DepositTerms3RadioButton.ForeColor = Color.Navy;
            DepositTerms3RadioButton.Location = new Point(6, 46);
            DepositTerms3RadioButton.Name = "DepositTerms3RadioButton";
            DepositTerms3RadioButton.Size = new Size(186, 45);
            DepositTerms3RadioButton.TabIndex = 0;
            DepositTerms3RadioButton.TabStop = true;
            DepositTerms3RadioButton.Tag = "3";
            DepositTerms3RadioButton.Text = "3 monthes";
            DepositTerms3RadioButton.UseVisualStyleBackColor = true;
            // 
            // DepositEntryNumeric
            // 
            DepositEntryNumeric.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            DepositEntryNumeric.ForeColor = Color.Navy;
            DepositEntryNumeric.Location = new Point(284, 84);
            DepositEntryNumeric.Name = "DepositEntryNumeric";
            DepositEntryNumeric.Size = new Size(257, 38);
            DepositEntryNumeric.TabIndex = 2;
            DepositEntryNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // DepositAmountLabel
            // 
            DepositAmountLabel.AutoSize = true;
            DepositAmountLabel.ForeColor = Color.Black;
            DepositAmountLabel.Location = new Point(284, 40);
            DepositAmountLabel.Name = "DepositAmountLabel";
            DepositAmountLabel.Size = new Size(257, 41);
            DepositAmountLabel.TabIndex = 0;
            DepositAmountLabel.Text = "Deposit Amount:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(ResultTextBox);
            panel1.Controls.Add(CalculateButton);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 405);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 60);
            panel1.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            ResultTextBox.BackColor = Color.PaleGoldenrod;
            ResultTextBox.BorderStyle = BorderStyle.None;
            ResultTextBox.Dock = DockStyle.Fill;
            ResultTextBox.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ResultTextBox.ForeColor = Color.Navy;
            ResultTextBox.Location = new Point(0, 0);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(357, 60);
            ResultTextBox.TabIndex = 1;
            ResultTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.Navy;
            CalculateButton.Dock = DockStyle.Right;
            CalculateButton.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateButton.ForeColor = Color.Gold;
            CalculateButton.Location = new Point(357, 0);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(201, 60);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "CALCULATE";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 465);
            Controls.Add(panel1);
            Controls.Add(SelectionPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Investment Calculator";
            SelectionPanel.ResumeLayout(false);
            SelectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            InterestRateGroupBox.ResumeLayout(false);
            InterestRateGroupBox.PerformLayout();
            DepositTermsGroupBox.ResumeLayout(false);
            DepositTermsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DepositEntryNumeric).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SelectionPanel;
        private Label DepositAmountLabel;
        private NumericUpDown DepositEntryNumeric;
        private GroupBox DepositTermsGroupBox;
        private GroupBox InterestRateGroupBox;
        private RadioButton DepositTerms12RadioButton;
        private RadioButton DepositTerms6RadioButton;
        private RadioButton DepositTerms3RadioButton;
        private RadioButton DepositTerms24RadioButton;
        private Panel panel1;
        private Button CalculateButton;
        private TextBox ResultTextBox;
        private PictureBox pictureBox1;
        private RadioButton InterestRate16RadioButton;
        private RadioButton InterestRate12RadioButton;
        private RadioButton InterestRate8RadioButton;
        private RadioButton InterestRate4RadioButton;
    }
}