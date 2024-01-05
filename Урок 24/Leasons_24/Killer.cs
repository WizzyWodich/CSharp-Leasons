using System;

namespace Leasons_24{
    // Создадим тут перечисление.
    // Перечисления будет выбор типа бота которого мы можем создать
    // enum <Название перечисления> <{Значения}>
    enum Type { Enemy, Hero, Traitor }


     // Дочерный класс с полями конструктором и переделаным абстрактным методом из класса Robot
     class Killer : Robot

    {
        public int Healts{ get; set; }

        // Создадим поле у которого тип данных будет такое же как и имя нашего перечисления.
        public Type type;

        public Killer(){} 

        // Добавим в параметры наше перечисление
        public Killer(string name, int weight, byte[] coordinates, int healts, Type type) : base(name, weight, coordinates)
        {
            this.Healts = healts;
            this.type = type; // То что мы будем передавать в конструктор.
            // Переходим в Main.
        }

        public override void printValues(){
            Console.WriteLine(this.Name + " weight: " + this.Weight + ".");

            Console.WriteLine("Health " + this.Healts);
            // Теперь мы можем сделать проверку.

            if (this.type == Type.Hero) // Если было выбрано тип робота Герой то вывести надпись.
                Console.WriteLine("He is hero!");
            
        }

        public void Lazer(){
            System.Console.WriteLine("Lazer shooting"); 
            this.sName = "Botinochek"; 
        }

     }
}