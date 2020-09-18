using System;

namespace Techh2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Grade Do You Expect To Get in ISM 4300? Enter Integer Value");

            try
            {
                string input = Console.ReadLine();

                decimal grades = decimal.Parse(input);


                if (grades < 100)
                {
                    Console.WriteLine("A" + String.Format("{0:C}", grades) + " is: ");
                }
                if (grades < 89)
                {
                    Console.WriteLine("B" + String.Format("{0:C}", grades) + " is: ");
                }
                if (grades < 79)
                {
                    Console.WriteLine("C" + String.Format("{0:C}", grades) + " is: ");
                }
                if (grades < 69)
                {
                    Console.WriteLine("D" + String.Format("{0:C}", grades) + " is: ");
                }
                if (grades >= 59)
                {
                    return;
                }
                Console.WriteLine("F" + String.Format("{0:C}", grades) + " is: ");
            }

            catch
            {
                Console.WriteLine("What Grade?");
                Console.WriteLine("--- OR ---");
                Console.WriteLine(" What is your percentage");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }   

        }

    }
}
