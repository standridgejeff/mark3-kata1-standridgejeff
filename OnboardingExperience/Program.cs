using System;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine("Hello, and welcome to our bank.");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey(true);

            user.FirstName = AskQuestions("What is your first name?");
            Console.WriteLine($"Hello, {user.FirstName}, nice to meet you.");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();


            user.LastName = AskQuestions("What is your last name?");
            Console.WriteLine("Great, thanks for the info. ");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();

            user.Age = AskNumberQuestions("What is your age?");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();

        }

        public static string AskQuestions(string question)
        {

            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static int AskNumberQuestions(string question)
        {
            var ageNumber = 0;
            var answered = false;
            do
            {

                var result = AskQuestions(question);
                answered = Int32.TryParse(result, out ageNumber);

                if (!answered)
                {
                    Console.WriteLine("You need to enter a regular number");
                }

            } while (!answered);


            return ageNumber;

        }
    }
}