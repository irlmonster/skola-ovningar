using Övning_1;
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
            Console.WriteLine("Skriv namn på anställd:");
            string name = Console.ReadLine();

            Console.WriteLine("Skriv lön på anställd:");
            string salaryInput = Console.ReadLine();
            if (!int.TryParse(salaryInput, out int salary))
            {
                Console.WriteLine("Ogiltig lön. Försök igen.");
                break;
            }


            Employee employee = new Employee(name, salary);
            registry.AddEmployee(employee);

            Console.WriteLine($"Anställd {name} med lön {salary} har lagts till.");
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
    }

}
