using System;
using Övning_1.Models;
using Övning_1.Services;

namespace Övning1.Tests
{
    public class RegistryTests
    {
        [Fact]
        public void NewRegistry_NoEmployeesAdded_IsEmpty()
        {
            Registry registry = new Registry();

            Assert.Empty(registry.Employees);
        }

        [Fact]
        public void AddEmployee_ValidEmployee_AddToList()
        {
            Registry registry = new Registry();
            Employee employee = new Employee("Jane Doe", 60000);
            registry.AddEmployee(employee);
            Assert.Single(registry.Employees);
            Assert.Equal(employee, registry.Employees[0]);
        }

        [Fact]
        public void AddEmployee_Null_ThrowsArgumentNullException()
        {
            Registry registry = new Registry();
            Assert.Throws<ArgumentNullException>(() => registry.AddEmployee(null));
        }

    }
}
