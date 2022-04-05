using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_JSON.Models
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> _employees;

        public Department(int id, string name)
        {
            Id = id;
            Name = name; 
            _employees = new List<Employee>();
        }
    }
}
