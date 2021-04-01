using System;
using System.Collections.Generic;
using iAnimalClassLibrary;

namespace ZooAnimals
{
    interface IAnimal
    {
        int Age { set; get; }
        string Species { get; }

        void RequestUniqueCharacteristic();
        string GetDescription();
    }
    public class Wolf : IAnimal
    {
        private string _speedKmh;
        public int Age { get; set; }

        public string Species { get => "Wolf"; }

        public string GetDescription()
        {
            return  Age + "-year-old " + Species + " that runs " + _speedKmh + " km/h ";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("How fast can it run (in km/h)? ");
            _speedKmh = Console.ReadLine();
        }
    }
    public class Bear : IAnimal
    {
       
        public bool IsGrizzly;

        public int Age { get; set; }

        public string Species { get => "Bear"; }

        public string GetDescription()
        {
       
            return Age + "-year-old " +
                (IsGrizzly ? "" : "non-") + "grizzly " + Species;
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("Is it a grizzly bear (Yes/No)? ");
            //IsGrizzly = Console.ReadLine();
            IsGrizzly = Console.ReadLine().ToLower() == "yes";
        
        }
    }
    public class Lion : IAnimal
    {
        private string _maneColour;
        public int Age { get; set; }
        public string Species { get => "Lion"; }

        public string GetDescription()
        {
            return  Age +"-year old "+ Species + " with a "  +_maneColour + " mane " ;
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("What colour is its mane? ");
            _maneColour = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int totalAnimal = 3;
            List<IAnimal> animals = new List<IAnimal>();
           
            
            for (int i = 0; i < totalAnimal; i++)
            {

                Console.WriteLine("\nCage " + (i+1));
                Console.Write("What is the name of the species? ");
                string Animal = Console.ReadLine().ToLower();
             
                IAnimal newAnimal = null;
             
                switch (Animal)
                {
                    case "lion":
                        newAnimal = new Lion();
                        break;
                    case "bear":
                        newAnimal = new Bear();
                        break;
                      
                    case "wolf":
                        newAnimal = new Wolf();
                        break;
                    default:
                        Console.WriteLine("Please Enter Lion, Bear or Wolf");
                        break;
                }
                Console.Write("How old is it? ");
                newAnimal.Age = Convert.ToInt32(Console.ReadLine());
                newAnimal.RequestUniqueCharacteristic();
                animals.Add(newAnimal);

            }
           


            Console.WriteLine("\n-----------------------\n");
            foreach (var animal in animals)
            {
                int ind = animals.IndexOf(animal);
                Console.Write($"Cage {ind + 1} contains a ");
                Console.WriteLine(animal.GetDescription());
            }

         
        }
    }
}
