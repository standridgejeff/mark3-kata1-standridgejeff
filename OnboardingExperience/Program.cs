using System;
using System.Data.SqlTypes;
using System.Net.Mime;
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

            Console.WriteLine("First, we need to get a little information from you.");
            user.IsOwner = IsOwnerQuestions("Will you please verify that you are the owener of this account?");


            user.FirstName = AskQuestions("What is your first name?");
            Console.WriteLine($"Hello, {user.FirstName}, nice to meet you.");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();


            user.LastName = AskQuestions("What is your last name?");
            Console.WriteLine($"Great Mr./ Ms. {user.LastName}, thanks for the info. ");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();

            user.Age = AskNumberQuestions("What is your age?");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();

            user.Pin = AskNumberQuestions("What is your pin?");
            Console.WriteLine("Pleaser press Enter to continue...");
            Console.ReadKey();

            Console.WriteLine("We appreciate your business, thanks for using our bank");
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
                    Console.WriteLine("You need to enter a regular number.");
                }
            } while (!answered);

            return ageNumber;

            /*var userPin = 0;
            var pinanswered = true;

            do
            {
                var answer = AskQuestions(question);
                pinanswered = Int32.TryParse(answer, out userPin);

                if (!pinanswered)
                {
                    Console.WriteLine("That pin is invalid");
                }
            } while (!pinanswered);

            return userPin;*/
        }

         private static bool IsOwnerQuestions(string question)
         {
            while (true)
            {
                var response = AskQuestions(question + " Yes or No");
                
                
                if (response.ToLower() == "no")
                {
                    Console.WriteLine("We're very sorry but you cannot access accounts that are not your own.");
                    Console.WriteLine("Thanks very much for your time and cooperation. Program will exit. Good bye");
                    Console.ReadLine();
                    Environment.Exit(-1);
                }

                return false;
            }
         }


    }
}