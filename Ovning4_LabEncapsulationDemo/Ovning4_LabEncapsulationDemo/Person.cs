using System;

namespace Ovning4_LabEncapsulationDemo
{
    public class Person
    {
        // Privata fält
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private int _age;
        private decimal _salary;

        // Konstruktorn går via properties så att valideringen alltid körs
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                _lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                _age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return _salary;
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 dollars!");
                }
                _salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            // Yngre än 30 får halva höjningen
            if (Age < 30)
            {
                Salary += Salary * percentage / 200;
            }
            else
            {
                Salary += Salary * percentage / 100;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} gets {Salary:F2} dollars.";
        }
    }
}
