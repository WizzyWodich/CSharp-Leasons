using System;
using System.Linq;
// Инициализация массива
namespace Lessons_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление массива
            int[] array = new int[5]; // Лучше инициализировать сразу

            // Инициализация массива
            int[] array_2 = new int[5] { 1, 2, 3, 4, 5 }; // При инициализации указываем все элементы

            // Неявное указание количества элементов в массиве
            int[] array_3 = new int[] { 1, 2, 3, 4 }; // Количество элементов определяется автоматически
            // Можно упростить данную конструкцию, так как мы заполнили наш массив
            int[] array_4 = new[] { 1, 2, 3, 4 }; // Тип данных массива определяется автоматически

            // Если нам нужно присвоить массиву значения, но не 0, используем класс Enumerable
            int[] myArray = Enumerable.Repeat(3, 10).ToArray(); // Массив из 10 элементов, содержащий только значение 3

            // Демонстрация цикла, который будет рассмотрен в следующих уроках
            // Что если нам нужно пронумеровать, начиная с `n` элемента?
            // Для этого используем Range
            Console.Write("Введите количество элементов в массиве: ");
            int amountElements = int.Parse(Console.ReadLine());

            Console.Write("Введите с какого числа начинать: ");
            int seedNumber = int.Parse(Console.ReadLine());

            int[] myArray_2 = Enumerable.Range(seedNumber, amountElements).ToArray();

            foreach (var element in myArray_2)
                Console.WriteLine($"Число: {element}");
        }
    }
}
