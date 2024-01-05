using System;
using System.Runtime.Versioning;

// Обработчик ощибок try catch

namespace Leasons_12{

    class Program
    {
        static void Main(string[] args)
        {
            // Для удобства я обернул в бессконечный цикл.

            // while(true){
            //     try {
            //         int num = Convert.ToInt32(Console.ReadLine());
            //         System.Console.WriteLine(num); // Блок try отвечает за то что выполняеться.
            //     } catch(FormatException){
            //         System.Console.WriteLine("Вы ввели не тот формат."); // Блок catch принимает в качестве аргументов 
            //                                                             // название ошибки которую мы будем ловить.
            //     }
            // }
        
            // Обработка нескольких ощибок.
            //while (true){
            //     try{
            //         int a = 5, b = 0, ress;
            //         System.Console.WriteLine("Введите первое число: ");
            //         a = Convert.ToInt32(Console.ReadLine());
            //         System.Console.WriteLine("Введите второе число: ");
            //         b = Convert.ToInt32(Console.ReadLine());
            //         ress = a / b;
            //     } catch (DivideByZeroException){
            //         System.Console.WriteLine("Деление на 0!"); // Обрабатывает если одно из чисел бедет 0
            //     } catch (FormatException){
            //         System.Console.WriteLine("Вы ввели не тот формат."); // Обрабатывает если 
            //                                                             // введеный текст не соотвецтвует типу переменной.
            //     } finally {
            //         /* Данный блок будет срабатывать при  любом раскладе. Пример если работа с файлом или БД то ее 
            //         * закрытие придеться писать и в try и в catch но лутше такое написать в finally дабы не усложнять код.*/
            //     }
            //  }

            Console.ReadLine();
            
        }
    }
}
