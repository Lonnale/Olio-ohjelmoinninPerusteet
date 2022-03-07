using System;
using System.Collections.Generic;
using System.Text;

namespace OO_programing
{
    static void EmployeeExample()
    {


        Employee[] employees = new Employee[3];
        employees[0] = new Employee("Aleksi", "12345", "Toimitusjohtaja", 1500000);
        employees[1] = new Employee("Pertti", "15321", "kirjanpitäjä", 5500);
        employees[2] = new Employee("Masi", "12356", "It-Arkkitehti", 3300);



        foreach (Employee vol in employees)
        {
            Console.WriteLine(vol.ToString());

        }
        Console.WriteLine("");
        employees[0].comparesalary(employees[1]);
        for (int i = 0; i < employees.Length; i++)
        {


            if (i == employees.Length - 1)
            {
                employees[i].comparesalary(employees[0]);
            }
            else
            {
                employees[i].comparesalary(employees[i + 1]);
            }
        }

    }
}
