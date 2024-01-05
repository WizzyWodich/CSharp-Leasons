using System;
// Указатель «this» в классах
// Переходим в Robot.cs

namespace Leasons_16{

    class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot", 900, new byte[] {12,12,12}); 
            bot.printValues(); 

            Robot kiler = new Robot(); // 2-й написаный конструктор.
            kiler.setValues("Kirler", 230, new byte[] {1,54,0});
            kiler.printValues();

            Robot bot_1 = new Robot("Kirysha"); 
            
            Robot.Print(); 

            Console.ReadLine();
        }
    }
}
