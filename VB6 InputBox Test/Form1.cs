using VB6InputBox;

namespace VB6_InputBox_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            using InputBox vB6InputBox = new InputBox("Required method for Designer support. Do not modify the contents of this method with the code editor.", "Enter your name:");
            if (vB6InputBox.form.DialogResult == DialogResult.OK)
            {
                string userInput = vB6InputBox.Value;
                MessageBox.Show($"You entered: {userInput}", "Input Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Input was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
