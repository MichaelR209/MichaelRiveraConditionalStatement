using System;

namespace MichaelRiveraConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the grade percentage you expect to earn in the class (0-100). As per 2021 syllabus, your letter grade is...");


           
                int value_of_input;
                if (int.TryParse(Console.ReadLine(), out value_of_input))
            {
                if ((value_of_input <= 100) && (value_of_input >= 0))
                {

                    if ((value_of_input < 100) && (value_of_input >= 92))
                    {
                        Console.WriteLine("You will receive an A in the class.");
                    }
                   else if ((value_of_input < 92) && (value_of_input >= 90))
                    {
                        Console.WriteLine("You will receive an A- in the class.");
                    }
                  else  if ((value_of_input < 90) && (value_of_input >= 88))
                    {
                        Console.WriteLine("You will receive a B+ in the class.");
                    }
                 else   if ((value_of_input < 88) && (value_of_input >= 82))
                    {
                        Console.WriteLine("You will receive a B in the class.");
                    }
                  else  if ((value_of_input < 82) && (value_of_input >= 80))
                    {
                        Console.WriteLine("You will receive a B- in the class.");
                    }
                   else if ((value_of_input < 80) && (value_of_input >= 78))
                    {
                        Console.WriteLine("You will receive a C+ in the class.");
                    }
                 else   if ((value_of_input < 78) && (value_of_input >= 72))
                    {
                        Console.WriteLine("You will receive a C in the class.");
                    }
                  else  if ((value_of_input < 72) && (value_of_input >= 70))
                    {
                        Console.WriteLine("You will receive a C- in the class.");
                    }
                  else  if ((value_of_input < 70) && (value_of_input >= 68))
                    {
                        Console.WriteLine("You will receive a D+ in the class.");
                    }
                  else  if ((value_of_input < 68) && (value_of_input >= 62))
                    {
                        Console.WriteLine("You will receive a D in the class.");
                    }
                  else  if ((value_of_input < 62) && (value_of_input >= 60))
                    {
                        Console.WriteLine("You will receive a D- in the class.");
                    }
                   else if ((value_of_input < 60) && (value_of_input >= 0))
                    {
                        Console.WriteLine("You will receive an F in the class.");
                    }

                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else
                {
                    //Display Error message if value is not between 0 and 100. 
                    Console.WriteLine("Please enter a value between 0 and 100.");
                }
            }
            else
            {
                // Display error message if conversion is unsuccessful.
                Console.WriteLine("Please enter the grade percentage you expect to earn");
            }





            }
    }
}
