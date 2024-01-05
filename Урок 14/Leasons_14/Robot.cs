using System;

namespace Leasons_14{
    /*Класс Robot с полями*/
    class Robot{
        private string name; // Поле класса
        private int weight;  
        private byte[] coordinates;
        

        /* Инкапсуляция. Так как мы не имеем доступа к полям в Main то нам нужно как то 
            инициализировать приватные поля класа
        */
        public void setValues(string _name, int _weight, byte[] _coordinates){
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
        }
        
        // Метод вывода
        public void printValues(){
            System.Console.WriteLine(name + "weight" + weight);
            foreach (byte el in coordinates)
                System.Console.WriteLine(el);
        }
    }

    // !! поле == переменная (поле в классе а в main переменная)
    /* Типы доступа ООП (популярны):
       public - Доступ везде и отовсюда.
       private - Доступ исключительно внутри класса в котором был создан.
       protected - Поле будет доступно в родительском классе и в наследнике.
       */
}