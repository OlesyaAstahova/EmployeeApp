using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 4569, 30000);
            emp.Age++;
            emp.GiveBonus(1000);
            emp.DisplayStats();
            Console.WriteLine(emp.SocialSecurityNumber);
            /*
            //Использовать методы get/set для взаимодействия с именем объекта
            emp.SetName("Marv");
            Console.WriteLine("Employee is named: {0}", emp.GetName());
            */
            // Установка и получение свойства Name
            emp.Name = "Marv";
            Console.WriteLine("Employee is named: {0}", emp.Name);
            Console.ReadLine();
        }
    }
}
