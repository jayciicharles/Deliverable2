// 1. Ask the user what grade they expect to get in ISM 4300. They should enter an integer value.
/*
using System;
using System.Diagnostics.Metrics;

namespace Deliverable_2_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter expected grade: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Your letter grade is A");
            }
            else if ((grade >= 80) && (grade < 90))
            {
                Console.WriteLine("Your letter grade is B");
            }
            else if ((grade >= 70) && (grade < 80))
            {
                Console.WriteLine("Your letter grade is C");
            }
            else if ((grade >= 60) && (grade < 70))
            {
                Console.WriteLine("Your letter grade is D");
            }
            else if ((grade >= 0) && (grade < 60))
            {
                Console.WriteLine("Your letter grade is F");
            }
            else
            {
                Console.WriteLine("Please enter an integer between 0-100");
            }
        }

    }
}
*/

using System;
using System.Runtime.Intrinsics.X86;

namespace Deliverable_2_Conditional_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter grade: ");

            int grade = int.Parse(Console.ReadLine());

            if ((grade <= 100) && (grade >= 98))
            {
                Console.WriteLine("You have an A+");
            }
            else if ((grade <= 97) && (grade >= 92))
            {
                Console.WriteLine("You have an A");
            }
            else if ((grade <= 91) && (grade >= 90))
            {
                Console.WriteLine("You have an A-");
            }
            else if ((grade <= 89) && (grade >= 88))
            {
                Console.WriteLine("You have a B+");
            }
            else if ((grade <= 87) && (grade >= 82))
            {
                Console.WriteLine("You have a B");
            }
            else if ((grade <= 81) && (grade >= 80))
            {
                Console.WriteLine("You have a B-");
            }
            else if ((grade <= 79) && grade >= 78)
            {
                Console.WriteLine("You have a C+");
            }
            else if ((grade <= 77) && (grade >= 72))
            {
                Console.WriteLine("You have a C");
            }
            else if ((grade <= 71) && (grade >= 70))
            {
                Console.WriteLine("You have a C-");
            }
            else if ((grade <= 69) && (grade >= 68))
            {
                Console.WriteLine("You have a D+");
            }
            else if ((grade <= 67) && (grade >= 62))
            {
                Console.WriteLine("You have a D");
            }
            else if ((grade <= 61) && (grade >= 60))
            {
                Console.WriteLine("You have a D-");
            }
            else if ((grade < 60))
            {
                Console.WriteLine("You have an F");
            }
            else
            {
                Console.WriteLine("Please enter an integer between 0-100");
            }

        }
    }
}
