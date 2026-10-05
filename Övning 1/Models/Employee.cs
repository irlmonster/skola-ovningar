using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_1.Models
{
    internal class Employee
    {
        public string Name { 
            get;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Namn kan inte vara tomt");
                } 
            }
        } 
        public int Salary {
            get { return Salary; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Lön kan inte vara negativ (endast om du är skyldig oss dollars!)");
                }
                Salary = value;
            }
        }


    }
}
