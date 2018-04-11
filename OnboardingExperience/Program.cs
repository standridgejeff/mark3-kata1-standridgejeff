using System;
using System.Security.Cryptography.X509Certificates;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            Console.WriteLine("Hello, and welcome to our bank.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);

            user.FirstName = AskQuestions("What is your first name?");
            Console.WriteLine($"Hello, {user.FirstName}, nice to meet you.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            

            user.LastName = AskQuestions("What is your last name?");
            Console.WriteLine("Great, thanks for the info. ");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();



        }

        public static string AskQuestions(string question)
        {

            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int Numbers(string question)
        {
            Console.WriteLine(question);
            return Convert.ToInt32(Console.ReadLine());
        }
    }

}
