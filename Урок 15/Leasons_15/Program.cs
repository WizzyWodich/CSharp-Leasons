﻿using System;
// Конструкторы классов. Модификатор static

namespace Leasons_15{

    class Program
    {
        static void Main(string[] args)
        {
            Robot bot = new Robot("Bot", 900, new byte[] {12,12,12}); // Принимает 3 аргумента. Конструктор 
            bot.printValues(); 
            // Теперь если мы запустим будет ошибка т-к наш kiler тоже ожидает 3 аргумента но если я не хочу а хочу через функцию setValues? 
            // То тогда нам нужно написать еще один конструктор
            // Теперь когда я создал еще один конструктор он же конструктор по умолчанию 
            // Теперь при создании объекта bot автоматически будет подбираться написаный мной конструктор.

            Robot kiler = new Robot(); // 2-й написаный конструктор.
            kiler.setValues("Kirler", 230, new byte[] {1,54,0});
            kiler.printValues();

            // Создадим еще один конструктор который будет принимать в себя только один аргумент и спразу его инициализировать без вызова нашей доп.метода
            // Смотрим наш Robot.cs

            Robot bot_1 = new Robot("Kirysha"); // Использование нашего 3-го конструктора который принимает один аргумент.



            // Теперь про модификатор static
            // Если мы прописываем мод-фикатор доступа static(к полю или к методу) то в таком случаее даный метод/поле будет принадлежать к классу в целом а не к объектам.
            // Переходим в Robot.cs

            // Теперь когда создано статическое поле то к нему можно обратиться напрямую.
            // Robot.count = 5; // Наше статическое поле.
            // Пример
            // Math.PI; // Мы можем обратиться к числу PI т-как метод статический.
            // Созадим метод идем в файл Robot.cs
            
            Robot.Print(); // Вызываем наш статический метод

            // И да если наш статический метод поле будут с мод-доступа private то мы не сможем обратиться/вызвать его.
            // Значение статического поля сохраняеться при создании нового объекта 


            // Практическая часть 
            // Подсчитаем сколько было создано объектов на основе класса.
            // Теперь в файле Robot.cs в каждый конструктор добавим строчку count++; и изменим наш статический метод Print()
            // И сделаем наше поле private т-к пусть она считает а выводим мы через публичный метод все равно
            // Вывод 3 т-как создаються 3 объекта класа Robot

            Console.ReadLine();
        }
    }
}
