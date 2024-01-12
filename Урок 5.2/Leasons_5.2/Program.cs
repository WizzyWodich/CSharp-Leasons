using System;
// Оператор выбора «switch» и оператор прерывания «break»

/*
 * Оператор swith предназначен для выполнения таких же задач как и if else но делает это немного по другому.
 */

namespace Leasons_5._2
{

    class Program
    {
        static void Main(string[] args)
        {
            // Пример
            int a = int.Parse(Console.ReadLine());
            switch(a) // Передаем значении на основании которого будет выполняться один из `n` блоков кода.
            {
                case 1: // В сллучае если в переменной а будет 1 
                    Console.WriteLine("Вы ввели 1");
                    break;
                case 2:
                    {
                        Console.WriteLine("Вы ввели 2");
                        Console.WriteLine("Как дела?");
                    }
                    break;
                default: // Обработка если нету подходящего свича допустим case 3 нету и если ввести 3 то будет выполняться данный код.
                    Console.WriteLine("У меня нету инструкции что делать с таким значением.");
                    break;
            }



            switch (a) // Передаем значении на основании которого будет выполняться один из `n` блоков кода.
            {
                case 1: // Теперь будет выполняться case 1 и после case 2
                case 2:
                    {
                        Console.WriteLine("Вы ввели 1 или 2");
                    }
                    break;
                default: // Обработка если нету подходящего свича допустим case 3 нету и если ввести 3 то будет выполняться данный код.
                    Console.WriteLine("У меня нету инструкции что делать с таким значением.");
                    break;
            }

            // Работа с string

            string b = Console.ReadLine();
            switch (b) // Передаем значении на основании которого будет выполняться один из `n` блоков кода.
            {
                case "+": 
                    Console.WriteLine("Вы ввели плюс");
                    break;
                case "-":
                     Console.WriteLine("Вы ввели минус");
                    break;
                default: 
                    Console.WriteLine("У меня нету инструкции что делать с таким символом.");
                    break;
            }
            // Логика нажатия на клавижу
            ConsoleKey consoleKey = Console.ReadKey().Key; 
            switch (consoleKey)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Вы нажали Enter");
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("Вы нажали ESC");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную для меня клавишу наклавиатуры попробуйте ESC и ENTER");

            }
        }
    }
}

