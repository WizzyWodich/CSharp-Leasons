using System;

// «if» «else» «else if». Конструкция логического выбора

/*
 *  if (Утверждение наше условие 1) // Сюда всегда принимается переменная типа bool.
 *  {
 *      Действие 1
 *  }
 *  else if (Условие 2)
 *  {
 *      Если первое условие не подходит, то выполняется данный код.
 *  }
 *  else // Если ни одно из условий не подходит.
 *  {
 *      Действие 2
 *  }
 *  
 */

namespace Leasons_5
{
    class Program
    {
        // Cделаем уведомление, если пользователь болен.
        static void Main(string[] args)
        {
            // Создадим переменную и логику if else.
            bool isInfected = true;

            if (isInfected) // Проверяем на истинность. / Пока наша переменная будет true, будет выводиться надпись.
            {
                Console.WriteLine("Вы заражены.");
            }
            else
            {
                Console.WriteLine("Вы здоровы."); // Выполнится при условии bool isInfected = false;
            }


            // Операции сравнения в if else.

            int a;
            Console.WriteLine("Введите число a: ");
            a = int.Parse(Console.ReadLine());
            if (a == 10)
            {
                Console.WriteLine("Переменная равна 10.");
            }
            else
            {
                Console.WriteLine("Переменная не равна 10.");
            }

            // Проверить число на четность.
            int b;
            Console.WriteLine("Введите число b: ");
            b = int.Parse(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число нечетное.");
            }
        }
    }
}
