using System.IO;
using System;

class Program
{
    static void Main()
    {
      Console.WriteLine("Enter what you want to do. \n 1.Addition \n 2.Sub \n3.Mul");
      int Choice = Convert.ToInt32(Console.ReadLine());
      
      switch (Choice)
      {
          case 1:
            Console.WriteLine("ADD");
            break;
          case 2:
            Console.WriteLine("SUB");
            break;
          default:
            Console.WriteLine("Nothing");
            break;
          
      }

    
    }
}