using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "English":
                   Console.WriteLine("You got it!!");
                   break;
                case "Math":
                    Console.WriteLine("Math Rocks!!");
                    break;
                case "PE":
                    Console.WriteLine("PE Rocks!!");
                    break;
                case "Social Studies":
                    Console.WriteLine("Social Studies Rocks!!");
                    break;
                case "Lunch":
                    Console.WriteLine("Lunch is tasty!!");
                    break;
                default:
                    Console.WriteLine("That's too bad");
                    break;
            }
        }
    }
}
