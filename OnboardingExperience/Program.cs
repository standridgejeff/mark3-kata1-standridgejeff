using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Hello, and welcome to our bank.");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();

            Console.WriteLine("First, we need to get a little information from you.");
            user.IsOwner = AskBoolQuestion("Will you please verify that you are the owner of this account?");
            if (!user.IsOwner)
            {
                Console.WriteLine("We're very sorry but you cannot access accounts that are not your own.");
                Console.WriteLine("Thanks very much for your time and cooperation. Program will exit. Good bye");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine($"Hello, {user.FirstName}, nice to meet you.");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();


            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine($"Great Mr./ Ms. {user.LastName}, thanks for the info. ");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();

            user.Age = AskNumberQuestion("What is your age?");
            Console.WriteLine("Please press Enter to continue...");
            Console.ReadKey();

            user.Pin = AskNumberQuestion("What is your pin?");
            Console.WriteLine("Pleaser press Enter to continue...");
            Console.ReadKey();

            Console.WriteLine("We appreciate your business, thanks for using our bank");
            Console.ReadKey();
        }

        public static string AskQuestion(string question)
        {

            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static int AskNumberQuestion(string question)
        {
            var number = 0;
            var answered = false;
            do
            {
                var result = AskQuestion(question);
                answered = Int32.TryParse(result, out number);

                if (!answered)
                {
                    Console.WriteLine("You need to enter a regular number.");
                }
            } while (!answered);

            return number;


        }

        private static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                var response = AskQuestion(question + " Yes or No");


                switch (response.ToLower())
                {
                    case "no":
                        return false;
                    case "yes":
                        return true;
                    default:
                        Console.WriteLine("You need to answer yes or no");
                        break;
                }
            }
        }


    }
}