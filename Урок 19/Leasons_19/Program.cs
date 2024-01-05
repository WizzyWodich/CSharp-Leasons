using System;
using System.Collections.Generic;
// Операторы is и as. Массив указателей

namespace Leasons_19{

    class Program
    {
        static void Main(string[] args)
        {
            // Robot bot = new Robot("Bot", 900, new byte[] {12,12,12}); 
            // bot.printValues(); 

            // Killer killer = new Killer("Killer", 1200, new byte[] {1,3,6}, 100); 
            // killer.Lazer();

            
            // Robot bot_1 = new Robot("Kirysha"); 
            // bot_1.Weight = -100; 
            // Console.WriteLine(bot_1.Weight); 
            
            
            // bot_1.Width = -100; 
            // Console.WriteLine(bot_1.Width);  

            // Robot.Print();
            

            // Создадим динамический масив.
            // Теперьь мы список а точнее масив где есть 4 объекта созданы на основе класса Robot
            // Теперь перепберем масив

            // List<Robot> robots = new List<Robot> ();
            // robots.Add(new Robot("Alex", 400, new byte[] {77,15,3}));
            // robots.Add(new Robot("Bob", 500, new byte[] {23,13,8}));
            // robots.Add(new Robot("Josh", 600, new byte[] {1,56,9}));
            // robots.Add(new Robot("Jon", 900, new byte[] {7,11,5}));
            // foreach (Robot obj in robots){ // В качестве типа данных указываем наш класс Robot т-к кажный элемент на основе 
            //                                 // нашего класса и переменные должны быть одинаковые.
            //     // Допишу аксессор для взаимодействия с sName (Robot.cs)
            //     Console.WriteLine(obj.Name);

            //     // Был создан масив указателей.
            // }


            /* Теперь про операто 'as'
            За счет данного оператора мы имеем доступ к обработке объекта как объект другого класса
            Реализую:
            */
            List<Killer> robots = new List<Killer> ();
            robots.Add(new Killer("Alex", 400, new byte[] {77,15,3}, 100));
            robots.Add(new Killer("Bob", 500, new byte[] {23,13,8}, 100));
            robots.Add(new Killer("Josh", 600, new byte[] {1,56,9}, 100));
            robots.Add(new Killer("Jon", 900, new byte[] {7,11,5}, 100));

            // Я хочу что бы Josh был обработан как объект класса 'Robot'
            Robot newRobot = null; // Установим пустоту в объект.
            foreach (Robot obj in robots){
                if(obj.Name == "Josh") { // Если имя нашего бота Josh тогда мы обработаем его как объект на основе класса Robot
                    newRobot = obj as Robot; // as Robot можно и не писать т-к наш newRobot основан на классе Robot но так работает не всегда.
                                            // то есть мы явно приводим к другому типу данных объект. Но теперь я не могу обратиться к методам дочернего класса 
                                            // то есть newRobot.Lazer (ERROR)

            // Оператор 'is' позволяет проверить принадлежит ли объект к определенному типу данных.
            // Теперь я не буду выводить имена в консоль а проверю являеться ли наш объет obj созданый на основе класса <Название класса>
                }
                Console.WriteLine(obj is Robot); 
                Console.WriteLine(obj is Program); // Являеться ли наш объет obj созданый на основе класса Program 
                Console.WriteLine(obj is int); // Проверяю на обпереленый тип данных

                int num = 9;
                Console.WriteLine(num is float); // Являеться ли наш num с типом данных float / Вывод True
            }
            Console.ReadLine();
        }
    }
}
