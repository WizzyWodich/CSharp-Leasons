using System;
// Наследование классов
// Переходим в Robot.cs
namespace Leasons_18{

    class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot", 900, new byte[] {12,12,12}); 
            bot.printValues(); 

            Killer killer = new Killer("Killer", 1200, new byte[] {1,3,6}, 100); // Теперь объект 'killer' создан на основе дочернего класса 'Killer' но мы не можем использовать конструкторы из класса Robot 
                                                                                // их нужно будет переписывать в дочернем классе. Использовать можем только конструктор по умолчанию.
                                                                                // Переходим в Killer.cs
            //(Было удаленно setValues()) в параметры нашего конструктора я передал значения а так же одно дополнительное 'healts'.
            // killer.prontValues(); Уже нам не нужно.
            //(Удалил инициализацию аксессора Heaslts)
            // Переходим в Killer.cs
            // Теперь когда есть метод Lazer() в дочернем классе я могу его использовать тут.
            killer.Lazer();
            // Переходим в Killer.cs
            // теперь после создания и заполнения нашего конструктора переходим в Killer.cs

            // Теперь про модификатор доступа 'protected'
            // Переходим в Robot.cs


            
            
            Robot bot_1 = new Robot("Kirysha"); 
            bot_1.Weight = -100; 
            System.Console.WriteLine(bot_1.Weight); 
            
            
            bot_1.Width = -100; 
            System.Console.WriteLine(bot_1.Width);  
            


            Robot.Print();
            
            Console.ReadLine();
        }
    }
}
