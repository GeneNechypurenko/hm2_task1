namespace hm2_task3
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
            StartButton = new Button();
            EvenListBox = new ListBox();
            OddListBox = new ListBox();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Dock = DockStyle.Bottom;
            StartButton.Location = new Point(0, 240);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(480, 29);
            StartButton.TabIndex = 0;
            StartButton.Text = "START";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // EvenListBox
            // 
            EvenListBox.Dock = DockStyle.Left;
            EvenListBox.ForeColor = SystemColors.ControlText;
            EvenListBox.FormattingEnabled = true;
            EvenListBox.ItemHeight = 20;
            EvenListBox.Location = new Point(0, 0);
            EvenListBox.Name = "EvenListBox";
            EvenListBox.Size = new Size(240, 240);
            EvenListBox.TabIndex = 1;
            // 
            // OddListBox
            // 
            OddListBox.Dock = DockStyle.Fill;
            OddListBox.FormattingEnabled = true;
            OddListBox.ItemHeight = 20;
            OddListBox.Location = new Point(240, 0);
            OddListBox.Name = "OddListBox";
            OddListBox.Size = new Size(240, 240);
            OddListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 269);
            Controls.Add(OddListBox);
            Controls.Add(EvenListBox);
            Controls.Add(StartButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private ListBox EvenListBox;
        private ListBox OddListBox;
    }
}