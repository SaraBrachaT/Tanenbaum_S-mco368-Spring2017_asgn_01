using PresidentialEligibilityClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static bool naturalBorn;
        static int age;
        static int resYears;
        static bool lessThanTwoTerms;
        static bool impeached;
        static bool rebellious;

        static void Main(string[] args)
        {
            if (args.Length == 0) checkWithNoArgs();
            else if (args.Length == 6)checkWithArgs(args);
            else Console.WriteLine("Incorrect Number of Arguements. Application Terminating");
        }

        public static void checkWithNoArgs()
        {
            Console.WriteLine("Are you a natural born citizen? (Y/N)");
            string nBorn = Console.ReadLine();
            if (nBorn[0] == 'Y' || nBorn[0] == 'y') naturalBorn = true;
            else naturalBorn = false;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("For how many years have you resided in America?");
            resYears = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of terms you have served as president for");
            int numTerms = int.Parse(Console.ReadLine());
            if (numTerms < 2) lessThanTwoTerms = true;
            else lessThanTwoTerms = false;
            Console.WriteLine("Have you been impeached? (Y/N)"
                                + "\nThis may disqualify someone from being president. Therefore, in this"
                                + " application, it does");
            String imp = Console.ReadLine();
            if (imp[0] == 'Y' || imp[0] == 'y') impeached = true;
            else impeached = false;
            Console.WriteLine("Have you rebelled against the US government?(Y/N)");
            String reb = Console.ReadLine();
            if (reb[0] == 'Y' || reb[0] == 'y') rebellious = true;
            else rebellious = false;
            EligibilityChecker ec = new EligibilityChecker(naturalBorn, age, resYears, lessThanTwoTerms, impeached, rebellious);
            if (ec.check()) Console.WriteLine("You are eligible");
            else Console.WriteLine("You are not eligible");
            Console.ReadKey();
        }

        public static void checkWithArgs(string[] args)
        {
            if (!(bool.TryParse(args[0], out naturalBorn)))
            {
                Console.WriteLine("Incorrect arguement. Bool expected. Application Exiting");
                Environment.Exit(1);
            }
            if(!(int.TryParse(args[1], out age)))
            {
                Console.WriteLine("Incorrect arguement. Int expected. Application Exiting");
                Environment.Exit(1);
            }

            if (!(int.TryParse(args[2], out resYears)))
            {
                Console.WriteLine("Incorrect arguement. Int expected. Application Exiting");
                Environment.Exit(1);
            }

            if (!(bool.TryParse(args[3], out lessThanTwoTerms)))
            {
                Console.WriteLine("Incorrect arguement. Bool expected. Application Exiting");
                Environment.Exit(1);
            }

            if (!(bool.TryParse(args[4], out impeached)))
            {
                Console.WriteLine("Incorrect arguement. Bool expected. Application Exiting");
                Environment.Exit(1);
            }

            if (!(bool.TryParse(args[5], out rebellious)))
            {
                Console.WriteLine("Incorrect arguement. Bool expected. Application Exiting");
                Environment.Exit(1);
            }
            EligibilityChecker ec = new EligibilityChecker(naturalBorn, age, resYears, lessThanTwoTerms, impeached, rebellious);
            if (ec.check()) Console.WriteLine("You are eligible");
            else Console.WriteLine("You are not eligible");
            Console.ReadKey();
        }
    }
}
