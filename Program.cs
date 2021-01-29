using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer from 1 to 100");
            try
            {

                string input = Console.ReadLine();
                int chosenInteger = int.Parse(input);
                

                if ((chosenInteger > 0) && (chosenInteger <= 100))
                {
                    
                    for (int i = 1; i <= chosenInteger; i++)
                    {
                       Console.WriteLine("You have entered " + chosenInteger.ToString() + "." + " This is the current integer value in the loop: " + i.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Please remember to enter an integer between 1 and 100");
                }

            }
            catch
            {
                Console.WriteLine("Please double check whether you have entered an integer and whether that integer falls between 1 and 100");
            }
        }

    }
}
