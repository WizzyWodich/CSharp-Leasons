using System;

namespace Leasons_21{

     class Killer : Robot 

     {
        public int Healts{ get; set; } 

        public Killer(){} 

        
        public Killer(string name, int weight, byte[] coordinates, int healts) : base(name, weight, coordinates)
        {
            this.Healts = healts;
        }

        // Изменили.
        // Переходим в наш Main и тестируем.
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