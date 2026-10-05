using Övning_1.Models;
using Övning_1.Services;

Console.WriteLine("Hallå restaurangen!");
Console.WriteLine("Vad vill du göra?");

Registry registry = new Registry();
while (true)
{
    Console.WriteLine("1. Lägg till anställd");
    Console.WriteLine("2. Visa alla anställda");
    Console.WriteLine("3. Avsluta");

    string input = Console.ReadLine();

    switch (input)
    {
        case ("1"):
            string name;
            while (true)
            {
                Console.WriteLine("Skriv namn på anställd:");
                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name) && !name.Any(char.IsDigit))
                {
                    break;
                }

                Console.WriteLine("Ogiltigt namn. Det får inte vara tomt eller innehålla siffror.");
            }

            int salary;
            while (true)
            {
                Console.WriteLine("Skriv lön på anställd:");
                string salaryInput = Console.ReadLine();

                if (int.TryParse(salaryInput, out salary) && salary >= 0)
                {
                    break;
                }

                Console.WriteLine("Ogiltig lön. Ange ett heltal som inte är negativt.");
            }

            try
            {
                Employee employee = new Employee(name, salary);
                registry.AddEmployee(employee);

                Console.WriteLine($"Anställd {name} med lön {salary} har lagts till.");
                
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
            break;
    

        case ("2"):
        Console.WriteLine("Alla anställda:");
        foreach (var r in registry.Employees)
        {
            Console.WriteLine($"Namn: {r.Name}, Lön: {r.Salary}");
        }
        break;




        case ("3"):
            return;

        default:
            Console.WriteLine("Ogiltigt val. Försök igen.");
            break;
    }

}
