namespace Ederson_Cardoso_Exercise01
{
    partial class AsynchronousProgrammingForm
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
            this.CalculateAsynchronouslyGroupBox = new System.Windows.Forms.GroupBox();
            this.FactorialResultLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.GetFactorialOfTextBox = new System.Windows.Forms.TextBox();
            this.GetFactorialofLabel = new System.Windows.Forms.Label();
            this.CheckEvenOddGroupBox = new System.Windows.Forms.GroupBox();
            this.EvenOddResultLabel = new System.Windows.Forms.Label();
            this.CheckEvenOddButton = new System.Windows.Forms.Button();
            this.InputNumberTextBox = new System.Windows.Forms.TextBox();
            this.InputNumberLabel = new System.Windows.Forms.Label();
            this.DisplayListOfValuesAndSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OutputValuesBetweenLowHighTextBox = new System.Windows.Forms.TextBox();
            this.OutputOfValuesBetweenLowAndHighLabel = new System.Windows.Forms.Label();
            this.InputHighIndexLabel = new System.Windows.Forms.Label();
            this.InputLowIndexLabel = new System.Windows.Forms.Label();
            this.InputValueForSearchLabel = new System.Windows.Forms.Label();
            this.InputHighIndexTextBox = new System.Windows.Forms.TextBox();
            this.InputLowIndexTextBox = new System.Windows.Forms.TextBox();
            this.InputSearchValueTextBox = new System.Windows.Forms.TextBox();
            this.GenerateValuesButton = new System.Windows.Forms.Button();
            this.CharRadioButton = new System.Windows.Forms.RadioButton();
            this.DoublesRadioButton = new System.Windows.Forms.RadioButton();
            this.IntegersRadioButton = new System.Windows.Forms.RadioButton();
            this.GeneratedValuesListBox = new System.Windows.Forms.ListBox();
            this.CalculateAsynchronouslyGroupBox.SuspendLayout();
            this.CheckEvenOddGroupBox.SuspendLayout();
            this.DisplayListOfValuesAndSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateAsynchronouslyGroupBox
            // 
            this.CalculateAsynchronouslyGroupBox.Controls.Add(this.FactorialResultLabel);
            this.CalculateAsynchronouslyGroupBox.Controls.Add(this.CalculateButton);
            this.CalculateAsynchronouslyGroupBox.Controls.Add(this.GetFactorialOfTextBox);
            this.CalculateAsynchronouslyGroupBox.Controls.Add(this.GetFactorialofLabel);
            this.CalculateAsynchronouslyGroupBox.Location = new System.Drawing.Point(13, 13);
            this.CalculateAsynchronouslyGroupBox.Name = "CalculateAsynchronouslyGroupBox";
            this.CalculateAsynchronouslyGroupBox.Size = new System.Drawing.Size(237, 141);
            this.CalculateAsynchronouslyGroupBox.TabIndex = 0;
            this.CalculateAsynchronouslyGroupBox.TabStop = false;
            this.CalculateAsynchronouslyGroupBox.Text = "(1) Calculate Asynchronously";
            // 
            // FactorialResultLabel
            // 
            this.FactorialResultLabel.AutoSize = true;
            this.FactorialResultLabel.Location = new System.Drawing.Point(12, 110);
            this.FactorialResultLabel.Name = "FactorialResultLabel";
            this.FactorialResultLabel.Size = new System.Drawing.Size(0, 13);
            this.FactorialResultLabel.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(14, 55);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(180, 35);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // GetFactorialOfTextBox
            // 
            this.GetFactorialOfTextBox.Location = new System.Drawing.Point(95, 23);
            this.GetFactorialOfTextBox.Name = "GetFactorialOfTextBox";
            this.GetFactorialOfTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetFactorialOfTextBox.TabIndex = 1;
            this.GetFactorialOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GetFactorialOfTextBox_KeyPress);
            // 
            // GetFactorialofLabel
            // 
            this.GetFactorialofLabel.AutoSize = true;
            this.GetFactorialofLabel.Location = new System.Drawing.Point(7, 25);
            this.GetFactorialofLabel.Name = "GetFactorialofLabel";
            this.GetFactorialofLabel.Size = new System.Drawing.Size(82, 13);
            this.GetFactorialofLabel.TabIndex = 0;
            this.GetFactorialofLabel.Text = "Get Factorial of:";
            // 
            // CheckEvenOddGroupBox
            // 
            this.CheckEvenOddGroupBox.Controls.Add(this.EvenOddResultLabel);
            this.CheckEvenOddGroupBox.Controls.Add(this.CheckEvenOddButton);
            this.CheckEvenOddGroupBox.Controls.Add(this.InputNumberTextBox);
            this.CheckEvenOddGroupBox.Controls.Add(this.InputNumberLabel);
            this.CheckEvenOddGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckEvenOddGroupBox.Location = new System.Drawing.Point(13, 168);
            this.CheckEvenOddGroupBox.Name = "CheckEvenOddGroupBox";
            this.CheckEvenOddGroupBox.Size = new System.Drawing.Size(238, 157);
            this.CheckEvenOddGroupBox.TabIndex = 1;
            this.CheckEvenOddGroupBox.TabStop = false;
            this.CheckEvenOddGroupBox.Text = "(2) Chech for Even/Odd";
            // 
            // EvenOddResultLabel
            // 
            this.EvenOddResultLabel.AutoSize = true;
            this.EvenOddResultLabel.Location = new System.Drawing.Point(12, 120);
            this.EvenOddResultLabel.Name = "EvenOddResultLabel";
            this.EvenOddResultLabel.Size = new System.Drawing.Size(0, 13);
            this.EvenOddResultLabel.TabIndex = 4;
            // 
            // CheckEvenOddButton
            // 
            this.CheckEvenOddButton.Location = new System.Drawing.Point(15, 63);
            this.CheckEvenOddButton.Name = "CheckEvenOddButton";
            this.CheckEvenOddButton.Size = new System.Drawing.Size(180, 35);
            this.CheckEvenOddButton.TabIndex = 3;
            this.CheckEvenOddButton.Text = "Check for Even or Odd";
            this.CheckEvenOddButton.UseVisualStyleBackColor = true;
            this.CheckEvenOddButton.Click += new System.EventHandler(this.CheckEvenOddButton_Click);
            // 
            // InputNumberTextBox
            // 
            this.InputNumberTextBox.Location = new System.Drawing.Point(96, 27);
            this.InputNumberTextBox.Name = "InputNumberTextBox";
            this.InputNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputNumberTextBox.TabIndex = 3;
            this.InputNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputNumberTextBox_KeyPress);
            // 
            // InputNumberLabel
            // 
            this.InputNumberLabel.AutoSize = true;
            this.InputNumberLabel.Location = new System.Drawing.Point(8, 30);
            this.InputNumberLabel.Name = "InputNumberLabel";
            this.InputNumberLabel.Size = new System.Drawing.Size(74, 13);
            this.InputNumberLabel.TabIndex = 3;
            this.InputNumberLabel.Text = "Input Number:";
            // 
            // DisplayListOfValuesAndSearchGroupBox
            // 
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.GeneratedValuesListBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.DisplayButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.SearchButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.OutputValuesBetweenLowHighTextBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.OutputOfValuesBetweenLowAndHighLabel);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputHighIndexLabel);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputLowIndexLabel);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputValueForSearchLabel);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputHighIndexTextBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputLowIndexTextBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.InputSearchValueTextBox);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.GenerateValuesButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.CharRadioButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.DoublesRadioButton);
            this.DisplayListOfValuesAndSearchGroupBox.Controls.Add(this.IntegersRadioButton);
            this.DisplayListOfValuesAndSearchGroupBox.Location = new System.Drawing.Point(268, 13);
            this.DisplayListOfValuesAndSearchGroupBox.Name = "DisplayListOfValuesAndSearchGroupBox";
            this.DisplayListOfValuesAndSearchGroupBox.Size = new System.Drawing.Size(404, 312);
            this.DisplayListOfValuesAndSearchGroupBox.TabIndex = 2;
            this.DisplayListOfValuesAndSearchGroupBox.TabStop = false;
            this.DisplayListOfValuesAndSearchGroupBox.Text = "(3) Display List of Values and Search";
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(314, 155);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 12;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(314, 100);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OutputValuesBetweenLowHighTextBox
            // 
            this.OutputValuesBetweenLowHighTextBox.Location = new System.Drawing.Point(70, 247);
            this.OutputValuesBetweenLowHighTextBox.Multiline = true;
            this.OutputValuesBetweenLowHighTextBox.Name = "OutputValuesBetweenLowHighTextBox";
            this.OutputValuesBetweenLowHighTextBox.Size = new System.Drawing.Size(319, 49);
            this.OutputValuesBetweenLowHighTextBox.TabIndex = 3;
            // 
            // OutputOfValuesBetweenLowAndHighLabel
            // 
            this.OutputOfValuesBetweenLowAndHighLabel.AutoSize = true;
            this.OutputOfValuesBetweenLowAndHighLabel.Location = new System.Drawing.Point(67, 231);
            this.OutputOfValuesBetweenLowAndHighLabel.Name = "OutputOfValuesBetweenLowAndHighLabel";
            this.OutputOfValuesBetweenLowAndHighLabel.Size = new System.Drawing.Size(201, 13);
            this.OutputOfValuesBetweenLowAndHighLabel.TabIndex = 10;
            this.OutputOfValuesBetweenLowAndHighLabel.Text = "Output of values between Low and High:";
            // 
            // InputHighIndexLabel
            // 
            this.InputHighIndexLabel.AutoSize = true;
            this.InputHighIndexLabel.Location = new System.Drawing.Point(98, 182);
            this.InputHighIndexLabel.Name = "InputHighIndexLabel";
            this.InputHighIndexLabel.Size = new System.Drawing.Size(88, 13);
            this.InputHighIndexLabel.TabIndex = 9;
            this.InputHighIndexLabel.Text = "Input High Index:";
            // 
            // InputLowIndexLabel
            // 
            this.InputLowIndexLabel.AutoSize = true;
            this.InputLowIndexLabel.Location = new System.Drawing.Point(98, 138);
            this.InputLowIndexLabel.Name = "InputLowIndexLabel";
            this.InputLowIndexLabel.Size = new System.Drawing.Size(86, 13);
            this.InputLowIndexLabel.TabIndex = 8;
            this.InputLowIndexLabel.Text = "Input Low Index:";
            // 
            // InputValueForSearchLabel
            // 
            this.InputValueForSearchLabel.AutoSize = true;
            this.InputValueForSearchLabel.Location = new System.Drawing.Point(67, 103);
            this.InputValueForSearchLabel.Name = "InputValueForSearchLabel";
            this.InputValueForSearchLabel.Size = new System.Drawing.Size(116, 13);
            this.InputValueForSearchLabel.TabIndex = 7;
            this.InputValueForSearchLabel.Text = "Input Value for Search:";
            // 
            // InputHighIndexTextBox
            // 
            this.InputHighIndexTextBox.Location = new System.Drawing.Point(189, 179);
            this.InputHighIndexTextBox.Name = "InputHighIndexTextBox";
            this.InputHighIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputHighIndexTextBox.TabIndex = 6;
            this.InputHighIndexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputHighIndexTextBox_KeyPress);
            // 
            // InputLowIndexTextBox
            // 
            this.InputLowIndexTextBox.Location = new System.Drawing.Point(189, 135);
            this.InputLowIndexTextBox.Name = "InputLowIndexTextBox";
            this.InputLowIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputLowIndexTextBox.TabIndex = 5;
            this.InputLowIndexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputLowIndexTextBox_KeyPress);
            // 
            // InputSearchValueTextBox
            // 
            this.InputSearchValueTextBox.Location = new System.Drawing.Point(189, 100);
            this.InputSearchValueTextBox.Name = "InputSearchValueTextBox";
            this.InputSearchValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputSearchValueTextBox.TabIndex = 3;
            // 
            // GenerateValuesButton
            // 
            this.GenerateValuesButton.Location = new System.Drawing.Point(280, 21);
            this.GenerateValuesButton.Name = "GenerateValuesButton";
            this.GenerateValuesButton.Size = new System.Drawing.Size(109, 23);
            this.GenerateValuesButton.TabIndex = 3;
            this.GenerateValuesButton.Text = "Generate Values";
            this.GenerateValuesButton.UseVisualStyleBackColor = true;
            this.GenerateValuesButton.Click += new System.EventHandler(this.GenerateValuesButton_Click);
            // 
            // CharRadioButton
            // 
            this.CharRadioButton.AutoSize = true;
            this.CharRadioButton.Location = new System.Drawing.Point(189, 23);
            this.CharRadioButton.Name = "CharRadioButton";
            this.CharRadioButton.Size = new System.Drawing.Size(47, 17);
            this.CharRadioButton.TabIndex = 2;
            this.CharRadioButton.TabStop = true;
            this.CharRadioButton.Text = "Char";
            this.CharRadioButton.UseVisualStyleBackColor = true;
            // 
            // DoublesRadioButton
            // 
            this.DoublesRadioButton.AutoSize = true;
            this.DoublesRadioButton.Location = new System.Drawing.Point(98, 23);
            this.DoublesRadioButton.Name = "DoublesRadioButton";
            this.DoublesRadioButton.Size = new System.Drawing.Size(64, 17);
            this.DoublesRadioButton.TabIndex = 1;
            this.DoublesRadioButton.TabStop = true;
            this.DoublesRadioButton.Text = "Doubles";
            this.DoublesRadioButton.UseVisualStyleBackColor = true;
            // 
            // IntegersRadioButton
            // 
            this.IntegersRadioButton.AutoSize = true;
            this.IntegersRadioButton.Location = new System.Drawing.Point(7, 22);
            this.IntegersRadioButton.Name = "IntegersRadioButton";
            this.IntegersRadioButton.Size = new System.Drawing.Size(63, 17);
            this.IntegersRadioButton.TabIndex = 0;
            this.IntegersRadioButton.TabStop = true;
            this.IntegersRadioButton.Text = "Integers";
            this.IntegersRadioButton.UseVisualStyleBackColor = true;
            // 
            // GeneratedValuesListBox
            // 
            this.GeneratedValuesListBox.FormattingEnabled = true;
            this.GeneratedValuesListBox.Location = new System.Drawing.Point(6, 71);
            this.GeneratedValuesListBox.Name = "GeneratedValuesListBox";
            this.GeneratedValuesListBox.Size = new System.Drawing.Size(43, 225);
            this.GeneratedValuesListBox.TabIndex = 13;
            // 
            // AsynchronousProgrammingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 341);
            this.Controls.Add(this.DisplayListOfValuesAndSearchGroupBox);
            this.Controls.Add(this.CheckEvenOddGroupBox);
            this.Controls.Add(this.CalculateAsynchronouslyGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AsynchronousProgrammingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asynchronous Programming";
            this.CalculateAsynchronouslyGroupBox.ResumeLayout(false);
            this.CalculateAsynchronouslyGroupBox.PerformLayout();
            this.CheckEvenOddGroupBox.ResumeLayout(false);
            this.CheckEvenOddGroupBox.PerformLayout();
            this.DisplayListOfValuesAndSearchGroupBox.ResumeLayout(false);
            this.DisplayListOfValuesAndSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CalculateAsynchronouslyGroupBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox GetFactorialOfTextBox;
        private System.Windows.Forms.Label GetFactorialofLabel;
        private System.Windows.Forms.GroupBox CheckEvenOddGroupBox;
        private System.Windows.Forms.TextBox InputNumberTextBox;
        private System.Windows.Forms.Label InputNumberLabel;
        private System.Windows.Forms.GroupBox DisplayListOfValuesAndSearchGroupBox;
        private System.Windows.Forms.Button GenerateValuesButton;
        private System.Windows.Forms.RadioButton CharRadioButton;
        private System.Windows.Forms.RadioButton DoublesRadioButton;
        private System.Windows.Forms.RadioButton IntegersRadioButton;
        private System.Windows.Forms.Button CheckEvenOddButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox OutputValuesBetweenLowHighTextBox;
        private System.Windows.Forms.Label OutputOfValuesBetweenLowAndHighLabel;
        private System.Windows.Forms.Label InputHighIndexLabel;
        private System.Windows.Forms.Label InputLowIndexLabel;
        private System.Windows.Forms.Label InputValueForSearchLabel;
        private System.Windows.Forms.TextBox InputHighIndexTextBox;
        private System.Windows.Forms.TextBox InputLowIndexTextBox;
        private System.Windows.Forms.TextBox InputSearchValueTextBox;
        private System.Windows.Forms.Label FactorialResultLabel;
        private System.Windows.Forms.Label EvenOddResultLabel;
        private System.Windows.Forms.ListBox GeneratedValuesListBox;
    }
}

