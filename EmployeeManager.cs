// EmployeeManager.cs
using System;
using System.Collections.Generic;

public class EmployeeManager
{
    private List<Employee> employees;

    public EmployeeManager()
    {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("Employee List:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}
