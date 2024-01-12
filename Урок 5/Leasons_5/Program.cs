using System;

// «if» «else» «else if». Конструкция логического выбора

/*
 *  if (Утверждение наше условие 1) // Сюда всегда принимаеться bool переменная.
 *  {
 *      Действие 1
 *  }
 *  else if (Условие 2)
 *  {
 *      Если первое условие не подходит то выполняем данный код.
 *  }
 *  else // Если не подходит нечего выполянем это.
 *  {
 *      Действие 2
 *  }
 *  
 */

namespace Leasons_5
{
    class Program
    {
        // Cделаю уведомление если user болен.
        static void Main(string[] args)
        {
            // Создам переменную и логику if else.
            bool isInfected = true;

            if (isInfected) // Проверяем на истиность. / Пока наша переменная будет true будет выводиться надпись.
            {
                Console.WriteLine("Вы заражены.");
            }
            else
            {
                Console.WriteLine("Вы здоровы."); // Выполниться при условии bool isInfected = false;
            }


            // Операции сравнения в if else.

            int a;
            a = int.Parse(Console.ReadLine());
            if( a == 10) {
                Console.WriteLine("Переменная равна 10");
            }
            else
            {
                Console.WriteLine("Переменная не равна 10");
            }

            // Проверить число на четность.
            int b;
            b = int.Parse(Console.ReadLine());
            if (b%2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
        }
    }
}

