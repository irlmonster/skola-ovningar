1. vilka klasser bör ingå i programmet?
"Employee" för att skapa objekt av de anställda
"Registry för att hantera listan vi sparar dem i
"Program" för att sköta in och utmatning.


Jag gav mig på att göra enhetstester då det var lite nytt för mig, något jag behöver och gärna övar mer på.


2. Vilka attribut och metoder bör ingå i dessa klasser?

På Employee så har vi Name och Salary, vi kör private set kontroll på "is null or White space" och även kontroll så det inte är siffror. Vi kastar ArgumentException om så är fallet. 

På Salary så kör vi också private set och så kollar vi så det inte är negativt, då kastar vi också ett exception



På Registry så kör vi en IReadOnlyList som gör att det inte erbjuder några metoder för att modda listan

Metod när vi lägger till i listan så kör vi en koll på om inmatningen är null, då kastar vi ett ArgumentNullException och säger att det inte får vara tomt. Sen lägger vi till det i listan. Enda sättet att lägga till i listan är via metoden AddEmployee eftersom vi har listan privat.

3. Skriv programmet!
