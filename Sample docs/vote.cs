using System.IO;
using System;

class Program
{
    static void Main()
    {
      int Number;
      Console.WriteLine("Enter Your Age :");
      Number = Convert.ToInt32(Console.ReadLine());
      if (Number >= 18)
      {
          Console.WriteLine("You are eligible to vote");
      }
      else
      {
          Console.WriteLine("Not Eligible");
      }
          Console.ReadLine();
       

    }
}