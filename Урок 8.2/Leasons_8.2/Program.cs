using System;
// Вывод массива

namespace Leasons_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создам массив
            int[] array = { 10, 4, 3, 53};
            // Массив всегда знаем сколько у него элементов. array.Length
            Console.WriteLine(array[3]); // Вывод 53
            // Выведим все через for
            for (int i = 0; i < array.Length; i++) // Каждую итерацию мы будем сдвигаться по элементам массива имея длину нашего масиива.
                Console.WriteLine($"Элемент масива: {array[i]}");

        }
    }
}

