using System.IO;
using System;

class Program
{
    static void Main()
    {
        
       int firstNumber, secondNumber, result;
       
       Console.WriteLine("Enter FirstNumber :");
       //Input from user
       firstNumber = Convert.ToInt32(Console.ReadLine());
       
       Console.WriteLine("Enter SecondNumber :");
       //Input from user
       secondNumber = Convert.ToInt32(Console.ReadLine());
       
       result = firstNumber + secondNumber;
       Console.WriteLine("Sum of Numbers is: "+result);
       Console.ReadLine();
    }
}