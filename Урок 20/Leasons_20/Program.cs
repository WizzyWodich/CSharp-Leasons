using System;
using System.Collections.Generic;
// Виртуальные методы
// Переходим в Robot.cs

namespace Leasons_20{

    class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot", 900, new byte[] {12,12,12}); 
            bot.printValues(); 

            Killer killer = new Killer("Killer", 1200, new byte[] {1,3,6}, 100); 
            killer.printValues(); // выведит все а тк же здоровье
            // Переходим в Killer.cs
            killer.Lazer();

            
            Robot bot_1 = new Robot("Kirysha"); 
            bot_1.Weight = -100; 
            Console.WriteLine(bot_1.Weight); 
            
            
            bot_1.Width = -100; 
            Console.WriteLine(bot_1.Width);  

            Robot.Print();
        
        }
    }
}
