using System;

namespace Leasons_16{
    /*Класс Robot с полями конструкторами и методами а так же статический метод*/
    class Robot{

        private static int count;
        

        
        private string name; // Поле класса
        private int weight;  
        private byte[] coordinates;



        /* Так же с помощью this мы можем обращяться к методам класса
        При написании кода лучше всего явно обращяться к методам то есть через 'this'
        
        Перепишу файл под использование 'this'
        */


        public Robot(string name, int weight, byte[] coordinates)
        {
            System.Console.WriteLine("Object created"); 
            this.setValues(name, weight, coordinates); // даный конструктор можно было не переписывать под использование 'this' так как тут я просто передаю параметры и нету обращения к полям.
            count++; 
        }

        
        public Robot() {
            count++; // Подсчет методов 
        } 
       
        public Robot(string name)
        {
            this.name = name; 
            count++; 
        }

        /* Допустим я ъочу что бы название параметров которые метод будет принимать были такие же как и название полей нашего класса Robot 
        И если я изменю название аргументов допустим '_name -> name' тогда 'name = name' будет ощибка т-как програма не знает что к чему я пытаюсь присвоить есть два варианта исправление ошибки
        1. Изменение имени параметров (Но это не особо идекльно в прале написания кода)
        2. Использовать this
        Изменю я функцию
        */
        public void setValues(string name, int weight, byte[] coordinates){
            this.name = name; // Теперь логика такая 'this.name' здесь компилятор понимает что мы точно обращякемяся к полю класса Robot а  тут 'name;' к нашему параметру/парамертрам.
            this.weight = weight;
            this.coordinates = coordinates;
        }
        
        public void printValues(){
            System.Console.WriteLine(this.name + "weight" + this.weight);
            foreach (byte el in coordinates)
                System.Console.WriteLine(el);
        }


        // Что касаеться статических полей и использования 'this' поля или методы с таким доступом не позволяют использовать 'this' будет ошибка.
        // Причина такого что наше поле или метод принадлежит к классу в целом а обычные поля принадлежать к объектам.
        public static void Print(){
            System.Console.WriteLine("Count is: " + count);
        }
        
    }
}