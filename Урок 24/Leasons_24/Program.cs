using System;
// Перечисления (enum)
/* 
 * Enumeration (enum) - перечисления позволяют нам создать удобный список в котором через запятую будут значения мы можем на основе данного списка 
 * создать переменую и соотвецтвенно мы можем для данного поля можем установить то значение которое есть в перечисление и для этого нам нужно 
 * обратиться к перечислению и через точку выбираем одно из возможных.
 * Переходим в Killer.cs
*/

namespace Leasons_24
{

    class Program
    {
        static void Main(string[] args)
        {
            
            //Bot bot = new Bot("Bot", 900, new byte[] { 12, 12, 12 });
            //bot.printValues();

            
            Killer killer = new Killer("Killer", 1200, new byte[] { 1, 3, 6 }, 100, Type.Hero); // Пусть наш объект будет Героем 
            // Перейдем в Killer.cs
            killer.printValues();
            killer.Lazer();

            
            //Bot bot_1 = new Bot(); /
            //bot_1.Weight = -100;
            //Console.WriteLine(bot_1.Weight);

        }
    }
}
