

# ScreenTest Quiz App

The **ScreenTest** app is a simple quiz application that allows users to test their knowledge on various topics. The app supports different quiz categories such as MCU, Trivia, Classic Movies, and Animated Films. Users can select answers for each question, receive immediate feedback, and view their score at the end of the quiz.

## Features

- **Multiple Categories**: The app includes different quiz categories, including:
  - MCU (Marvel Cinematic Universe)
  - Trivia
  - Classic Movies
  - Animated Films
- **Questions and Answers**: Users are presented with multiple-choice questions and have to select the correct answer from four options.
- **Instant Feedback**: After each question is answered, users receive immediate feedback indicating whether their answer was correct or incorrect.
- **Results Display**: At the end of the quiz, users are shown their score and can choose to retake the quiz.
- **Simple User Interface**: The interface is designed for ease of use, with clear instructions and feedback.

## Getting Started

### Prerequisites

To run the **ScreenTest** app, you need:

- A system that supports .NET Framework or .NET Core (Windows).
- Visual Studio or another IDE capable of building Windows Forms applications.

### Installation

1. Clone or download the repository to your local machine.
2. Open the project folder in Visual Studio.
3. Build the project and run the application.

### Usage

1. When you launch the app, you will be presented with the first question in the default category (MCU).
2. Select your answer by clicking one of the radio buttons.
3. Click the **Submit** button to check your answer.
4. After receiving feedback, click the **Next** button to proceed to the next question.
5. After completing the quiz, you will be shown your score. You can choose to retake the quiz or close the application.

### Quiz Categories

The app supports the following categories:

1. **MCU**: Questions related to the Marvel Cinematic Universe.
2. **Trivia**: General knowledge questions.
3. **Classic**: Questions related to classic movies.
4. **Animated**: Questions about animated films.

## Code Structure

- **Form2.cs**: Contains the main logic for displaying questions, verifying answers, and tracking the user's score.
- **Qns.cs**: Represents a question and its options.
- **Form2.Designer.cs**: Contains the layout and design of the user interface (buttons, labels, radio buttons, etc.).

### Key Variables
- `questions`: A list of `Qns` objects that store the questions and their options.
- `currentQuestionIndex`: Tracks the current question the user is on.
- `score`: Tracks the user's score during the quiz.
- `quizCategory`: The category of the quiz (MCU, Trivia, etc.).

### Functions
- `LoadQuestions()`: Loads the questions based on the selected category.
- `DisplayQuestion()`: Displays the current question and options on the screen.
- `btnVerify_Click()`: Verifies the user's answer and provides feedback.
- `btnNext_Click()`: Moves to the next question.
- `ShowResults()`: Displays the user's score at the end of the quiz.
- `RetakeQuiz()`: Resets the quiz and allows the user to start over.

## Contributing

If you would like to contribute to the project, feel free to fork the repository, create a new branch, and submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
