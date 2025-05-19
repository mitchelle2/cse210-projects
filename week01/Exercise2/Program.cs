using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");


        Console.Write( "what is your percentage?");
        string Answer = Console.ReadLine();
        int Grade = int.Parse(Answer);

        string GradeLetter = "";

        if(Grade >90)
        {
            GradeLetter = "A";
        }
        
        else if(Grade >80)
        {
            GradeLetter = "B";
        }
         else if( Grade >70)
         {
            GradeLetter = "C";
         }
         else if(Grade >60)
         {
            GradeLetter = "D";
         }
         else
         {
            GradeLetter = "F";
         }
         Console.WriteLine($"Your grade is:{GradeLetter}");

        if( Grade>70)
        {
          Console.WriteLine(" Congratulations you passed!"); 
        }
        else
        {
          Console.WriteLine("you failed! you can do better next time.");
        }

    }
}