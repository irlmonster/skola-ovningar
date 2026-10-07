internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("*** Hej och välkommen till M & M's Biograf! ***");
        Console.WriteLine("***********************************************");

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Huvudmeny:");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine("2. Upprepa 10 gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine("0. Avsluta programmet");
            Console.Write("Välj ett alternativ (1-3): ");
            string input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    //AgeControl();
                    Console.WriteLine();
                    Console.WriteLine("du valde 1, Ungdom eller pensionär");
                    Console.WriteLine("Undermeny för: Ungdom eller pensionär");
                    Console.WriteLine("Även för att kunna räkna ut priset för ett sällskap");
                    Console.WriteLine();
                    break;
                case "2":
                    //RepeatTenTimes();
                    Console.WriteLine();
                    Console.WriteLine("du valde 2, Upprepa 10 gånger");         
                    Console.WriteLine();
                    break;
                case "3":
                    //ShowThirdWord();
                    Console.WriteLine();
                    Console.WriteLine("du valde 3, Det tredje ordet");
                    Console.WriteLine();
                    break;
                case "0":
                    isRunning = false;
                    Console.WriteLine();
                    Console.WriteLine("Tack för att du använde M & M's Biograf! Hej då!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                    Console.WriteLine();
                    break;
            }
        }



    }
}