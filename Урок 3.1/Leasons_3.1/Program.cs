using System;
using System.Globalization; // Библиотека для региональных настроек.
// Преобразование строки. Parse

namespace Leasons_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создам переменую
            string str = "7"; // Это символ но не число.
            // Метод Parse
            int variable  = int.Parse(str); // Конвертирование нашей строки в целочисленное ччисло.
            Console.WriteLine(variable);

            // Создам переменную и распарсим в дробное число.
            string stt_1 = "1.9";

            // При парсинге и выводе будет ошибка так как я разделяю число '.' дабы избежать нам нужно 
            // указать какой тип разделителя мы будем использовать. Данная ошибка зависит от региональных настроек.

            NumberFormatInfo numberFormat = new NumberFormatInfo();
            {
                numberFormat.NumberDecimalSeparator = "."; // Теперь разделение будет через точку.
            }

            double variabhle_1 = double.Parse(stt_1, numberFormat); // Передадим наши региональные изменения.
            Console.WriteLine(variabhle_1); 
        }
    }
}
