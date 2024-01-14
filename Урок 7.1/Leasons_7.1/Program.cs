using System;
// Ключевое слово «continue»

// Ключевое слово continue пременяеться походжим образом как и  break.
namespace Leasons_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) // Цикл который будет выполнять итерацию 5 раз
            {
                // continue позволяет прерывать цикл но не выходить из него допустим нам нужно прервать
                // итерацию цикла когда i = 2 но после продолжить и не выходить из цикла.
                if(i == 2)
                {
                    continue; // Пропускаем вывод 2 
                }
                    
                Console.WriteLine(i); // Вывод 0 1 3 4
            }
        }
    }
}


