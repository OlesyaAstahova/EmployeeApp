using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //Поля данных
        private string empName;
        private int empID;
        private float currPay;
        //Новое поле и свойство
        private int empAge;
        public int Age
        {
            get
            {
                return empAge;
            }
            set
            {
                empAge = value;
            }
        }


        //Свойства
        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        //М.б. бы добавить доп. бизнес-правила для установки этих свойств, но нет необходимости
        public int ID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }

        public float Pay
        {
            get
            {
                return currPay;
            }
            set
            {
                currPay = value;
            }
        }


        //Обновленные конструкторы
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 20, id, pay) { }
        
        public Employee (string name, int age, int id, float pay)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }
        
        //Методы
        public string GetName()
        {
            return empName;
        }
        public void SetName(string name)
        {
            //Перед присваиванием проверить входное значение
            if (name.Length > 15)
            {
                //Ошибка!
                Console.WriteLine("Error! Name must be less than 16 characters!");
            }
            else
            {
                empName = name;
            }
        }
        public void GiveBonus (float amount)
        {
            currPay += amount;
        }
        //Обновленный метод DisplayStats() 
        public void DisplayStats ()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }
     
    }
}
