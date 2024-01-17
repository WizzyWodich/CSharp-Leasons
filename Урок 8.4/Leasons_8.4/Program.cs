using System;
// Индексы и диапозоны

namespace Leasons_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создам массив
            int[] array = { 1, 2, 3, 6, 73, 99 };

            Console.WriteLine(array[5]); // Вывод 99

            int[] array2 = { 1, 2, 3, 6, 73, 99, 1 };
            // А что если массив изменился и нужно все равно выводить последний элемент что делать?
            Console.WriteLine(array2[array2.Length - 1]); // Всегда выводить послений символ.
            // Но можно и по другому.
            Console.WriteLine(array2[^1]); // Начать вывод с последнего элемента.

            // Диапозоны
            // Извлечем из одного масиива в другой элементы в диапозоне с 1-3
            int[] array3 = { 1, 2, 3, 6, 73, 99, 1 };

            int[] array4 = array3[1..3];

            int[] array5 = array3[..5]; // Извлечь от начала до 5 элемента

            int[] array6 = array3[5..]; // Извлечь от  5 элемента до конца

            // ^ это тип данных структуры Index

            Index myIndex = ^3;

            Console.WriteLine(array3[myIndex]); // 3 элемент с конца

            // Выведем информацию за индексы.

            Console.WriteLine($"Value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");

            Index myIndex2 = 3;

            Console.WriteLine(array3[myIndex2]); // 3 элемент с начала

            // Выведем информацию за индексы.

            Console.WriteLine($"Value {myIndex2.Value} isFromEnd {myIndex2.IsFromEnd}"); // IsFromEnd - false

            // Конструктор 
            Index myIndex3 = new Index(3); // 3-й элемент с начала
            Index myIndex4 = new Index(3,true); // 3-й элемент с конца

            // Работа структур с строками
            // Создам строку.
            string str = "Hello World ;)";
            Console.WriteLine(str[^2..]); // Range структура вывод ;)
            Console.WriteLine(str[0..6]); // Hello
        }
    }
}

