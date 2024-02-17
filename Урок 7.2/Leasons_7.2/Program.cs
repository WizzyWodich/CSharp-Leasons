using System;
// Тернарный оператор
/*
 * Тернарный оператор выполняет операции над тремя операндами.
 */
namespace Lessons_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Есть унарные, бинарные и тернарные операторы
            int a = 0;
            int b = 0;

            int result;

            a++; // ++ Это унарный оператор, который производит действие над одним операндом.

            a + b; // + Это бинарный оператор, так как работает над двумя операндами.

            // Тернарный оператор
            // <Условный операнд> ? <Операнд_если_истина> : <Операнд_если_ложь>
            // Логика тернарного оператора аналогична конструкции if-else, но код более компактный.

            // Пример конструкции if-else с проверкой пароля и выводом true/false
            bool accessAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();

            //if(enteredPassword == storedPassword)
            //    accessAllowed = true;
            //else
            //    accessAllowed = false;

            // Тернарный оператор повторяет такую конструкцию.
            // <Условный операнд> ? <Операнд если истина> : <Операнд если ложь>
            accessAllowed = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(accessAllowed);

            // Пример 2 
            int inputData = int.Parse(Console.ReadLine());

            int outputData = inputData < 0 ? 0 : inputData; // Если переменная inputData < 0 - True, присваиваем 0, иначе присваиваем значение inputData.
            Console.WriteLine(outputData);
            // Обычно используют, когда логика не слишком сложная.
        }
    }
}
