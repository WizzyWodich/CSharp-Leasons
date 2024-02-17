using System;

// Цикл «do while»
/*
 * Цикл do while очень похож на while.
 */
// Принцип работы: Делай-Проверяй
namespace Lessons_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример
            // while (true) // Проверяется условие, если истина, то выполняется.
            // {}


            // Цикл do while сперва делает, а потом проверяет. Всегда выполняется хотя бы один раз, даже если условие равно false.
            do
            {
                Console.WriteLine("Выполняю действие");
            } while (false);

            // Пример 2

            int count = 5;
            // Не выполнится вообще, так как count = 5.
            while (count < 5) // Если меньше 5, то выполнять.
            {
                Console.WriteLine("WHILE");
            }

            // Выполнится 1 раз, даже при условии, что count = 5.
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
