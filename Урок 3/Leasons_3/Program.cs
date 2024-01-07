using System;
// Конвектирование типов данных
namespace Leasons_3
{

    class Program
    {
        static void Main(string[] args)
        {
            // Объявим пару переменых.
            string name;
            int age;
            decimal salary;

            // Так как в С# все представленно в виде строк появляеться вопрос как ввести возраст и зарплату в их переменные с типами int и decimal?
            // Для этого нам предеться конвертировать string в int, decimal или другие типы данных (float double ...)
            // И в C# есть метод конвертирования:
            // <Convert.><Тип данных .NET>();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите размер зарплаты: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            // Выведу в консоль 
            // Обявлю еще одну переменую.
            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Имя: {name}  Возраст: {age} Рост: {height} Зарплата: {salary}");
        }
    }
}