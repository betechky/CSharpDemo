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
            return "Cage {0}" + " contains a  " + Age + "-year-old " + Species + " that runs " + _speedKmh + " km/h ";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("How fast can it run (in km/h)? ");
            _speedKmh = Console.ReadLine();
        }
    }
    public class Bear : IAnimal
    {
        string _grizzlyBear;
        
        public int Age { get; set; }

        public string Species { get => "Bear"; }

        public string GetDescription()
        {
            if (_grizzlyBear == "yes")
                return "Cage" + " contains a  " + Age + "-year-old " + Species + " grizzly Bear ";
            else
                return "Cage" + " contains a  " + Age + "-year-old " + Species + " non-grizzly Bear ";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("Is it a grizzly bear (Yes/No)? ");
            _grizzlyBear = Console.ReadLine();
        }
    }
    public class Lion : IAnimal
    {
        private string _maneColour;
        public int Age { get; set; }
        public string Species { get => "Lion"; }

        public string GetDescription()
        {
            return "Cage"  +  " contains a  " + Age +"-year old "+ Species + " with a "  +_maneColour + " mane " ;
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
            string Animal;
            IAnimal l = new Lion();
            IAnimal b = new Bear();
            IAnimal w = new Wolf();
            
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Cage " + i);
                Console.Write("What is the name of the species? ");
                Animal = Console.ReadLine();
                Console.Write("How old is it? ");
                switch (Animal)
                {
                    case "lion":
                        l.Age = Convert.ToInt32(Console.ReadLine());
                        l.RequestUniqueCharacteristic();
                      //  Console.WriteLine(l.GetDescription());
                        break;
                    case "bear":
                        b.Age = Convert.ToInt32(Console.ReadLine());
                        b.RequestUniqueCharacteristic();
                      // Console.WriteLine(b.GetDescription());
                        break;
                    case "wolf":
                        w.Age = Convert.ToInt32(Console.ReadLine());
                        w.RequestUniqueCharacteristic();
                      // Console.WriteLine(w.GetDescription());
                        break;
                }
         
            }
           

            List<IAnimal> animals = new List<IAnimal>();
            {
                animals.Add(l);
                animals.Add(b);
                animals.Add(w);
            };

            Console.WriteLine("\n-----------------------\n");
            foreach (var animal in animals)
            {
               
                Console.WriteLine(animal.GetDescription());
            }

         
        }
    }
}
