using System;

namespace Leasons_21
{

    class Bot : Robot
    {
        // Изменим конструкторы.
        // Идем в Main
        public Bot() { }


        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates)
        {
            
        }

        // Реализуем метод который абстрактный в классе 'Robot' который нас просят 
        public override void printValues()
        {
            // throw new NotImplementedException(); // По умолчанию он пытаеться выбросить ошибку (Вызываеться если не реализован метод)

            // И да просто так 'this.name' мы не можем обратиться так как у них модификатор доступа 'private' тогда обращяемся к аксессору.
            // Есть аксессоры для name, weight но нету для сoordinates так что создадим переходим в Robot.cs и создаем аксессор.
            Console.WriteLine(this.Name + " weight: " + this.Weight + ". Coordinates: ");
            foreach (byte el in this.Coordinates)
                Console.WriteLine(el);
            // Для Killer мы так же напишем такой код но не будем выводить координаты.
            // Идем в Killer.cs
        }
    }
}