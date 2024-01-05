using System;

// Создам структуру книги.
namespace Leasons_25
{
    struct Book{
        private string title, avtor, intro;
        private short pages;

        // Создадим метод.
        // Так как у нас есть метод для установки полей сделаем инкапсуляцию так как это важная концепция и она так же используеться в структурах.
        public void setValues(string title, string avtor)
        {
            this.title = title;
            this.avtor = avtor;
        }

        public void printValues()
        {
            Console.WriteLine(this.avtor + " написал книгу " + this.title);
        }
        // Перейдем в Main
    }
}
