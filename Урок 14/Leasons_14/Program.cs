using System;
// ООП Создание классов и объектов

namespace Leasons_14{

    class Program
    {
        static void Main(string[] args)
        {
            // Заполнение класса при условии что у нас private поля 0
            /*Robot bot = new Robot();
            bot.setValues("Bot", 900, new byte[] {12,12,12}); // Обращаемся к методу что бы передать в параметры информацию о боте
            bot.printValues(); // Обращяемся к методу что бы вывести в консоль информацию.

            Robot kiler = new Robot();
            kiler.setValues("Kirler", 230, new byte[] {1,54,0});
            kiler.printValues();
            */


            // Ниже я обращялся к полям класа когда они были public 
            /*
            Robot bot = new Robot(); // <Тип данных> <Название> = <Выделить память>  Конструктор по умолчанию.

            
            bot.name = "Botinok";
            bot.weight = 550;
            bot.coordinates = new byte[] {0, 0, 0};

            System.Console.WriteLine(bot.name + "weight: " + bot.weight); 

            Robot kiler = new Robot(); 
            kiler.weight = 1000;
            kiler.name = "Kiler 777";
            kiler.coordinates = new byte[]{23,54,122};
            */
        }
    }

    // Cоздание класса
    // class Robot
    // {
    //     /* Классы можно создавать вне класса Main и других.
    //      Но лутше всего их создавать в другом файле 
    //      то есть мы создаем файл с расширением .cs в папке нашего проэкта.
    //      */
    // }
}
