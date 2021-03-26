using System;

namespace CSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello .Net Core World!");
            string userName = Console.ReadLine();
            string userPos = "developer";

            Console.WriteLine("hello" + userName);
            Console.WriteLine("hello {0}{1}" + userName, userPos);
            Console.WriteLine($"hello {userName}{userPos}" );
            */
            int i = 77;
            long l = i;
            float f = l;
            double d = 3.14;

            // c++ -> c++++ #
            // c -> c++ -> c++++ #
            // i = (int)d;
            string str = "314";
            // i = Int32.Parse(str);
            i = Convert.ToInt32(d);


            Console.WriteLine($"i = {i}");
            Console.WriteLine($"l = {l}");
            Console.WriteLine($"f = {f}");
            Console.WriteLine($"d = {d}");


            /*
                sbyte, byte, short, ushort, int, uint, long, ulong, float, double, 
                and decimal.
            */
            Console.WriteLine("\n\n");
            Console.WriteLine("|  Type  | Bytes of Memory |   Min   |   Max   |");
            Console.WriteLine("================================================");
            Console.WriteLine("| sbyte  | " + sizeof(sbyte) + " | " +
                        sbyte.MinValue + " | " + sbyte.MaxValue + " |"
                    );
            Console.WriteLine("| byte  | " + sizeof(byte) + " | " +
                        byte.MinValue + " | " + byte.MaxValue + " |"
                     );
            Console.WriteLine("| float  | " + sizeof(float) + " | " +
                        float.MinValue + " | " + float.MaxValue + " |"
                     );
            Console.WriteLine("| double  | " + sizeof(double) + " | " +
                        double.MinValue + " | " + double.MaxValue + " |"
                     );
            Console.WriteLine("| long  | " + sizeof(long) + " | " +
                      long.MinValue + " | " + long.MaxValue + " |"
                   );
            Console.WriteLine("| decimal  | " + sizeof(decimal) + " | " +
                        decimal.MinValue + " | " + decimal.MaxValue + " |"
                     );

            Console.WriteLine("\n\n");
            int length = 100;

            //for (int i = 1; i <= length; i++)
            //{
            //    Console.Write(i);
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //        /*if (j % 15 == 0)
            //            Console.write("fizzbuzz");
            //        else if (i % 3 == 0) && (j % 5 == 0)
            //                 Console.write("buzz");
            //        for (int j = 1; j < length; j++)
            //        {
            //            if (j % 15 == 0)
            //                Console.WriteLine("fizzbuzz");
            //            else if (j % 3 == 0)
            //                Console.WriteLine("buzz");
            //            else if (j % 5 == 0)
            //                Console.WriteLine("buzz");
            //            else
            //                Console.Write("\n");*/
            //    }
            //}   
        }
        
    }
}
