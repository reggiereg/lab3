using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            String username = "";
            Console.WriteLine("Hello, what is your name? ");
            username = Console.ReadLine();
            if (username == "")
            {
                Console.WriteLine("Since you have not provided a name, I will just refer to you as Mr. Guest");
                username = "Guest";
            }
            int num;
            int option = 1;
            while (option == 1)
            {
                Console.WriteLine("Enter in a number to determine if it is odd or even: ");
                num = int.Parse(Console.ReadLine());
                if (num > 1 && num < 100)
                {
                    if (num % 2 != 0 || (num % 2 != 0 && num > 60))
                    {
                        Console.WriteLine($"Hello {username}.  Here are your results: {num} Odd");
                    }
                    else if (num % 2 == 0 && (num >= 2 && num <= 25))
                    {
                        Console.WriteLine($"Hello {username}.  Here are your results: Even and less than 25");
                    }
                    else if ((num % 2 == 0 && (num >= 26 && num <= 60)))
                    {
                        Console.WriteLine($"Hello {username}.  Here are your results: Even");
                    }
                    else if (num % 2 == 0 && num > 60)
                    {
                        Console.WriteLine($"Hello {username}.  Here are your results: {num} Even");
                    }
                    Console.WriteLine("Press 1 if you like to enter in another number or 0 if you would like to quit ");
                    option = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You have entered in a value outside of the acceptable range");
                    Console.WriteLine("Press 1 if you like to enter in another number or 0 if you would like to quit");
                    option = int.Parse(Console.ReadLine());

                }
            }

        }
    }
}
