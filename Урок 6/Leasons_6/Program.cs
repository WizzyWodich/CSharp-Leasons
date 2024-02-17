﻿using System;

// Цикл while
/*
 * Задача любого цикла (while, do while, for, foreach) - выполнять действия столько раз, пока не достигнут результат.
 */

// while работает принципом Проверяю-делаю.
namespace Lessons_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример: тут выполняется 2 раза действие, но если мне нужно 100 или 1000 раз такое вывести, глупо будет писать все это столько раз. 
            // В таком случае нам может помочь цикл.
            Console.WriteLine("Выполняю действие!");
            Console.WriteLine("Выполняю действие!");

            // Пример цикла while
            // int count = 0; // Переменная для счетчика.
            // while (true) // Пока тут истина, цикл будет выполняться бесконечно. Стандартно тут true, то есть будет бесконечный цикл.
            // {
            //    count++; 
            //    Console.WriteLine(count); 
            // }

            int count = 0; // Переменная для счетчика.
            while (count < 5) // Теперь будет проверяться переменная count. Если она меньше 5, то будет true и код выполнится. 
                              // Когда переменная достигнет значения 5, итерация цикла завершится и мы не будем заходить в блок кода (цикла).
            {
                count++; // Переменная увеличивается на 1.
                Console.WriteLine(count); // Вывод в консоль.
            }

            // Теперь с вводом нужного количества повторений пользователем.
            int count_2 = 0;
            int limit = int.Parse(Console.ReadLine()); // Переменная, которую будет инициализировать пользователь в консоли.
            while (count_2 < limit) // Проверка. Пока переменная count меньше значения, введенного пользователем, выполнять условие цикла.
            {
                count++; // Переменная увеличивается на 1.
                Console.WriteLine(count); // Вывод в консоль.
            }
        }
    }
}
