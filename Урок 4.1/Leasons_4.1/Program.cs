using System;
// Приоритет в арифметических операциях

namespace Leasons_4_1 
{
    class Program
    {
        // Приоритет как и в обычной математике.
        static void Main(string[] args)
        {
            int result = 3 + 6 / 2; // Вывод 6 (3 + (6 / 2))
            Console.WriteLine(result);

            int result2 = (3 + 6) / 2; 
            Console.WriteLine(result2); // Результат 4, так как произошло округление.

            double result3 = (3 + 6) / 2d;
            Console.WriteLine(result3); // Результат 4.5

            Console.ReadLine(); // Чтобы консоль не закрылась.
        }
    }
}
