using System;

namespace PrimeFactors
{
    public class Program
    {
        public static string PrimeFactors(int number)
        {
            string res = string.Empty;
            
            for (int i = 2; i <= number; ++i)
            {
                while (number % i == 0)
                {
                    res += string.IsNullOrEmpty(res) ? i.ToString() : " x " + i;
                    number = number / i;
                 
                }
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Prime factors of 4 are: " + PrimeFactors(4) + "\n");
            Console.WriteLine("Prime factors of 7 are: " + PrimeFactors(7) + "\n");
            Console.WriteLine("Prime factors of 30 are: " + PrimeFactors(30) + "\n");
            Console.WriteLine("Prime factors of 40 are: " + PrimeFactors(40) + "\n");
            Console.WriteLine("Prime factors of 50 are: " + PrimeFactors(50) + "\n");
            
        }
    }
}
