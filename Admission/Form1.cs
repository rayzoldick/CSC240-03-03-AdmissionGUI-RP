namespace Admission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            double gpa = double.Parse(txtGPA.Text);
            int testScore = int.Parse(txtTestScore.Text);

            if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80))
            {
                resultLabel.Text = "Accept";

            }
            else
            {
                resultLabel.Text = "Reject";

            }
        }
    }
}

            
        
