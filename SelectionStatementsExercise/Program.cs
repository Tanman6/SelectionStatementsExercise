using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorite school subject? " +
                "for Math enter 0, for English enter 1, for History enter 2," +
                "for Science enter 3, for Foreign Language enter 4, for any " +
                "other subject enter 5");
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer);

            switch(number)
            {
                case 0:
                    Console.WriteLine("Math");
                    break;
                case 1:
                    Console.WriteLine("English");
                    break;
                case 2:
                    Console.WriteLine("History");
                    break;
                case 3:
                    Console.WriteLine("Science");
                    break;
                case 4:
                    Console.WriteLine("Foreign Language");
                    break;
                case 5:
                    Console.WriteLine("Other Subject");
                    break;
                default:
                    Console.WriteLine("The number you entered is not correlated with a subject.");
                    break;
            }

        }
    }
}
