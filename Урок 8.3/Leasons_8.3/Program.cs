using System;
using System.Linq;
// Работа с массивом
namespace Lessons_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти наибольший и наименьший элемент массива.
            int[] array = { 101, 223, 3, 44, 10, 7, 101, 44, 7 };

            Console.WriteLine($"Наименьший элемент массива: {array.Min()}");
            Console.WriteLine($"Наибольший элемент массива: {array.Max()}");

            // Можно найти сумму всех элементов.
            Console.WriteLine($"Сумма всех элементов массива: {array.Sum()}");
            // Найти сумму всех четных элементов.
            Console.WriteLine($"Сумма всех четных элементов массива: {array.Where(i => i % 2 == 0).Sum()}");
            // Найти минимальное нечетное значение.
            Console.WriteLine($"Минимальное среди нечетных элементов массива: {array.Where(i => i % 2 != 0).Min()}");

            // Найти уникальные числа в массиве (убрать повторяющиеся).
            Console.WriteLine("Уникальные числа массива:");
            int[] uniqueArray = array.Distinct().ToArray();
            foreach (var el in uniqueArray)
                Console.WriteLine(el);

            // Сортировка массива.
            Console.WriteLine("Сортировка массива:");
            int[] sortedArray = array.OrderBy(i => i).ToArray();
            foreach (var el in sortedArray)
                Console.WriteLine(el);

            // Сортировка массива в порядке убывания.
            Console.WriteLine("Сортировка массива в порядке убывания:");
            int[] reverseSortedArray = array.OrderByDescending(i => i).ToArray();
            foreach (var el in reverseSortedArray)
                Console.WriteLine(el);

            // Работа с классом Array.
            Console.WriteLine("Класс Array:");

            int firstBelow70 = Array.Find(array, i => i < 70); // Выбрать первое число с начала массива, которое меньше 70.
            Console.WriteLine(firstBelow70);

            int lastBelow70 = Array.FindLast(array, i => i < 70); // Выбрать первое число с конца массива, которое меньше 70.
            Console.WriteLine(lastBelow70);

            Console.WriteLine("Все числа массива, которые меньше 70:");
            int[] below70Array = Array.FindAll(array, i => i < 70); // Выбрать все числа массива, которые меньше 70.
            foreach (var item in below70Array)
                Console.WriteLine(item);

            Console.WriteLine("Индекс определенного числа:");
            int index = Array.IndexOf(array, 3); // Индекс первого вхождения числа.
            Console.WriteLine(index);

            Console.WriteLine("Индекс определенного числа с конца:");
            int lastIndex = Array.LastIndexOf(array, 3); // Индекс последнего вхождения числа.
            Console.WriteLine(lastIndex);

            // Реверс массива
            Array.Reverse(array);

            // Все это также можно реализовать с помощью LINQ, но LINQ более поздний, чем Array.
        }
    }
}
