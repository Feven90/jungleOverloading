using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee employee1 = new Employee("Aman", "Sidamo");
            Employee employee2 = new Employee("Maria", "Bekure");
            Employee employee3 = new Employee("Kevin", "John");

            var companions = new List<Employee>();
            companions.Add(employee1);
            companions.Add(employee2);
            companions.Add(employee3);

            Console.WriteLine("Enter your first and last name");
            string userFirstName = Console.ReadLine();
            string userLastName = Console.ReadLine();
            Employee employeInfo = new Employee(userFirstName, userLastName);
            //string employeeInformation = new Employee();
            Console.WriteLine($"{userFirstName + userLastName} is eating at {employeInfo.Eat()}");

            Console.WriteLine();
            Console.WriteLine("What did you eat?");
            string foodChoice = Console.ReadLine();
            Console.WriteLine($"{userFirstName + userLastName} ate {employeInfo.Eat(foodChoice)}");

            //employeInfo.Eat(foodChoice);
            employeInfo.Eat(companions);
            Console.ReadLine();

            
        }
    }
}
