namespace hm2_task2
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
            InputTextBox = new TextBox();
            ResultLabel = new Label();
            CountButton = new Button();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Dock = DockStyle.Bottom;
            InputTextBox.Location = new Point(0, 57);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(399, 27);
            InputTextBox.TabIndex = 0;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(12, 18);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 20);
            ResultLabel.TabIndex = 1;
            // 
            // CountButton
            // 
            CountButton.Dock = DockStyle.Right;
            CountButton.Location = new Point(305, 0);
            CountButton.Name = "CountButton";
            CountButton.Size = new Size(94, 57);
            CountButton.TabIndex = 2;
            CountButton.Text = "START";
            CountButton.UseVisualStyleBackColor = true;
            CountButton.Click += CountButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 84);
            Controls.Add(CountButton);
            Controls.Add(ResultLabel);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Label ResultLabel;
        private Button CountButton;
    }
}