namespace Morse_Code_Converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.morseCodeOutput = new System.Windows.Forms.TextBox();
            this.morseLabel = new System.Windows.Forms.Label();
            this.morseLabel2 = new System.Windows.Forms.Label();
            this.morseLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(39, 338);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(165, 78);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert Into Morse Code!";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(274, 338);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(165, 78);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(497, 338);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(165, 78);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(39, 166);
            this.userInputTextBox.Multiline = true;
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(296, 122);
            this.userInputTextBox.TabIndex = 3;
            // 
            // morseCodeOutput
            // 
            this.morseCodeOutput.Location = new System.Drawing.Point(366, 166);
            this.morseCodeOutput.Multiline = true;
            this.morseCodeOutput.Name = "morseCodeOutput";
            this.morseCodeOutput.ReadOnly = true;
            this.morseCodeOutput.Size = new System.Drawing.Size(296, 122);
            this.morseCodeOutput.TabIndex = 4;
            // 
            // morseLabel
            // 
            this.morseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseLabel.Location = new System.Drawing.Point(217, 36);
            this.morseLabel.Name = "morseLabel";
            this.morseLabel.Size = new System.Drawing.Size(280, 38);
            this.morseLabel.TabIndex = 5;
            this.morseLabel.Text = "Morse Code Converter";
            // 
            // morseLabel2
            // 
            this.morseLabel2.AutoSize = true;
            this.morseLabel2.Location = new System.Drawing.Point(36, 131);
            this.morseLabel2.Name = "morseLabel2";
            this.morseLabel2.Size = new System.Drawing.Size(295, 17);
            this.morseLabel2.TabIndex = 6;
            this.morseLabel2.Text = "Enter the text to be converted to Morse Code:";
            // 
            // morseLabel3
            // 
            this.morseLabel3.AutoSize = true;
            this.morseLabel3.Location = new System.Drawing.Point(367, 131);
            this.morseLabel3.Name = "morseLabel3";
            this.morseLabel3.Size = new System.Drawing.Size(173, 17);
            this.morseLabel3.TabIndex = 7;
            this.morseLabel3.Text = "Converted to Morse Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.morseLabel3);
            this.Controls.Add(this.morseLabel2);
            this.Controls.Add(this.morseLabel);
            this.Controls.Add(this.morseCodeOutput);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Morse Code Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.TextBox morseCodeOutput;
        private System.Windows.Forms.Label morseLabel;
        private System.Windows.Forms.Label morseLabel2;
        private System.Windows.Forms.Label morseLabel3;
    }
}

