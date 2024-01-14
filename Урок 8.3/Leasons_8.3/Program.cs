using System;
using System.Collections.Immutable;
using System.Linq;
// Работа с массивом
// Массивы в С# наследники класса Аrray и все методы идут от туда.
// В ПРИМЕРАХ ЕСТЬ ТО ЧЕГО НЕ БЫЛО РАНЬШЕ!
namespace Leasons_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти найбольший и найменьший элемент масива.

            int[] array = { 101, 223, 3, 44, 10, 7, 101, 44, 7 };
            // Что бы быстро найти элемент массива найменьший или найбольший используем методы Max Min
            // Даные методы являются Extension(Расширение) то есть лежит не в класе Array и что бы все работало используем using System.Linq 
            Console.WriteLine($"Найменьший элемент массива: {array.Min()}");
            Console.WriteLine($"Найбольший элемент массива: {array.Max()}"); 
             
            // Можно найти сумму всех элементов.
            Console.WriteLine($"Сумма всех элементов массива: {array.Sum()}");
            // Найти суму всех четных элементов
            // !! Метод Where принимает делегаты. Что это такое будет дальше.
            Console.WriteLine($"Сумма всех четных элементов массива: {array.Where(i => i % 2 == 0).Sum()}"); //  Ищем сперва четные элементы после сумируем.
            // Найти не четное минимальное значиние.
            Console.WriteLine($"Минимальное среди не четных элементов массива: {array.Where(i => i % 2 != 0).Min()}");

            // Найти уникальные уникальные числа массива (убрать повторяющиеся).
            // Создадим новый массив.
            Console.WriteLine("Найти уникальные уникальные числа массивая.");
            int[] ressul = array.Distinct().ToArray();
            foreach (var el in ressul)
                Console.WriteLine(el);


            // Сортировка массива.
            Console.WriteLine("Сортировка массива.");
            int[] ressul_2 = array.OrderBy(i => i).ToArray();
            foreach (var el in ressul_2)
                Console.WriteLine(el);


            // Сортировка массива в порядке убывания. 
            Console.WriteLine("Сортировка массива в порядке убывания.");
            int[] ressul_3 = array.OrderByDescending(i => i).ToArray();
            foreach (var el in ressul_3)
                Console.WriteLine(el);

            // КЛАСС Array 

            // array.Sort(); // Ошибка так как метод статический и доступен только на уровне класса.
            Console.WriteLine("Class Array.");

            int ress = Array.Find(array, i => i < 70); // Выбрать первое число с начала массива которое меньше 70.
            Console.WriteLine(ress);

            int ress_2 = Array.Find(array, i => i < 70); // Выбрать первое число с конца массива которое меньше 70.
            Console.WriteLine(ress_2);

            Console.WriteLine("Выбрать все числа массива которые меньше 70");
            int[] ress_3 = Array.FindAll(array, i => i < 70); // Выбрать все числа массива которые меньше 70.
            foreach (var item in ress_3)
                Console.WriteLine(item);


            Console.WriteLine("Узнать индекс определеного числа"); 
            int result = Array.FindIndex(array, i => i == 3); // С начала в конец
            Console.WriteLine(result);

            Console.WriteLine("Узнать индекс определеного числа с конца"); 
            int result2 = Array.FindLastIndex(array, i => i == 3); // С конца в начало 
            Console.WriteLine(result);

            // Реверс
            Array.Reverse(array); // С конца в начало 


            // Так же это все можно реализовать с помощью Linq. Linq более поздняя чем Аrray.
        }
    }
}

