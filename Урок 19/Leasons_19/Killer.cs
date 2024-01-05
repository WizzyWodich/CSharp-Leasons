using System;

namespace Leasons_19{

     class Killer : Robot 

     {
        public int Healts{ get; set; } 

        public Killer(){} 


        public Killer(string name, int weight, byte[] coordinates, int healts) : base(name, weight, coordinates)
        {
            this.Healts = healts;
            base.printValues();
        }

        public void Lazer(){
            System.Console.WriteLine("Lazer shooting"); 
            this.sName = "Botinochek"; 
        }

     }
}