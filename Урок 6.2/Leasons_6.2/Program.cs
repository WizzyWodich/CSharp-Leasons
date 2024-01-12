using System;
// Цикл «for»
// Если мы будем использовать счетчик то for это хороший выбор или альтернатива работы с масивом.
// И в отличии от while начинаеться вывод с 0 а в while с 1.

// И еще раз если код в (for, foreach, if, else, else if, switch) состоить из одной строки то  {} можно не писать.
namespace Leasons_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример
            // for(<Объявляеться и инициалируеться переменная(один раз)>; <Проверка>; <Инкремента>)
            for (int i = 0; i < 10; i++) // Условие.
                Console.WriteLine(i); // Вывести нашу переменную i которая была объявлена и инициализирована как счетчик внутри условия for

            // Ввод с консоли
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) 
                Console.WriteLine(i); 

            // Как это выглядит в while
            int limit_2 = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < limit)
            {
                Console.WriteLine(i);
                i++;
            }

            // Почему бы не использовать while? Все просто в `for` `i` используеться в его прострастве видимости. В то время как в while я могу 
            // Обратиться к данной переменной вне цикла и изменить ее и тогда будут ошибки.
        }
    }
}


