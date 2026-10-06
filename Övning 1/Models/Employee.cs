using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_1.Models
{
    public class Employee
    {

        private string _name;
        private int _salary;

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { 
            get { return _name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Namn kan inte vara tomt");
                }

                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Namn får inte innehålla siffror");
                }
                _name = value;
            }
        } 
        public int Salary 
        {
            get { return _salary; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Lön kan inte vara negativ");
                }
                _salary = value;
            }
        }


    }
}
