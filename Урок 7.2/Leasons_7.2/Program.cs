using System;
// Тернарный опеиратор
/*
 * Тернарный совершает операции над тремя операторами.
 */
namespace Leasons_7._2
{


    class Program
    {
        static void Main(string[] args)
        {
            // Есть бинарный и унарный
            int a = 0;
            int b = 0;

            int result;

            a++ // ++ Это унарный оператор который производит действие над одним оператором.

            a + b; // + Это бинарный операторт так как работает над 2-я операторами.
            // Тернарный оператор
            // <Операнд условия> ? <Операнд if_true> : <Операнд if_false>
            // Логика тернарного оператора делает все то что и конструкция if else но более компактный код.
            // Пример if else с вводом и проверкой пароля и выводом true false
            bool accessAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            //if(enteredPassword == storedPassword)
            //    accessAllowed = true;
            //else
            //    accessAllowed = false;

            // Тернарный оператор повторит такую конструкцию.
            // <Операнд условия> ? <Операнд if> : <Операнд else>
            accessAllowed = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(accessAllowed);

            // Пример 2 

            int inputData = int.Parse(Console.ReadLine());

            int outputData = inputData < 0 ? 0 : inputData; // Если переменная inputData < 0 - True иначе мы присвоим 0 иначе мы присвоим
                                                            // в outputData значение inputData.

            Console.WriteLine();
            // Обычно когда нету огромной логики спользуют.
        }
    }
}

