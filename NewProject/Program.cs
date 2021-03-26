using System;

namespace NewProject
{
    class Program
    {
        private static NLog.Logger _logger =
        NLog.LogManager.GetCurrentClassLogger();

        public static void SomeMethod()
        {
            _logger.Info("SomeMethod() has been executed");

            try
            {
                int a = 77;
                int b = 0;

                int res = a / b;
            }
            catch (Exception e)
            {
                _logger.Error(e, "Somethig wrong happned");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
