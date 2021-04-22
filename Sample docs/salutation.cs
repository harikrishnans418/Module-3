using System.IO;
using System;

public enum Salutation
{
    Mr=0,
    Ms=1,
    Mrs=2,
    Dr=3
}
class Class12
{
    static void Main()
    {
       Salutation salutation;
       string name;
       
       Console.WriteLine("Enter the Salutation");
       
       salutation = (Salutation)Enum.Parse(typeof(Salutation), Console.Readline());
       
       Console.WriteLine("Enter your name:");
       name = Console.Readline();
       Console.Write("\nYour name is : {0}",salutation.ToString());
       Console.Write("." + name);
       Console.ReadLine();
    }
       
    }