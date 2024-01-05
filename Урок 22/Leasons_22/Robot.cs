using System;

namespace Leasons_22{
    /* Абстрактный класс Robot с полями конструкторами и  абстрактными методами а так же статический метод  а так же аксессоры*/
    // Теперь пусть мой класс реализовывает интерфейс 'IRun'
    // Что бы такое указать нужно через : написать имя интерфейса.
    // Что бы вписать несколько интерфейсов используем запятую.
    // Но такого мало и внутри данного абстрактного метода нам надо реализовать все то что внутри самого интерфейса(поля методы аксессоры и т.п)
    abstract class Robot : IRun, IJump {

        private static int count;
        private string name; // Поле класса
        private int weight;  
        private byte[] coordinates;
        protected string  sName;


        // Аксессоры "get" "set"
        public string Name { 
            get {
                return name;
            } 
            private set {}
        } // Мы сможем получить данные (возврат name) но устоновить нет. 


        public int Weight{
            get{
                // System.Console.WriteLine("Результат: "); // Пока что не трубуеться.
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

        // Создаем акссесор для coordinates
        public byte[] Coordinates
        {
            get
            {
                return coordinates;
            }
            private set { }
        }  

        public int Width { get; set; }

        public float speed { get; set; } // Наш аксессор из интерфейса 'IRun'.
        public float y { get; set; }


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

        // Методы:
        // Инкапусуляция и методы:
        public void setValues(string name, int weight, byte[] coordinates){
            this.name = name; 
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public abstract void printValues(); 

        // Статический метод:
        public static void Print(){
            System.Console.WriteLine("Count is: " + count);
        }
        
        public void RobotRun() // Наш метод интерфейса IRun
        {
            Console.WriteLine("Robot is now running"); 
        }
        // Переходим в Run.cs

        public void Jump()
        {
            Console.WriteLine("Robot is jumping"); // Метод из интерфейса IJump
        }


    }
}