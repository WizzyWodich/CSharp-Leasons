using System;

namespace Leasons_20{

     class Killer : Robot 

     {
        public int Healts{ get; set; } 

        public Killer(){} 

        
        public Killer(string name, int weight, byte[] coordinates, int healts) : base(name, weight, coordinates)
        {
            this.Healts = healts;
            /* Тут так же есть вывод но дополнительно мы не выводим что есть у нас в классе Killer было бы удобно есть ли бы мы могли переписать 
            * Метод родительского класса то есть если мы будем вызывать что бы дополнительно выводилось что то из класса Killer то есть когда мы создаем
            объект на основе класса Robot вызывался метод из класса Robot а когда на основе класса Killer то метод из класса Robot но мы его дополним 
            Такое можно реализовать с помощью virtual
            Переходим в Robot.cs к методу printValues()
            */
            // base.printValues(); эта строчка теперь нам не нужна.
        }
        // Перепишем printValues для этого используем override
        public override void printValues(){
            base.printValues(); // Мы можем удалить данную строчку но оставлю 

            System.Console.WriteLine("Health " + this.Healts); 
            // Переходим в Main

            // ! Не нужно переписывать код прям полностью то есть у него должна быть база от родительского класса 
            // Оно будет работать но это будет плохой код.
            // лутше написать отдельный метод ввода чем полностью переписать метод вывода.
        }



        public void Lazer(){
            System.Console.WriteLine("Lazer shooting"); 
            this.sName = "Botinochek"; 
        }

     }
}