using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            // Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[] { "one is A", "ice is hot", "sugar is bitter", "tea is saber", "two is two", "one is one" };
            bool[] answers = new bool[] { false, false, false, false, true, true };

            bool[] responses = new bool[questions.Length];
            Console.WriteLine(questions.Length);

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! questions doesn't equal to answers.");
            }

            // Asking questions and collecting responses
            for (int i = 0; i < questions.Length; i++)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(questions[i]);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[i] = inputBool;
            }

            // Printing responses
            Console.WriteLine("Your responses:");
            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }

            // Scoring
            int score = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (responses[i] == answers[i])
                {
                    score++;
                }
            }

            Console.WriteLine($"You got {score} out of {questions.Length}");
        }
    }
}
