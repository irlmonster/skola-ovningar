internal class Program
{
    private static void Main(string[] args)
    {
        // Huvudmenyn
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Huvudmeny:");
            Console.WriteLine("1. Ungdom, pensionär eller standard (pris)");
            Console.WriteLine("2. Upprepa 10 gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine("0. Avsluta programmet");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Välj ett alternativ (1-3): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CinemaMenu();
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
                    Console.WriteLine("Tack för att du använde M & M's Biograf, välkommen tillbaka, Hej då! :)");
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


    // Metoder:
    //Returnera priset baserat på ålder
    static int GetPrice(int age)
    {
        if (age < 20)
        {
            return 80; // ungdomspris
        }
        else
        {
            if (age > 64)
            {
                return 90; // pensionärspris
            }
            else
            {
                return 120; // standardpris
            }
        }
    }

    // Få singel output baserat på ålder
    static void SinglePrice()
    {
        Console.Write("Skriv in din ålder: ");
        int ageInput = int.Parse(Console.ReadLine()); // tar in åldern
        int price = GetPrice(ageInput); // kallar på prismetoden och skickar in åldern som sedan returnerar priset
        // if-satsen kollar på priset och skriver ut det inklusive kategori (ungdom, pensionär eller standard)
        if (price == 80)
        {
            Console.WriteLine();
            Console.WriteLine("Du går som ungdom, priset är 80 kr");
            Console.WriteLine();
        }
        else if (price == 90)
        {
            Console.WriteLine();
            Console.WriteLine("Du går som pensionär, priset är 90 kr");
            Console.WriteLine();
        }
        else 
        {
            Console.WriteLine();
            Console.WriteLine("Du går som standard, priset är 120 kr");
            Console.WriteLine();
        }

    }

    // Få priset baserat på grupp
    static void GroupPrice()
    {
        Console.Write("Skriv in antal personer i gruppen: ");
        int GroupInput = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int TotalSum = 0; 

        for (int i = 1; i <= GroupInput; i++)
        {
            Console.Write($"Skriv in åldern för person {i}: ");
            int ageInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pris för person {i}: {GetPrice(ageInput)} kr"); // skriver ut priset för varje person i gruppen i varie itteration
            TotalSum += GetPrice(ageInput); // lägger till priset för varje person i gruppen
        }
        Console.WriteLine();
        Console.WriteLine($"Totalpris för gruppen på {GroupInput} personer är: {TotalSum} kr");
        Console.WriteLine();
    }

    //Meny för biografen
    static void CinemaMenu()
    {
        Console.WriteLine();
        Console.WriteLine("***********************************************");
        Console.WriteLine("*** Hej och välkommen till M & M's Biograf! ***");
        Console.WriteLine("***********************************************");
        Console.WriteLine();

        Console.WriteLine("Du valde 1, Ungdom, pensionär eller standard");
        Console.WriteLine();

        // Starta submenyn
        bool isSubMenuRunning = true;
        //singel eller grupp
        Console.WriteLine("1. Singel");
        Console.WriteLine("2. Grupp");
        Console.Write("Välj ett alternativ (1-2): ");
        int SubMenuInput = int.Parse(Console.ReadLine());

        switch (SubMenuInput)
        {
            // Singel
            case 1:
                SinglePrice();
                break;

            // Grupp
            case 2:
                GroupPrice();
                break;
        }   

    }



}