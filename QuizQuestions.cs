using System;

namespace simple_quiz_oop;

public class QuizQuestions
{
    public string Question { get; }
    public string[] Options { get; }

    public string CorrectAnswer { get; }

    public QuizQuestions(string question, string[] options, string correctAnswer)
    {
        Question = question;
        Options = options;
        CorrectAnswer = correctAnswer;
    }
}
