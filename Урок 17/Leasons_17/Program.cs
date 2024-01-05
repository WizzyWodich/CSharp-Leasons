using System;
// Аксессоры «get» и «set»
// Переходим в Robot.cs
namespace Leasons_17{

    class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot", 900, new byte[] {12,12,12}); 
            bot.printValues(); 

            Robot kiler = new Robot(); 
            kiler.setValues("Kirler", 230, new byte[] {1,54,0});
            kiler.printValues();


            // Будем вызывать для данного объекта
            Robot bot_1 = new Robot("Kirysha"); 
            bot_1.Weight = -100; // Установим отрицательное значение но в поле попадет число 1.
            System.Console.WriteLine(bot_1.Weight); // Выведим значение в консоль.
            // Идем в Robot.cs
            
            bot_1.Width = -100; // Теперь мы обращяемся к нашему второму аксессору и мы можем спокойно установить что хотим(но одного типа данных)
            System.Console.WriteLine(bot_1.Width); // Выведим данные в консоль. 
            // Теперь мы никак не взаимодействуем напрямую с полями а только через аксессор.
            // Зачем же так делать? Идем в Robot.cs 
            /* Теперь когда доступ к получению данных закрыт будет ощибка:
            `error CS0271: Свойство или индексатор "Robot.Width" невозможно использовать в данном контексте, так как метод доступа get недоступен.`
            */
            // Переходим в Robot.cs 


            Robot.Print();
            
            Console.ReadLine();
        }
    }
}
