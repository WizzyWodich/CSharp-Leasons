using System;
// Индексы и диапозоны

namespace Lessons_8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива
            int[] array = { 1, 2, 3, 6, 73, 99 };

            Console.WriteLine(array[5]); // Вывод 99

            int[] array2 = { 1, 2, 3, 6, 73, 99, 1 };
            // Вывод последнего элемента массива
            Console.WriteLine(array2[array2.Length - 1]); // Всегда выводим последний символ
            // Можно сделать иначе
            Console.WriteLine(array2[^1]); // Начать вывод с последнего элемента

            // Диапазоны
            // Извлечение элементов в диапазоне с 1 по 3
            int[] array3 = { 1, 2, 3, 6, 73, 99, 1 };
            int[] array4 = array3[1..3]; // Срез с 1 по 2 индекс

            int[] array5 = array3[..5]; // Срез от начала до 4 индекса

            int[] array6 = array3[5..]; // Срез с 5 индекса до конца

            // Использование индекса ^
            Index myIndex = ^3;
            Console.WriteLine(array3[myIndex]); // 3-й элемент с конца

            // Вывод информации об индексах
            Console.WriteLine($"Value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");

            Index myIndex2 = 3;
            Console.WriteLine(array3[myIndex2]); // 3-й элемент с начала

            // Вывод информации об индексах
            Console.WriteLine($"Value {myIndex2.Value} isFromEnd {myIndex2.IsFromEnd}");

            // Конструкторы
            Index myIndex3 = new Index(3); // 3-й элемент с начала
            Index myIndex4 = new Index(3, true); // 3-й элемент с конца

            // Работа структур с строками
            // Создание строки
            string str = "Hello World ;)";
            Console.WriteLine(str[^2..]); // Вывод последних двух символов ";)"
            Console.WriteLine(str[0..6]); // Вывод символов с 0 по 5
        }
    }
}
