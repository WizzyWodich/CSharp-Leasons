using System;
using System.Globalization; // Библиотека для региональных настроек.

// Преобразование строки. Parse

namespace Lessons_3._1 // Исправлено на "Lessons" вместо "Leasons"
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создадим переменную
            string str = "7"; // Это символ, а не число.

            // Метод Parse
            int variable = int.Parse(str); // Конвертирование нашей строки в целочисленное число.
            Console.WriteLine(variable);

            // Создадим переменную и распарсим в дробное число.
            string stt_1 = "1.9";

            // При парсинге и выводе будет ошибка, так как я разделяю число '.'. Чтобы избежать этой ошибки,
            // нужно указать, какой тип разделителя мы будем использовать. Данная ошибка зависит от региональных настроек.

            NumberFormatInfo numberFormat = new NumberFormatInfo();
            numberFormat.NumberDecimalSeparator = "."; // Теперь разделение будет через точку.

            double variable_1 = double.Parse(stt_1, numberFormat); // Передадим наши региональные изменения.
            Console.WriteLine(variable_1);
        }
    }
}
