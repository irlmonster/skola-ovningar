namespace ExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("=== Start av programmet ===");


                bool success = false;

                // Exempel 1: try-catch-finally
                try
                {
                    Console.WriteLine("Försöker läsa fil och räkna...");
                    var path = Path.Combine(AppContext.BaseDirectory, "numbers.txt");
                    var result = ProcessFile(path);
                  
                    Console.WriteLine($"\nResultat: {result}");
                    success = true;
                }
                catch (FileNotFoundException ex)
                {
                    // Specifikt fel om filen inte finns
                    Console.WriteLine($"Filen hittades inte: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    // Specifikt fel om texten inte kan tolkas som tal
                    Console.WriteLine($"Formatfel: {ex.Message}");
                }
                catch (DivideByZeroException ex)
                {
                    // Specifikt fel om nolldivision
                    Console.WriteLine($"Kan inte dividera med noll: {ex.Message}");
                }
                catch (InvalidOperationException ex)
                {
                    // Specifikt fel om filen är tom
                    Console.WriteLine($"Ogiltig åtgärd: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Fallback för alla övriga obekanta fel
                    Console.WriteLine($"Okänt fel: {ex.Message}");
                }
                finally
                {
                    // Körs ALLTID, även om det blev undantag
                    Console.WriteLine("Cleanup: Logging avslutat anrop.");
                }


                // Berättar om beräkningen lyckades eller misslyckades
                if (success == true)
                {
                    Console.WriteLine("Programmet avslutas. Beräkningen lyckades.");
                }
                else
                {
                    Console.WriteLine("Programmet avslutas. Beräkningen misslyckades.");
                }
                
                
            }

            // Exempel på metod som själv kastar ett undantag (throw)
            static double ProcessFile(string fileName)
            {
                // Om filnamnet är tomt: logiskt fel vi vill signalera
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    throw new ArgumentException("Filnamn får inte vara tomt eller null.", nameof(fileName));
                }

                StreamReader? reader = null;
                try
                {
                    reader = new StreamReader(fileName);

                    string? line = reader.ReadLine();
                    if (line == null)
                        throw new InvalidOperationException("Filen är tom.");

                    // Försöker omvandla text till tal
                    int number = int.Parse(line); // Kan ge FormatException

                    if (number == 0)
                        throw new DivideByZeroException();

                    return 100.0 / number;
                }
                finally
                {

                    if (reader != null)
                    {
                        reader.Close();
                        Console.WriteLine("finally i ProcessFile: StreamReader stängd.");
                    }


                }
            }
        }
    }
}

