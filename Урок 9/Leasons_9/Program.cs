using System;
using System.Collections.Generic; // dynamic lib created array

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Урок 9 – Цикл «foreach» для работы с массивами. Generics.
            // foreach method d-array
            /*{
                short[,] nums = {
                    { 1,2, 3, 4},
                    { 5,6,7, 8},
                    { 8,9,10,11},
                };

                foreach (var el in nums)
                    Console.WriteLine($"El: {el}");

            } */   

            // dynamic array                 
            /*{
                List<int> numbers = new List<int>(){
                    4,5, 6, 7
                };

                numbers.Add(40);
                numbers.Add(222);
                numbers.Add(400);

                foreach (var el in numbers){
                    Console.WriteLine("El: " + el);
                }
                
            }*/ 
            Console.ReadKey();
        }
    }
}
