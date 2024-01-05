using System;

namespace Leasons_23{
    /* Абстрактный класс Robot дополненый интерфейсами с полями конструкторами и  абстрактными методами а так же статический метод  а так же аксессоры*/
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

        /* И тут у нас есть три конструктора с одинаковым названием только все они принимают разное количество параметров
         * Нечто похожее есть и у перегрузки функций
         * Перейдем в наш основной класс Main
         */
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

        // Методы и перегрузка методов:
        // Инкапусуляция и методы:

        // Тут мы так же выполнять перегрузку делая так же как и в Programs.cs сделаю перегрузку нашей функции setValues
        public void setValues(string name, int weight, byte[] coordinates){ // Метод с передачей трех параметров
            this.name = name; 
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void setValues(string name) // Метод с передачей одного параметра (name) (перегрузка)
        {
            this.name = name;
        }

        public void setValues(int weight) // Метод с передачей одного параметра(weight) (перегрузка)
        {
            this.name = name;
        }

        public void setValues(string name, int weight) // Метод с передачей двух параметра (перегрузка)
        {
            this.name = name;
            this.weight = weight;
        }
        // Переходим в Main

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

        public void Jump() // Метод из интерфейса IJump
        {
            Console.WriteLine("Robot is jumping"); 
        }


    }
}