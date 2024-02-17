using System;
// Вывод массива. Массивы и циклы
namespace Lessons_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива
            int[] array = { 10, 4, 3, 53 };

            // Выводим элемент массива по индексу (индексация начинается с 0)
            Console.WriteLine(array[3]); // Выводится 53

            // Выводим все элементы массива с использованием цикла for
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"Элемент массива: {array[i]}");
        }
    }
}
