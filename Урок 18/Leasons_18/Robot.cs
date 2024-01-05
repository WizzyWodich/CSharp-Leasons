using System;

namespace Leasons_18{
    /*Класс Robot с полями конструкторами и методами а так же статический метод  а так же аксессоры*/
    class Robot{

        private static int count;
        private string name; // Поле класса
        private int weight;  
        private byte[] coordinates;

        // Модификатор доступа protected - доступен в класее родителя (где был создан) а так же в классе наследника.
        // В Main мы не можем обратиться к данному полю через объект но мы спокойно можем обратиться через наш класс наследник.
        // Переходим в Killer.cs
        protected string  sName;



        // Аксессоры "get" "set"
        public int Weight{
            get{
                System.Console.WriteLine("Результат: ");
                return this.weight;  
            }
            set{
                if(value < 1) 
                    this.weight = 1;
                else if(value > 5000) 
                    this.weight = 5000;
                else 
                    this.weight = value; 
            }
        }

        public int Width { get; set; }
        

        // Конструкторы:
        public Robot(string name, int weight, byte[] coordinates)
        {
            System.Console.WriteLine("Object created"); 
            this.setValues(name, weight, coordinates); 
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

        // Инкапусуляция и методы:
        public void setValues(string name, int weight, byte[] coordinates){
            this.name = name; 
            this.weight = weight;
            this.coordinates = coordinates;
        }
        
        public void printValues(){
            System.Console.WriteLine(this.name + "weight" + this.weight);
            foreach (byte el in coordinates)
                System.Console.WriteLine(el);
        }

        // Статический метод:
        public static void Print(){
            System.Console.WriteLine("Count is: " + count);
        }
        
        /* Наследование это еще один класс кроотрый унаследует все от классса родителя(все конструкторы методы поля и аксессоры и т.д)
         и он так же может иметь дополнительные поля конструкторы аксессоры методы и т.д

          Допустим у нас есть объект Killer в Main и скорее всего он должен стрелять но в нашем классе Robot (основной класс) нету такой функции да мы можем 
          реализовать данную функцию но тогда все роботы могли бы стрелять но мне нужно что бы Kiler был как бы основан на базе класса робот но был бы как 
          отдельной моделью с функцией стрельба и что бы не переписывать основной класс по многу раз для этого лутше всего использовать наследование.

          Реализую такое:
          Создаю новый файл в папке нашего проэкта и назову его Killer.cs
          Переходим в данный файл. 
        */
        


    }
}