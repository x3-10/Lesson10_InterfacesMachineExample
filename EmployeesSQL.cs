using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_InterfacesMachineExample
{
    class EmployeesSQL:IDatabases
    {
        public void DeleteEmployee(int ID)
        {
            Console.WriteLine($"Employee {ID} was deleted");
        }

        public void InsertEmployeeByID(int ID)
        {
            Console.WriteLine($"Employee {ID} was inserted");

        }

        public void SelectEmployeesAll()
        {
            Console.WriteLine($"Employee was selected");

        }

        public void UpdateEmployee(int ID)
        {

        }

    }
}
