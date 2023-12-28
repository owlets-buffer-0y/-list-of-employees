// Program.cs
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Employee Management System");
        
        // Create an instance of the EmployeeManager class
        EmployeeManager employeeManager = new EmployeeManager();

        // Add some sample employees
        employeeManager.AddEmployee(new Employee("John Doe", "Developer"));
        employeeManager.AddEmployee(new Employee("Jane Smith", "Manager"));

        // Display the list of employees
        employeeManager.DisplayEmployees();
    }
}
