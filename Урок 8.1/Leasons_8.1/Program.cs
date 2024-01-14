using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Инициализация массива

namespace Leasons_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявлю масив на 5 элементов.
            /* Так конечно хорошо но...
            int[] array;
            array = new int[10];
            */

            int[] array = new int[5]; // Но так лучше 
            // Можно обявить сразу.
            int[] array_2 = new int[5] {1,2,3,4,5}; // Инициализировать так можно но будет ошибка если их будет 4 элемента вместо заявленых 5 
                                                     // Так как среда разработки проверяет сколько должно быть элементов в масиве. Это можно избежать.

            // Не явное указание кол-во элементов в масиве.
            int[] array_3 = new int[] { 1, 2, 3, 4}; // Но если не указывать что то в фигурных скобюках то нужно обязательно уазывать в квадратных.
            // Можно упростить данную конструкцию. Так как мы заполнили наш масив.
            int[] array_4 = new [] { 1, 2, 3, 4 }; // В таком случае нам можно не указывать явно тип данных масива. Но так нельзя: int[] array_4 = new [5];

            // Если нам нужно присвоить в масив значения но только не 0. Используем класс Enumerable.
            int[] myArray = Enumerable.Repeat(3, 10).ToArray(); // Теперь массив из 10 элементов который содержит только 5.

            // Демонтрация цикла который в следуюших уроках.
            // Что если нам нужно пронумеровать начиная с `n` элемента.
            // Для того что бы был отсчет от n числа используем Range

            Console.Write("Введите количество элементов в массив.");
            int amountElements = int.Parse(Console.ReadLine()); 

            Console.Write("Введите с какого числа начинать.");
            int seedNumber = int.Parse(Console.ReadLine());

            int[] myArray_2 = Enumerable.Range(seedNumber, amountElements).ToArray();

            foreach (var elements in myArray_2)
                Console.WriteLine($"Число: {elements}");
            

        }
    }
}

