using System;
using System.Collections.Generic;
using simple_quiz_oop;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Quiz");
            Console.WriteLine("Press Enter to see the first question: ");
            Console.ReadLine();

            int totalScore = 0;

            List<QuizQuestions> questions = new List<QuizQuestions>
            {
                new QuizQuestions("Which physicist developed the theory of general relativity?", new string[] { "a. Isaac Newton", "b. Albert Einstein", "c. Niels Bohr" }, "b"),
                new QuizQuestions("What is the capital city of Australia?", new string[] { "a. Sydney", "b. Melbourne", "c. Canberra" }, "c"),
                new QuizQuestions("Which element is the most abundant in the Earth's crust?", new string[] { "a. Silicon", "b. Oxygen", "c. Aluminum" }, "b"),
                new QuizQuestions("Who composed the opera \"The Magic Flute\"?", new string[] { "a. Ludwig van Beethoven", "b. Wolfgang Amadeus Mozart", "c. Johann Sebastian Bach" }, "b"),
                new QuizQuestions("What is the hardest natural substance on Earth?", new string[] { "a. Diamond", "b. Corundum", "c. Quartz" }, "a"),
                new QuizQuestions("Which ancient civilization built the Machu Picchu complex in Peru?", new string[] { "a. Aztec", "b. Inca", "c. Maya" }, "b"),
                new QuizQuestions("What is the chemical formula for table salt?", new string[] { "a. NaCl", "b. KCl", "c. CaCl2" }, "a"),
                new QuizQuestions("Which planet has the most moons?", new string[] { "a. Jupiter", "b. Saturn", "c. Uranus" }, "a"),
                new QuizQuestions("Who is the author of the novel \"1984\"?", new string[] { "a. Aldous Huxley", "b. George Orwell", "c. Ray Bradbury" }, "b"),
                new QuizQuestions("What is the name of the longest river in the world?", new string[] { "a. Amazon River", "b. Nile River", "c. Yangtze River" }, "a")
            };

            foreach (var question in questions)
            {
                bool correctGuess = false;
                Console.WriteLine(question.Question);
                foreach (var option in question.Options)
                {
                    Console.WriteLine($"\t{option}");
                }

                while (!correctGuess)
                {
                    string ? userAnswer = Console.ReadLine();

                    if (userAnswer == question.CorrectAnswer)
                    {
                        correctGuess = true;
                        totalScore += 2;
                        Console.WriteLine($"Correct! Your total score is {totalScore}");
                    }
                    else
                    {
                        totalScore--;
                        Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                    }
                }
            }

            Console.WriteLine($"You've completed the quiz! Your total score is {totalScore}");
        }

    }
}
