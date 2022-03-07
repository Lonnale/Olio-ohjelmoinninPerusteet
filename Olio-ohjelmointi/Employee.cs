using System;
using System.Collections.Generic;
using System.Text;

namespace OO_programing
{
    class Employee
    {
        public string name;
        public string id;
        public string position;
        public double salary;
      

        

        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
              
        public void comparesalary(Employee employee)
        {

            Console.WriteLine("kutsuvan olion title: " + this.name + ", " +
              "parametrina välitettävän olion title: "+employee.name);



            if (salary > employee.salary)
            {
                Console.WriteLine(this.salary + " on kalliimpi kuin " + employee.salary);

            }
            else if (this.salary < employee.salary)
            {
                Console.WriteLine(employee.salary + " on kalliimpi kuin " + this.salary);
            }
            else if (this.salary == employee.salary)
            {
                Console.WriteLine("Hinnat yhtäsuuret");
            } 


        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Työntekijä: {this.name} , {this.id} , {this.position} , {this.salary}");         
        }

        public override string ToString()
        {
            return $"Työntekijä: {this.name} , {this.id} , {this.position} , {this.salary}";
        }
    }
   


}
