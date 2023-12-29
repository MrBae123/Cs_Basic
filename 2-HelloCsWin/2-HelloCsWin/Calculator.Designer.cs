namespace _2_HelloCsWin
{
    partial class Calculator
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
            HelloLabel = new Label();
            Sum1 = new TextBox();
            Sum2 = new TextBox();
            SumNumbers = new Button();
            SumResult = new TextBox();
            SuspendLayout();
            // 
            // HelloLabel
            // 
            HelloLabel.AutoSize = true;
            HelloLabel.Cursor = Cursors.Hand;
            HelloLabel.Location = new Point(75, 43);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.Size = new Size(188, 30);
            HelloLabel.TabIndex = 0;
            HelloLabel.Text = "여기를 클릭하세요";
            HelloLabel.Click += HelloLabel_Click;
            // 
            // Sum1
            // 
            Sum1.Location = new Point(33, 121);
            Sum1.Name = "Sum1";
            Sum1.Size = new Size(175, 35);
            Sum1.TabIndex = 1;
            Sum1.TextChanged += Number1_TextChanged;
            // 
            // Sum2
            // 
            Sum2.Location = new Point(261, 121);
            Sum2.Name = "Sum2";
            Sum2.Size = new Size(175, 35);
            Sum2.TabIndex = 2;
            // 
            // SumNumbers
            // 
            SumNumbers.Location = new Point(468, 119);
            SumNumbers.Name = "SumNumbers";
            SumNumbers.Size = new Size(131, 40);
            SumNumbers.TabIndex = 3;
            SumNumbers.Text = "=";
            SumNumbers.UseVisualStyleBackColor = true;
            SumNumbers.Click += SumNumbers_Click;
            // 
            // SumResult
            // 
            SumResult.Location = new Point(632, 121);
            SumResult.Name = "SumResult";
            SumResult.Size = new Size(175, 35);
            SumResult.TabIndex = 4;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 778);
            Controls.Add(SumResult);
            Controls.Add(SumNumbers);
            Controls.Add(Sum2);
            Controls.Add(Sum1);
            Controls.Add(HelloLabel);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HelloLabel;
        private TextBox Sum1;
        private TextBox Sum2;
        private Button SumNumbers;
        private TextBox SumResult;
    }
}