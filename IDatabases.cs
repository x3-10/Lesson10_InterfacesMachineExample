using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_InterfacesMachineExample
{
    interface IDatabases
    {
        void InsertEmployee();
        void UpdateEmployee();

        void DeleteEmployee();

        void SelectEmployeesAll();
        void SelectEmployeeByID();

    }

}
