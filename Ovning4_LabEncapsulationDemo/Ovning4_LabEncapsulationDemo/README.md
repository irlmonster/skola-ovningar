# Övning 4 - Encapsulation

Alla tre delarna är gjorda i samma projekt, koden är slutversionen efter del 3 (validering).

Testat med:
```
5
Ida Svensson 65 2200
Berit Dahl 57 3333
Bert Lewinsson 27 600
Anna Hamren 44 666.66
Jacob Andersson 35 559.4
20

och

Anna Ivanov -6 2200
B Dahl 57 3333
Hanna Ma 27 600
Asen Holm 44 200
Mikael Johansson 35 500
20
```

# Saker jag stötte på

# CultureInfo
`decimal.Parse("666.66")` kraschade på min dator eftersom svenskt Windows använder komma som decimaltecken.
La till `CultureInfo.CurrentCulture = CultureInfo.InvariantCulture` så att punkt fungerar och utskriften blir 2640.00 som i exemplet.

# Utropstecknet efter Console.ReadLine()

` var lines = int.Parse(Console.ReadLine()!); `

`Console.ReadLine()` returnerar `string?` eftersom den kan ge null som du nämnde, och med Nullable påslaget i projektet ger det en varning.
Lärde mig att `!` säger till kompilatorn att värdet inte är null så att varningen försvinner.
Det gör ingen kontroll när programmet körs, så är det ändå null kraschar det.

# Åldern i IncreaseSalary
Förslaget i PDF:en använder `Age > 30`, men texten säger att de som är yngre än 30 får halva höjningen.
Jag använde `Age < 30` så att det följer texten.

`IncreaseSalary` går via Salary-propertyn istället för fältet, så att valideringen körs rätt.

# Exemplet i del 3
Sista raden i output ("Boris Magnusson gets 660.00 dollars.") stämmer inte med input.
"Mikael Johansson gets 600.00 dollars." `är det som kommer ut såklart ;)`