using System;

// Оператор выбора «switch» и оператор прерывания «break»

/*
 * Оператор switch предназначен для выполнения таких же задач, как и if else, но делает это немного по-другому.
 */

namespace Lessons_5._2
{

    class Program
    {
        static void Main(string[] args)
        {
            // Пример
            int a = int.Parse(Console.ReadLine());
            switch (a) // Передаем значение, на основании которого будет выполняться один из `n` блоков кода.
            {
                case 1: // В случае, если в переменной a будет 1 
                    Console.WriteLine("Вы ввели 1");
                    break;
                case 2:
                    {
                        Console.WriteLine("Вы ввели 2");
                        Console.WriteLine("Как дела?");
                    }
                    break;
                default: // Обработка, если нет подходящего switch'a, например, case 3.
                    Console.WriteLine("У меня нет инструкции, что делать с таким значением.");
                    break;
            }

            switch (a) // Передаем значение, на основании которого будет выполняться один из `n` блоков кода.
            {
                case 1: // Теперь будет выполняться case 1 и после case 2.
                case 2:
                    {
                        Console.WriteLine("Вы ввели 1 или 2");
                    }
                    break;
                default: // Обработка, если нет подходящего switch'a, например, case 3.
                    Console.WriteLine("У меня нет инструкции, что делать с таким значением.");
                    break;
            }

            // Работа со строкой

            string b = Console.ReadLine();
            switch (b) // Передаем значение, на основании которого будет выполняться один из `n` блоков кода.
            {
                case "+":
                    Console.WriteLine("Вы ввели плюс");
                    break;
                case "-":
                    Console.WriteLine("Вы ввели минус");
                    break;
                default:
                    Console.WriteLine("У меня нет инструкции, что делать с таким символом.");
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
                    Console.WriteLine("Вы нажали неизвестную клавишу на клавиатуре. Попробуйте ESC или Enter.");
                    break;

            }
        }
    }
}
