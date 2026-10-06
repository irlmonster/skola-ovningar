using Övning_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_1.Services
{
    public class Registry
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public IReadOnlyList<Employee> Employees
        {
            get { return _employees; }
        }


        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Fältet kan inte lämnas tomt");
            }
            _employees.Add(employee);
        }
    }
}
