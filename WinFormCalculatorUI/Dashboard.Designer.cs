namespace WinFormCalculatorUI
{
    partial class Dashboard
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
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addNumbersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.firstNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberLabel.Location = new System.Drawing.Point(14, 95);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(141, 25);
            this.firstNumberLabel.TabIndex = 0;
            this.firstNumberLabel.Text = "First Number:";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberLabel.Location = new System.Drawing.Point(14, 136);
            this.secondNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(172, 25);
            this.secondNumberLabel.TabIndex = 1;
            this.secondNumberLabel.Text = "Second Number:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(309, 42);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Simple Calculator";
            // 
            // addNumbersButton
            // 
            this.addNumbersButton.AutoSize = true;
            this.addNumbersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNumbersButton.Location = new System.Drawing.Point(19, 190);
            this.addNumbersButton.Name = "addNumbersButton";
            this.addNumbersButton.Size = new System.Drawing.Size(94, 35);
            this.addNumbersButton.TabIndex = 5;
            this.addNumbersButton.Text = "Add";
            this.addNumbersButton.UseVisualStyleBackColor = true;
            this.addNumbersButton.Click += new System.EventHandler(this.addNumbersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(191, 244);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(100, 31);
            this.resultTextBox.TabIndex = 7;
            // 
            // firstNumberNumericUpDown
            // 
            this.firstNumberNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberNumericUpDown.Location = new System.Drawing.Point(191, 93);
            this.firstNumberNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.firstNumberNumericUpDown.Name = "firstNumberNumericUpDown";
            this.firstNumberNumericUpDown.Size = new System.Drawing.Size(100, 31);
            this.firstNumberNumericUpDown.TabIndex = 8;
            // 
            // secondNumberNumericUpDown
            // 
            this.secondNumberNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberNumericUpDown.Location = new System.Drawing.Point(191, 134);
            this.secondNumberNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.secondNumberNumericUpDown.Name = "secondNumberNumericUpDown";
            this.secondNumberNumericUpDown.Size = new System.Drawing.Size(100, 31);
            this.secondNumberNumericUpDown.TabIndex = 9;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 319);
            this.Controls.Add(this.secondNumberNumericUpDown);
            this.Controls.Add(this.firstNumberNumericUpDown);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNumbersButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.firstNumberLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Simple Calculator by Chane Du Toit";
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addNumbersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.NumericUpDown firstNumberNumericUpDown;
        private System.Windows.Forms.NumericUpDown secondNumberNumericUpDown;
    }
}

