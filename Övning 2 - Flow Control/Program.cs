internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Huvudmeny:");
        Console.WriteLine("1. Ungdom, pensionär eller standard (pris)");
        Console.WriteLine("2. Upprepa 10 gånger");
        Console.WriteLine("3. Det tredje ordet");
        Console.WriteLine("0. Avsluta programmet");
        Console.Write("Välj ett alternativ (1-3): ");
        string input = Console.ReadLine();

        bool isRunning = true;
        while (isRunning)
        {

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


    //Få priset baserat på ålder
    static int GetPrice(int age)
    {
        if (age < 20)
        {
            return 80; // ungdomspris
        }
        else
        {
            if (age >= 64)
            {
                return 90; // pensionärspris
            }
            else
            {
                return 120; // standardpris
            }
        }
    }

    // Få pris baserat på singel
    static void SinglePrice()
    {
        Console.WriteLine("Skriv in din ålder: ");
        int ageInput = int.Parse(Console.ReadLine());
        if (ageInput < 20)
        {
            Console.WriteLine("Du går som ungdom, priset är 80 kr");
        }
        else if (ageInput >= 64)
        {
            Console.WriteLine("Du går som pensionär, priset är 90 kr");
        }
        else if (ageInput >= 20 && ageInput <= 63)
        {
            Console.WriteLine("Du går som standard, priset är 120 kr");
        }
        else
        {
            Console.WriteLine("Ogiltig ålder. Vänligen försök igen.");
            Console.WriteLine("Skriv in din ålder: ");
            ageInput = int.Parse(Console.ReadLine());
        }
    }

    // Få priset baserat på grupp
    static void GroupPrice()
    {
        Console.WriteLine("Skriv in antal personer i gruppen (max 5): ");
        int GroupInput = int.Parse(Console.ReadLine());
        if (GroupInput >= 5)
        {
             
        }
        else if (GroupInput < 5)
        {
            Console.WriteLine("Ni är inte en grupp, priset är 120 kr per person");
        }
        else
        {
            Console.WriteLine("Ogiltigt antal. Vänligen försök igen.");
            Console.WriteLine("Skriv in antal personer i gruppen: ");
            GroupInput = int.Parse(Console.ReadLine());
        }
    }

    //Meny för biografen
    static void CinemaMenu()
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("*** Hej och välkommen till M & M's Biograf! ***");
        Console.WriteLine("***********************************************");
        Console.WriteLine();


        Console.WriteLine();
        Console.WriteLine("du valde 1, Ungdom, pensionär eller standard");

        // Starta submenyn
        bool isSubMenuRunning = true;
        //singel eller grupp
        Console.WriteLine("1. Singel");
        Console.WriteLine("2. Grupp");
        Console.WriteLine("Välj ett alternativ (1-2): ");
        int SubMenuInput = int.Parse(Console.ReadLine());

        switch (SubMenuInput)
        {
            // Singel
            case 1:
                int age = int.TryParse(Console.ReadLine(), out age) ? age : 0;
                int price = GetPrice(age);
                Console.WriteLine($"Priset för en person i din ålder är {price} kr.");
                break;

            // Grupp
            case 2:
                // Call the GetGroupPrice method to get the group price
            break;
        }

        Console.WriteLine();
        

    }



}