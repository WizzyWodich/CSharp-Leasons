using System;
// Цикл «for»
// Если мы будем использовать счетчик, то for это хороший выбор или альтернатива работы с массивом.
// И в отличие от while начинается вывод с 0, а в while с 1.

// И еще раз, если код в (for, foreach, if, else, else if, switch) состоит из одной строки, то {} можно не писать.
namespace Lessons_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример
            // for(<Объявляется и инициализируется переменная(один раз)>; <Проверка>; <Инкремент>)
            for (int i = 0; i < 10; i++) // Условие.
                Console.WriteLine(i); // Вывести нашу переменную i, которая была объявлена и инициализирована как счетчик внутри условия for.

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

            // Почему бы не использовать while? Все просто в `for` переменная `i` используется в его пространстве видимости. В то время как в while я могу 
            // обратиться к данной переменной вне цикла и изменить ее, и тогда будут ошибки.
        }
    }
}
