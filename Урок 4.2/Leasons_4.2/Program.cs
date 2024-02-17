using System;
// Операции сравнения. Операторы отношения

// Оператор отношения выполняет операции над какими либо операндами.
// Pезультатом будет истина или лож (true/fasle)
// Операторы:
/*
  == Равно
  != Не равно
  > Больше 
  < Меньше 
  >= Больше или равно 
  <= Меньше или равно
  
 */

namespace Leasons_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            Console.WriteLine(a == b); // Сравниваем на равенство. // Вывод False // Не истина
            // ...
            int a1 = 5;
            int b1 = 5;
            bool resul = a1 == b1; // Сперва мы присваем нашему resul значение переменной a1 
                                   // После проверяем. По умолчанию в resul false.

            Console.WriteLine(resul); // Вывод True // Истина

            Console.WriteLine(a != b); // Сравнение на не равенство // Результат True

            Console.WriteLine(a < b); // Если a > b тогда True

            Console.WriteLine(a > b); // Если a < b тогда False


            Console.WriteLine(a >= b); // Если a > или = b тогда True

            Console.WriteLine(a <= b); // Если a < или = b тогда True


        }
    }
}
