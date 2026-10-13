using System;
using System.Collections.Generic;
using System.Globalization;


namespace Ovning4_LabEncapsulationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gör att "666.66" kan parsas och att utskriften blir 2640.00 och inte 2640,00
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var lines = int.Parse(Console.ReadLine()!);
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine()!.Split();

                try
                {
                    var person = new Person(
                        cmdArgs[0],
                        cmdArgs[1],
                        int.Parse(cmdArgs[2]),
                        decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            var bonus = decimal.Parse(Console.ReadLine()!);

            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
