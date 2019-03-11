using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public List<string> Restaurants { get; set; }
        // public string Food { get; set; }


        public Employee (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string Eat()
        {
            var random = new Random();
           List<string> Restaurantz = new List<string>();
           Restaurantz.Add("o\'charley\'s");
           Restaurantz.Add("slim and husky");
            Restaurantz.Add("el camino real");
            int index = random.Next(Restaurantz.Count);
           return (Restaurantz[index] + " restaurant");
         }

        public string Eat(string food)
        {
            //Food = food;
            return food;
            // string foodChoice = Console.ReadLine();
        }


        public void Eat(List<Employee> companions)
        {
           
            foreach (var companion in companions)
            {
                Console.WriteLine(companion.FirstName);
            }

            var random = new Random();
            List<string> Restaurantz = new List<string>();
            Restaurantz.Add("o\'charley\'s");
            Restaurantz.Add("slim and husky");
            Restaurantz.Add("el camino real");
            int index = random.Next(Restaurantz.Count);
            Console.WriteLine($"{FirstName} {LastName} is having lunch at {Restaurantz[index]}");
        }
    }
}
