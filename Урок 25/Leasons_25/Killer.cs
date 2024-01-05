using System;

namespace Leasons_25
{
    // Перечисление
    enum Type { Enemy, Hero, Traitor }


    // Дочерный класс с полями конструктором и переделаным абстрактным методом из класса Robot
    class Killer : Robot

    {
        public int Healts { get; set; }

        // Создадим поле у которого тип данных будет такое же как и имя нашего перечисления.
        public Type type;

        public Killer() { }

        // Добавим в параметры наше перечисление
        public Killer(string name, int weight, byte[] coordinates, int healts, Type type) : base(name, weight, coordinates)
        {
            Healts = healts;
            this.type = type;
        }

        public override void printValues()
        {
            Console.WriteLine(Name + " weight: " + Weight + ".");

            Console.WriteLine("Health " + Healts);

            if (type == Type.Hero)
                Console.WriteLine("He is hero!");

        }

        public void Lazer()
        {
            Console.WriteLine("Lazer shooting");
            sName = "Botinochek";
        }

    }
}