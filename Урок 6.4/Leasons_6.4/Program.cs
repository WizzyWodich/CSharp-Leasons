using System;
// Цикл «for». Реверс. Особенности цикла for
namespace Lessons_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Наш цикл, как сделать так, чтобы числа выводились в обратном порядке?
            //int limit = int.Parse(Console.ReadLine());
            //for (int i = 0; i < limit; i++) // Данные секции не обязательны (менять можно как 2 секции оставить, так и 1, так и 0), но есть ограничения.
            //    Console.WriteLine(i);
            Console.WriteLine("Ниже бесконечный цикл, который прерывается за счет break");
            for (; ; ) // Это бесконечный цикл и будет бесконечный вывод.
            {
                Console.WriteLine("for is working");
                // Замедлим поток. (демонстрация)
                System.Threading.Thread.Sleep(300); //  Приостановка потоков на 300 мс каждую итерацию.
                // Для того чтобы прервать наш цикл, напишем ключевое слово break.
                break;
            }

            Console.WriteLine("Ниже циклы, работающие в паре");
            // Первый цикл отработает определенное количество раз, а второй продолжит.

            int i = 0; // Переменная, чтобы оба цикла видели переменную.
            for (; i < 3; i++)
                Console.WriteLine($"For_1: {i}"); // Выведет 0, 1, 2 элементы

            for (; i < 5; i++)
                Console.WriteLine($"For_2: {i}"); // Выведет 3, 4 элементы

            Console.WriteLine("Ниже циклы с инкрементой внутри");
            // Если инкремент/декремент не вписать ни в тело цикла, ни в секцию, то будет бесконечный цикл.
            for (int j = 0; j < 5;)
            {
                j++;
                Console.WriteLine(j); // Вывод 1, 2, 3, 4, 5
            }

            for (int j = 0; j < 5;)
            {

                Console.WriteLine(j); // Вывод 0, 1, 2, 3, 4 
                j++;
            }

            Console.WriteLine("Ниже цикл с несколькими переменными.");
            // Цикл с несколькими переменными.
            for (int k = 0, j = 5; k < 10; k++, j++)
            {
                Console.WriteLine($"k {k}");
                Console.WriteLine($"j {j}");
            }
            Console.WriteLine("Ниже цикл с несколькими условиями.");

            // Цикл с несколькими условиями.
            // Добавлю условное логическое И
            for (int k = 0, j = 5; k < 10 && j < 12; k++, j++)
            {
                Console.WriteLine($"k {k}");
                Console.WriteLine($"j {j}");
            }
            Console.WriteLine("Ниже цикл for в обратном порядке.");
            // Реверс (for в обратном порядке)

            for (int j = 5; j > 0; j--) // Для вывода в обратном порядке используем декремент и меняем условие.
            {
                Console.WriteLine(j);
            }
            // Через ввод с консоли
            // Если нужно ограничить переменную в цикле, синтаксис такой `for (int l = int.Parse(Console.ReadLine()); j >= 5; j--)`
            Console.WriteLine("Введите число.");
            int l = int.Parse(Console.ReadLine());
            for (; l >= 0; l--)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("Ниже цикл for в обратном и обычном порядке.");

            // Вывод в обратном и обычном порядке
            for (int j = 0, k = 5; j < 5; j++, k--)
            {
                Console.WriteLine($"j: {j}");
                Console.WriteLine($"k: {k}");
            }
        }
    }
}
