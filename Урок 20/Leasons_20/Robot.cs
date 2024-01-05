using System;

namespace Leasons_20{
    /*Класс Robot с полями конструкторами и методами а так же статический метод  а так же аксессоры*/
    class Robot{

        private static int count;
        private string name; // Поле класса
        private int weight;  
        private byte[] coordinates;
        protected string  sName;


        public string Name { get {
            return name;
        } 
        private set {}} // Мы сможем получить данные (возврат name) но устоновить нет. 


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
        
        
        // И так для того что бы он был виртуальным надо выдать модификатор доступа 'virtual'
        // Теперь мы можем переписать функционал в нашем классе наследнике 
        // Переходим Killer.cs
        public virtual void printValues(){
            System.Console.WriteLine(this.name + " weight " + this.weight);
            foreach (byte el in coordinates)
                System.Console.WriteLine(el);
        }

        // Статический метод:
        public static void Print(){
            System.Console.WriteLine("Count is: " + count);
        }
        
        


    }
}