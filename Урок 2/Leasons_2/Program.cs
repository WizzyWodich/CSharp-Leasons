using System;
// Консольный ввод-вывод
// Если пишем в Visual Studio или Visual Studio Code то можно написать cw и нажать TAB что бы быстро ввести Console.WriteLine()

namespace Leasons_2
{
    // Console.WriteLine - Консольный вывод. 
    // Console.Write - Работает так же как и Console.WriteLine только без добавления перехода на слудующую строку.
    // Console.ReadLine - Консольный ввод а точнее консольное считывание строки.
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим строковую переменную и инициализируем ее.
            string message = "Hello world";
            // Что бы вывести содержимое переменной используем:
            Console.WriteLine(message);
            // Но мы можем обходиться и без такого варианта в редких случаях.
            Console.WriteLine("Hello world");
            // Мы можем сделать объединение (и объединение с переменной)
            Console.WriteLine("Hello " + "world");
            Console.WriteLine("C# language " + message);
            // Работа с переменными объявлю и инициализирую пару переменных.
            string Human = "Bob", Human_2 = "Alex";
            /* Допустим я хочу вывести две переменых в одну строку. Есть два метода. */
            // Метод 1: Использовать интерполяцию строк для этого есть оператор $
            Console.WriteLine($"{Human} and {Human_2} learn a programming language С#");
            // Метод 2: Использовать плейсхолдеры {0}
            Console.WriteLine("{0} and {1} learn a programming language С#", Human, Human_2);

            Console.Write("{0} and {1} learn a programming language С#", Human, Human_2);

            // Консольный ввод или же консольное считывание.
            // Допустим ввод своего имени и вывод его в консоль.
            Console.WriteLine("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

        }
    }
}

