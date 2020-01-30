using System;

namespace Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display what the user is supposed to insert
            Console.WriteLine("Enter an interger between 1 and 100");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            try
            {
                //Checks if the number is greater then 100 or less the 0
                if ((number >= 0) && (number <= 100))
                {
                    for (int count = 1; count <= number; count++)
                    {
                        Console.WriteLine("You have entered " + number.ToString() + ". "+"This is the current integer for the value in the loop: "+ count.ToString());
                    }
                }
                else
                {
                    //Error message telling the user they have entered a value too high or too low 
                    Console.WriteLine("You have entered an ivalid data type");
                }
            }
            catch
            {
                    Console.WriteLine("You have entered an ivalid data type");
            }
        }
        
    }
}
