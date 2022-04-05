using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_JSON.Models
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public string ShowInfo()
        {
            return $"Id: {Id} - Name: {Name} - Salary: {Salary}";
        }
    }
}
