using System;
using System.Windows.Forms;

namespace ScreenTest 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // When the MCU button is clicked, open Form2 for the MCU quiz
        private void btnMCU_Click(object sender, EventArgs e)
        {
            Form2 quizForm = new Form2("MCU"); // Pass the "MCU" category to Form2
            quizForm.Show(); // Show Form2
            this.Hide(); // Hide Form1
        }


        // When the Trivia button is clicked, open Form2 for the Trivia quiz
        private void btnTrivia_Click(object sender, EventArgs e)
        {
          
        }

        // When the Classic button is clicked, open Form2 for the Classic quiz
        private void btnClassic_Click(object sender, EventArgs e)
        {
           
        }

        // When the Animated button is clicked, open Form2 for the Animated quiz
        private void btnAnimated_Click(object sender, EventArgs e)
        {
          
        }
    }
}
