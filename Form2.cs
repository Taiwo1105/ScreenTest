using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenTest
{
    public partial class Form2 : Form
    {
        private List<Qns> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private string quizCategory;

        public Form2()
        {
            InitializeComponent();
            quizCategory = "MCU"; // Default category
            LoadQuestions();
            DisplayQuestion();
        }

        // Constructor that takes the category as a parameter
        public Form2(string category)
        {
            InitializeComponent();
            quizCategory = category;
            LoadQuestions();
            DisplayQuestion(); // Ensure questions appear immediately
        }

        // Loading the quiz questions
        private void LoadQuestions()
        {
            questions = new List<Qns>();

            if (quizCategory == "MCU")
            {
                questions.Add(new Qns("Which movie officially introduced Spider-Man to the Marvel Cinematic Universe (MCU)?", new[] { "Avengers: Age of Ultron", "Captain America: Civil War", "Spider-Man: Homecoming", "Doctor Strange" }, 1));
                questions.Add(new Qns("What is the name of Thor’s enchanted axe, forged in Avengers: Infinity War?", new[] { "Mjolnir", "Gungnir", "Stormbreaker", "Thunderstrike" }, 2));
                questions.Add(new Qns("Who was the villain in Guardians of the Galaxy Vol. 1?", new[] { "Thanos", "Ego", "Ronan the Accuser", "The Collector" }, 2));
                questions.Add(new Qns("In Black Panther, what is the name of the heart-shaped herb that gives the Black Panther his powers?", new[] { "Vibranium Leaf", "Wakandan Root", "Sacred Blossom", "Heart-Shaped Herb" }, 3));
                questions.Add(new Qns("What is the real name of the Winter Soldier?", new[] { "Sam Wilson", "Bucky Barnes", "Clint Barton", "Steve Rogers" }, 1));
            }
            else if (quizCategory == "Trivia")
            {
                questions.Add(new Qns("What is the capital of France?", new[] { "Berlin", "Madrid", "Paris", "Lisbon" }, 2));
                questions.Add(new Qns("Who wrote 'To Kill a Mockingbird'?", new[] { "Harper Lee", "J.K. Rowling", "Ernest Hemingway", "F. Scott Fitzgerald" }, 0));
            }
            else if (quizCategory == "Classic")
            {
                questions.Add(new Qns("Which 1942 film featured the famous line 'Here's looking at you, kid'?", new[] { "Casablanca", "Gone with the Wind", "Citizen Kane", "The Godfather" }, 0));
            }
            else if (quizCategory == "Animated")
            {
                questions.Add(new Qns("Which animated movie features a character named Simba?", new[] { "Finding Nemo", "The Lion King", "Shrek", "Frozen" }, 1));
            }
        }

        // Displaying the current question and its options
        private void DisplayQuestion()
        {
            if (questions.Count == 0)
            {
                label1.Text = "No questions available for this category.";
                return;
            }

            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                label1.Text = question.Text;
                radioButton1.Text = question.Options[0];
                radioButton2.Text = question.Options[1];
                radioButton3.Text = question.Options[2];
                radioButton4.Text = question.Options[3];

                // Reset selections
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                // Reset feedback
                label2.Text = "";
                label2.Visible = false;

                // Enable Submit, Disable Next
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                ShowResults();
            }
        }

        // Verifying the answer when the Submit button is clicked
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex >= questions.Count) return;

            var question = questions[currentQuestionIndex];

            int selectedAnswer = -1;
            if (radioButton1.Checked) selectedAnswer = 0;
            else if (radioButton2.Checked) selectedAnswer = 1;
            else if (radioButton3.Checked) selectedAnswer = 2;
            else if (radioButton4.Checked) selectedAnswer = 3;

            if (selectedAnswer == -1)
            {
                MessageBox.Show("Please select an answer before submitting.");
                return;
            }

            if (selectedAnswer == question.CorrectAnswerIndex)
            {
                label2.Text = "Correct!";
                label2.ForeColor = Color.Green;
                score++;
            }
            else
            {
                label2.Text = $"Incorrect! The correct answer is: {question.Options[question.CorrectAnswerIndex]}";
                label2.ForeColor = Color.Red;
            }

            label2.Visible = true;

            // Disable Submit & Enable Next
            button1.Enabled = false;
            button2.Enabled = true;
        }

        // Moving to the next question when the Next button is clicked
        private void btnNext_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                ShowResults();
            }
        }

        // Showing the results after the quiz ends
        private void ShowResults()
        {
            DialogResult result = MessageBox.Show(
                $"Quiz Completed!\nScore: {score}/{questions.Count} ({(score * 100) / questions.Count}%)\n\nWould you like to retake the quiz?",
                "Results", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                RetakeQuiz();
            }
            else
            {
                this.Close();
            }
        }

        // Retaking the quiz by resetting the score and question index
        private void RetakeQuiz()
        {
            score = 0;
            currentQuestionIndex = 0;
            label2.Text = "";
            label2.Visible = false;

            // Enable Submit, Disable Next
            button1.Enabled = true;
            button2.Enabled = false;

            DisplayQuestion();
        }

        // Ensuring Submit button is enabled initially, and Next button is disabled
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;  // Ensure Submit is enabled at start
            button2.Enabled = false; // Next should be disabled initially
        }
    }
}
