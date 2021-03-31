using System;

namespace NewProject
{
    class Program
    {
        private static NLog.Logger _logger =
        NLog.LogManager.GetCurrentClassLogger();

        public static void SomeMethod()
        {
            if (true)//type if press tab2x
            {

            }
            for (int a = 0; a < length; a++)//type for press tab2x
            {

            }
            foreach (var item in collection)
            {

            }
            switch (switch_on)
            {
                default:
            }
        
            private string name;//propfull

              public string MyProperty
              {
                   get { return name; }
                   set { name = value; }
                }
        //edit -->intellisense -->surround with 
            //_logger.Info("SomeMethod() has been executed");

        //try
        //{
        //    int a = 77;
        //    int b = 0;

        //    int res = a / b;
        //}
        //catch (Exception e)
        //{
        //    _logger.Error(e, "Somethig wrong happned");
        //}
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }
}
