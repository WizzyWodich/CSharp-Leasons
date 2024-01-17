using System;
// Цикл «foreach» для работы с массивами. Вывод двухмерного массива в консоль
// Так как и с одномерным масивом двухмерный можно вывести через циклы но вложеные циклы.
namespace Leasons_8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
               {1,2,4,5,6},
               {33,4,77,22,44},
               {4,6,8,9,112},
               {24,76,18,94,1122}
            };

            // foreach - Будет вывод простой не в виде таблице.
            Console.WriteLine("Массив через foreach");
            foreach (var item in array)
                Console.Write($"{item} ");

            Console.WriteLine();
            Console.WriteLine("Информация про массив:");
            Console.WriteLine();

            Console.WriteLine($"Количество измерений массива: {array.Rank}"); // Узнать количество измерений массива.
            Console.WriteLine($"Все количество элементов массива: {array.Length}"); // Все количество элементов массива.
            Console.WriteLine($"Количество элементов в 1 измерении : {array.GetLength(0)}") ; // Количество элементов в 1 измерении.

            Console.WriteLine();
            Console.WriteLine("Массив через for");
            Console.WriteLine();
            // Создам переменные

            // int height = array.GetLength(0); // Узать сколько рядов - Не обязательно
            // int width = array.GetLength(1); // Узнать сколько строк - Не обязательно

            for (int i = 0; i < array.GetLength(0); i++) // Проход по рядам
            {
                for (int j = 0; j < array.GetLength(1); j++) // Проход по строкам
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

        }
    }

}

