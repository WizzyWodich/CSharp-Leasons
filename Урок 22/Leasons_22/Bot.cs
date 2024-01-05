using System;

namespace Leasons_22
{
    // Дочерный класс с полями конструктором и переделаным абстрактным методом из класса Robot

    class Bot : Robot
    {
        
        public Bot() { }


        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates)
        {
            
        }

       
        public override void printValues()
        {
            Console.WriteLine(this.Name + " weight: " + this.Weight + ". Coordinates: ");
            foreach (byte el in this.Coordinates)
                Console.WriteLine(el);
        }
    }
}