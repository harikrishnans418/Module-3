using System.IO;
using System;

class Program
{
    static void Main()
    {
        int Age;
            Console.WriteLine("Enter your age :");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age >= 60)
                Console.WriteLine("You are a Senior Citizen");
            else if (Age >= 18)
                Console.WriteLine("You are eligible to vote");
            else
                Console.WriteLine("You are not eligible to vote");
            Console.ReadLine();
    }
}