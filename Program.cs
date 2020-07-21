using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's you name?"); //asking for user info to refer to
            string name = Console.ReadLine();

            Console.WriteLine("Would you like to run the program? (y/n)");
            string answer = Console.ReadLine();

            while (answer == "y")
            {

                Console.WriteLine("Enter a number between 1 and 100");
                int input = int.Parse(Console.ReadLine());

                if (input > 0 && input <= 25 && input % 2 == 0) //validation that it's a positive number, less than 25, and even
                {
                    Console.WriteLine(name + ", the number you entered, " + input + ", is even and less than 25.");
                }
                else if (input > 0 && input > 25 && input <= 100 && input % 2 == 0) //validation that it's positive, less than 100 but more than 25 (including 26-60 range) and even
                {
                    Console.WriteLine(name + ", the number you entered, " + input + ", is even.");
                }
                else if (input > 0 && input <= 25 && input % 2 != 0) //same validations as before but for odd numbers
                {
                    Console.WriteLine(name + ", the number you entered, " + input + ", is odd.");
                }
                else if (input > 0 && input > 25 && input <= 100 && input % 2 != 0)
                {
                    Console.WriteLine(name + "The number you entered, " + input + ", is odd.");
                }
                else
                {
                    Console.WriteLine(name + ", please enter a whole number between 1 and 100 (no negative numbers either!).");
                }

                Console.Write("Continue? (y/n)");
                answer = Console.ReadLine();
            };
            while (answer == "n")
            {
                Console.WriteLine("Ok, see you later!");
                break; //offical ending
            };
        }
    }
}
