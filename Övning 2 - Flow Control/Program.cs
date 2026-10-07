internal class Program
{
    private static void Main(string[] args)
    {
        // Huvudmenyn
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Huvudmeny:");
            Console.WriteLine("1. Ungdom, pensionär eller standard (Biografen)");
            Console.WriteLine("2. Upprepa 10 gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine("0. Avsluta programmet");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Välj ett alternativ (1-3): ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    // Biomenyn
                    CinemaMenu();
                    break;
                case "2":
                    // Upprepa 10 gånger
                    Console.WriteLine();
                    Console.WriteLine("Du valde 2, Upprepa 10 gånger.");         
                    Console.Write("Skriv in en sträng: ");
                    string StringInput = Console.ReadLine();
                    RepeatTenTimes(StringInput);
                    break;
                case "3":
                    //Skriver ut det tredje ordet
                    Console.WriteLine();
                    Console.WriteLine("Du valde 3, Det tredje ordet.");
                    ShowThirdWord();
                    Console.WriteLine();
                    break;
                case "0":
                    // Avlsuta programmet
                    isRunning = false;
                    Console.WriteLine();
                    Console.WriteLine("Tack för att du använde M & M's applikation, välkommen tillbaka!");
                    Console.WriteLine("Hej då! :)");
                    Console.WriteLine();
                    break;
                default:
                    // Ogiltigt val, kör menyn igen.
                    Console.WriteLine();
                    Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                    Console.WriteLine();
                    break;
            }
        }



    }


    // METODER:
    /* 
    Säkerhetsmetod för att kontrollera så att användaren inte matar in ogiltiga värden, t.ex. bokstäver istället för siffror.
    */
    static int ReadInt(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";

            // Godkänn bara om texten är ett heltal OCH talet är 0 eller större
            if (int.TryParse(input, out result) && result >= 0)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Vänligen ange ett heltal som är 0 eller större.");
            }
        }
    }


    /* 
    Metod för att skriva ut det tredje ordet i en sträng med hantering av flera skiljetecken och tomma strängar. 
    */
    static void ShowThirdWord()
    {
        Console.WriteLine("(mellanslag och skiljetecken räknas inte)");
        Console.Write("Skriv in en sträng: ");
        string input = Console.ReadLine() ?? ""; // ?? "" ersätter tydligen null med en tom sträng för att undvika nullreferensfel
        char[] separators = new char[] { ' ', ',', '.', ';', ':', '!', '?' }; // lagt till några extra skiljetecken för att fokusera på ord
        var Words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries); //RemoveEmptyEntries tar bort flera skiljetecken i rad

        // Kollar så att det finns minst 3 ord i strängen innan vi försöker skriva ut det tredje ordet
        if (Words.Length >= 3)
        {
            Console.WriteLine($"Det tredje ordet är: {Words[2]}");
        }
        else
        {
            Console.WriteLine("Strängen innehåller inte tillräckligt många ord.");
        }
    }

     
    /* 
    Metod för att upprepa 10 gånger
    Skriver ut strängen 10 gånger med nummer framför
    */
    static void RepeatTenTimes(string input)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {input} "); 
        }
        Console.WriteLine();
        
    }


    /*
    Metoder för biografen
    */

    //Returnera priset baserat på ålder
    static int GetPrice(int age)
    {
        // Gratis för barn under 5 år och äldre än 100 år.
        // Kollas först, annars tas det av ungdoms eller pensionärsvillkoret.
        if (age < 5 || age > 100)
        {
            return 0;
        }

        // Nästlad if-sats: pensionärsfrågan ställs bara om personen inte är ungdom
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
        int ageInput = ReadInt("Skriv in din ålder: ");
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
        else if (price == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Du går gratis!");
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
        int GroupInput = ReadInt("Skriv in antal personer i gruppen: "); // Kör min nya metod för att kontrollera så det inte är bokstäver
        Console.WriteLine();
        int TotalSum = 0; 

        for (int i = 1; i <= GroupInput; i++)
        {
            int ageInput = ReadInt($"Skriv in åldern för person {i}: "); // Kör min nya metod för att kontrollera så det inte är bokstäver
            Console.WriteLine($"Pris för person {i}: {GetPrice(ageInput)} kr"); // skriver ut priset för varje person i gruppen i varie itteration
            TotalSum += GetPrice(ageInput); // lägger till priset för varje person i gruppen
        }
        Console.WriteLine();
        Console.WriteLine($"Totalpris för gruppen på {GroupInput} personer är: {TotalSum} kr");
        Console.WriteLine();
    }

    // Meny för biografen
    static void CinemaMenu()
    {
        Console.WriteLine();
        Console.WriteLine("***********************************************");
        Console.WriteLine("***********************************************");
        Console.WriteLine("*** Hej och välkommen till M & M's Biograf! ***");
        Console.WriteLine("***********************************************");
        Console.WriteLine("***********************************************");
        Console.WriteLine();

        Console.WriteLine("Du valde 1, Ungdom, pensionär eller standard.");
        Console.WriteLine();

        // Starta submenyn
        bool isSubMenuRunning = true;
        //singel eller grupp
        Console.WriteLine("1. Singel");
        Console.WriteLine("2. Grupp");
        Console.WriteLine("0. För att gå tillbaka till huvudmenyn");
        int SubMenuInput = ReadInt("Välj ett alternativ (1-2): "); // Kör min nya metod för att kontrollera så det inte är bokstäver

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

            case 0:
                isSubMenuRunning = false;
                break;

            default:
                Console.WriteLine();
                Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                Console.WriteLine();
                break;

        }   


    }


}