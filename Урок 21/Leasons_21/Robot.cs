using System;

namespace Leasons_21{
    /*Класс Robot с полями конструкторами и методами а так же статический метод  а так же аксессоры*/

    // Для того что бы наш класс стал абстрактным мы перед class добавляем abstract
    // Теперь на основе этого класса мы не можем создавать объекты. ( И все методы нам нужно будет переписать в дочерних классах)
    abstract class Robot{

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


        // И так про абстрактные методы переделаем наш printValues 
        // Для чего? Так как данный метод будет использоваться в класах наследниках то его реализация будет отличатьься 
        // Когда мы делаем абстрактный метод то мы говорим что он не будет реализован в род.классе но будет реализован в классах наследниках
        // Если мы хотим что бы метод абстрактного класса был 100% реализован в дочерних классах то делаем его абстрактным методом.
        public abstract void printValues(); // Ощибки в наших дочерних классах так что переходим в них

        // Статический метод:
        public static void Print(){
            System.Console.WriteLine("Count is: " + count);
        }
        
        


    }
}