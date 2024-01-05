using System;
using System.IO; // Библиотека для работы с файлами
// Работа с файлами и строками
namespace Leasons_11{

    class Program
    {
        static void Main(string[] args)
        {
            // Строки
            {
            // string word = "Hello";
            // word += "!"; // Добавление одного символа в строку. (1-й метод)
            // Строка (string) - масив char - char = ['H', 'e', 'l', 'l', 'o']; 
            // Как и с масивом мы можем обратиться по индексу

            // Console.WriteLine(word.Length); // Подсчет количества символов в строке
            //word = String.Concat(word, "!!"); // Добавление еще 2-х символов в строку. (2-й метод)
            // Console.WriteLine(word); 

            // Console.WriteLine(String.Compare(word, "Hello")); // Сравмнение строк


            // Методы соединения и разделения строк.
            
            // string people = "Alex,Bob,Josh";
            // string[] names = people.Split(new char[]{','}); // Разделить имена по символу запятая.
            // foreach (string el in names)
            //     System.Console.WriteLine(el);

            // string people = "Alex,Bob,Josh";
            // string[] names = people.Split(new char[]{','});
            // people = String.Join(" ", names); // Обединить через пробел.
            // System.Console.WriteLine(people);        

            // string word = "             Hello";
            // word += "!";
            // System.Console.WriteLine(word.Trim()); // Функция для вывода без пробелов.
            // System.Console.WriteLine(word);


            // System.Console.WriteLine(word.Substring(2)); // Удалить 2 первых элемента
            // System.Console.WriteLine(word.Substring(1, 2)); // Удалить 1 первый элемент и 2 последних
            // System.Console.WriteLine(word.Substring(1, word.Length -2)); // Удалить 1 первый элемент и 1 последний (Вся длина)
            }

            
            // Работа с файлами
            {
                // ! using() для того что бы создать изолированый код.
                // ! FileMode.OpenOrCreate - открыть файл но если его нету то создать его.
                Console.WriteLine("Введите текст: ");
                string text = Console.ReadLine();

                using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)){
                    byte[] array = System.Text.Encoding.Default.GetBytes(text); // !! Преобразование текста в байты 
                                                                                // для того что бы его вписать в файлы 
                    stream.Write(array, 0, array.Length); // Записать в файл текст без отсутупов {0} и записать до конца.
                                                                                        // Всю длину array.Length.
                }


                // ! Считаем текст из файла и вывод  в консоль
                using (FileStream stream1 = File.OpenRead("info.txt")){
                    byte[] array = new byte[stream1.Length]; // Все байты в масив.
                    stream1.Read(array, 0, array.Length); // Считываем все из файла.

                    string textFromFile = System.Text.Encoding.Default.GetString(array); // Преобразовуем байты в строку
                    Console.WriteLine(textFromFile);
                }
            }

            Console.ReadLine();

        }
    }
}
