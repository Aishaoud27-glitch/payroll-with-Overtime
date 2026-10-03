namespace payroll_with_Overtime
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
            this.hoursWorkedLabe = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hoursPayRateLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorkedLabe
            // 
            this.hoursWorkedLabe.AutoSize = true;
            this.hoursWorkedLabe.Location = new System.Drawing.Point(85, 59);
            this.hoursWorkedLabe.Name = "hoursWorkedLabe";
            this.hoursWorkedLabe.Size = new System.Drawing.Size(112, 20);
            this.hoursWorkedLabe.TabIndex = 0;
            this.hoursWorkedLabe.Text = "hours Worked:";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(215, 53);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(165, 26);
            this.hoursWorkedTextBox.TabIndex = 1;
            // 
            // hoursPayRateLabel
            // 
            this.hoursPayRateLabel.AutoSize = true;
            this.hoursPayRateLabel.Location = new System.Drawing.Point(81, 118);
            this.hoursPayRateLabel.Name = "hoursPayRateLabel";
            this.hoursPayRateLabel.Size = new System.Drawing.Size(116, 20);
            this.hoursPayRateLabel.TabIndex = 2;
            this.hoursPayRateLabel.Text = "hourly pay rate:";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(215, 112);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(165, 26);
            this.hourlyPayRateTextBox.TabIndex = 3;
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(96, 175);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(85, 20);
            this.grossPayLabel.TabIndex = 4;
            this.grossPayLabel.Text = "Gross pay:";
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Location = new System.Drawing.Point(215, 175);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(165, 26);
            this.grossPayTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(50, 312);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 84);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Gross pay";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(183, 312);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 42);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 369);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 36);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursPayRateLabel);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hoursWorkedLabe);
            this.Name = "Form1";
            this.Text = " PAYROLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursWorkedLabe;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label hoursPayRateLabel;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

