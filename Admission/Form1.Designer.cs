namespace Admission
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
            txtGPA = new TextBox();
            txtTestScore = new TextBox();
            submitButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(116, 155);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(150, 31);
            txtGPA.TabIndex = 0;
            txtGPA.Text = "GPA";
            // 
            // txtTestScore
            // 
            txtTestScore.Location = new Point(306, 155);
            txtTestScore.Name = "txtTestScore";
            txtTestScore.Size = new Size(150, 31);
            txtTestScore.TabIndex = 1;
            txtTestScore.Text = "Test Score";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(259, 263);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(112, 34);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(618, 234);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(59, 25);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(submitButton);
            Controls.Add(txtTestScore);
            Controls.Add(txtGPA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGPA;
        private TextBox txtTestScore;
        private Button submitButton;
        private Label resultLabel;
    }
}
