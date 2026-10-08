using System;
using Övning_1.Models;

namespace Övning1.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void Constructor_ValidValues_SetsNameAndSalary()
        {
            Employee employee = new Employee("John Doe", 50000);

            Assert.Equal("John Doe", employee.Name);
            Assert.Equal(50000, employee.Salary);
        }

        [Fact]
        public void Constructor_EmptyName_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Employee("", 50000));
        }

        [Fact]
        public void Constructor_NameWithDigits_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Employee("John123", 50000));
        }

        [Fact]
        public void Constructor_NegativeSalary_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Employee("John Doe", -50000));
        }

    }
}
