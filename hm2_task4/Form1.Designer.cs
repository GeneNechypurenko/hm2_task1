namespace hm2_task4
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
            TextLable = new Label();
            FileLable = new Label();
            InputTextBox = new TextBox();
            FileNameTextBox = new TextBox();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // TextLable
            // 
            TextLable.AutoSize = true;
            TextLable.Location = new Point(12, 33);
            TextLable.Name = "TextLable";
            TextLable.Size = new Size(43, 20);
            TextLable.TabIndex = 0;
            TextLable.Text = "Text:";
            // 
            // FileLable
            // 
            FileLable.AutoSize = true;
            FileLable.Location = new Point(12, 72);
            FileLable.Name = "FileLable";
            FileLable.Size = new Size(37, 20);
            FileLable.TabIndex = 1;
            FileLable.Text = "File:";
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(61, 30);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(232, 27);
            InputTextBox.TabIndex = 2;
            // 
            // FileNameTextBox
            // 
            FileNameTextBox.Location = new Point(61, 69);
            FileNameTextBox.Name = "FileNameTextBox";
            FileNameTextBox.Size = new Size(232, 27);
            FileNameTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(115, 123);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 164);
            Controls.Add(SaveButton);
            Controls.Add(FileNameTextBox);
            Controls.Add(InputTextBox);
            Controls.Add(FileLable);
            Controls.Add(TextLable);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextLable;
        private Label FileLable;
        private TextBox InputTextBox;
        private TextBox FileNameTextBox;
        private Button SaveButton;
    }
}