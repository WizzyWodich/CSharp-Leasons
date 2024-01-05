using System;

namespace Leasons_22{
     // Дочерный класс с полями конструктором и переделаным абстрактным методом из класса Robot
     class Killer : Robot

    {
        public int Healts{ get; set; } 

        public Killer(){} 

        
        public Killer(string name, int weight, byte[] coordinates, int healts) : base(name, weight, coordinates)
        {
            this.Healts = healts;
        }

        public override void printValues(){
            Console.WriteLine(this.Name + " weight: " + this.Weight + ".");

            Console.WriteLine("Health " + this.Healts); 
        }

        public void Lazer(){
            System.Console.WriteLine("Lazer shooting"); 
            this.sName = "Botinochek"; 
        }

     }
}