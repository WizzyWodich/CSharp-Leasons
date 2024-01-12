using System;
// Цикл «do while»
/*
 * Цикл do while очень похож на while
 */
// Принцип работы Делай-Проверяй
namespace Leasons_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример
            //while (true) // Проверяеться условие если истина то выполняеться.
            //{}
                
       
            // Цикл do while сперва делает а после проверяет. Всегда выполняеться один раз если даже false.
            do {
                Console.WriteLine("Выполняю действие");
            } while (false);

            // Пример 2

            int count = 5;
            // НЕ выполниться вообще так как count = 5
            while (count < 5) // Если меньше 5 то выполнять.
            {
                Console.WriteLine("WHILE");
            }

            // Выпролниться 1 раз даже при условии что count = 5
            do
            {
                Console.WriteLine("DO WHILE");
            } while (count < 5);


            int count2 = 0;
            do
            {
                count2++;
                Console.WriteLine(count2);
            } while (count2 < 5);
        }
    }
}
