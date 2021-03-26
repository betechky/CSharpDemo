using System;

namespace Exemption_Handling
{
    class Program
    {
        private const string V = "\nIndexOutofRangeException: ";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 and 255: ");

            string n1 = Console.ReadLine();

            Console.WriteLine("Enter another number between 0 and 255: ");

            string n2 = Console.ReadLine();

            try
            {
                int num1 = Int32.Parse(n1);
                int num2 = Int32.Parse(n2);
                int ans = num1 / num2;
                if (!(num1 >= 0 && num1 <= 255) || !(num2 >= 0 && num2 <= 255))
                {
                    //  Console.WriteLine(" you are out of range");
                    throw new ArgumentOutOfRangeException();
                }
                else if (num2 == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    Console.WriteLine("\n" + num1 + " divided by " + num2 + " is " + (num1 / num2));
                }



            }
            catch (FormatException e)
            {
                Console.WriteLine("\nFormatException: " + e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("\nDivideByZeroException: " + e.Message);
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("/nArgumentOutOfRangeException:Number(s) is Out of range");
            }


            Console.WriteLine("\nHave a great day!");
        }
    }
}
