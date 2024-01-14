using System;
// Вложеные циклы  / Часть 1
// Используются для переборки двумерного и более масива так как это удобно, используются для работы с данными 
// которые находяться в структуре где объект содержит объекты в себе и каждый подобъект содержит список. 

namespace Leasons_6._4;

class Program
{
    static void Main(string[] args)
    {
        // Пример вложенного цикла
        //while (true)
        //{
        //    for (int i = 0; i < length; i++)
        //    {
        //        for (int j = 0; j < length; j++)
        //        {
        //            do
        //            {

        //            }while()
        //        }
        //    }
        //}


        for (int i = 1; i <= 3; i++) // i выполняется до 3 
        {
            Console.WriteLine($"Цикл 1 итерация: {i}");
            for (int j = 1; j <= 5; j++) // j должна выполняется до 5. НО этот цикл находится внутри цикла где i
                                         // выполнится до 3 в таком случаее цикл с j выполнится 15 раз 3 раза по 5 
            {
                Console.WriteLine($"\tЦикл 2 итерация: {j}");
                for (int k = 0; k <= 2; k++) // Выполниться 12 раз 
                {
                    Console.WriteLine($"\t\tЦикл 3 итерация: {j}");
                }
            }
        }

        // Програма которая будет рисовать квадрат
        Console.Write("Введите высоту: ");
        int height = int.Parse(Console.ReadLine()); // Высота
        Console.Write("Введите ширину: ");
        int width = int.Parse(Console.ReadLine()); // Ширина

        for (int i = 0; i < height; i++)
        {
            for(int j = 0; j <= width; j++) 
            {
                Console.Write("#");
            }
            Console.WriteLine(); // \n
        }



    }
}
