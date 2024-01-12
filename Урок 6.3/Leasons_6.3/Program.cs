using System;
// Цикл «for». Реверс. Особенности цикла for
namespace Leasons_6._3;

class Program
{
    static void Main(string[] args)
    {
        // Наш цикл как сделать так что бы числа выводились в обратном порядке?
        //int limit = int.Parse(Console.ReadLine());
        //for (int i = 0; i < limit; i++) // Данные секции не обязательны(менять можно как 2 секции оставить, так и 1 так и 0) но есть ограничения.
        //    Console.WriteLine(i);
        Console.WriteLine("Ниже бесконечный цикл который прерываеться за счёт breack");
        for (; ; ) // Это бесконечный цикл и будет бесконечный вывод.
        {
            Console.WriteLine("for is working");
            // Замедлим поток. (демонстрация)
            System.Threading.Thread.Sleep(300); //  Приостановка потоков на 300мс каждую итерацию.
            // Для того что бы прервать наш цикл напишем ключевое слово breack.
            break;
        }

        Console.WriteLine("Ниже циклы с работающие в паре");
        // Первый цикл отработает определенное кол-во раз а второй продолжит.

        int i = 0; // Переменная что бы оба цикла видели переменную.
        for (; i < 3; i++)
            Console.WriteLine($"For_1: {i}"); // Выведет 0,1,2 элемент

        for (; i < 5; i++)
            Console.WriteLine($"For_2: {i}"); // Выведет 3, 4 элемент

        Console.WriteLine("Ниже циклы с инкрементой внутри");
        // Если инкременту/декременту не вписать не в тело цикла не в секцию то будет бесконечный цикл.
        for (int j = 0; j < 5;)
        {
            j++;
            Console.WriteLine(j); // Вывод 1 2 3 4 5
        }

        for (int j = 0; j < 5;)
        {
            
            Console.WriteLine(j); // Вывод 0 1 2 3 4 
            j++;
        }

        Console.WriteLine("Ниже цикл с несколькими переменнами.");
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

        for (int j = 5; j > 0; j--) // Для вывода в обратном порядкне используем декременту и меняем условие.
        {
            Console.WriteLine(j);
        }
        // Через ввод с консоли
        // Если нужно ограничить переменную в цикле синтаксис такой `for (int l = int.Parse(Console.ReadLine()); j >= 5; j--)`
        Console.WriteLine("Ведите число.");
        int l = int.Parse(Console.ReadLine());
        for (;l >= 0; l--) 
        {
            Console.WriteLine(l);
        }
        Console.WriteLine("Ниже цикл for в обратном и обычном порядке.");

        // Вывод в обратном порядке и в обычном порядке
        for (int j = 0, k=5; j < 5; j++, k--)
        {
            Console.WriteLine($"j: {j}");
            Console.WriteLine($"k: {k}");
        }
    }
}
