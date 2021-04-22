using System.IO;
using System;

class Program
{
    static void Main()
    {
      int[,] arr = new int[3,3];
      // int sum=0;
      // Console.WriteLine("Enter the elements");
      //getting values from user
      for (int row =0;row < arr.GetLength(1);row++)
      {
          for (int col = 0; col<arr.GetLength(1);col++)
      
       {
          arr[row,col] = Convert.ToInt32(Console.ReadLine());
       }
      }
      //printing values to screen
       for (int row =0;row < arr.GetLength(1);row++)
      {
          for (int col = 0; col<arr.GetLength(1);col++)
      
       {
          Console.Write(arr[row,col] + "\t");
       }
       Console.Write("\n");
      }
      
      

    
    }
}