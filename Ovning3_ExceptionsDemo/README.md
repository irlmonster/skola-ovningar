Fall 1 : Testa skriva bokstav
Utfall : Skrev ut två gånger att det blev fel, skriver ut att programmet avslutas normalt
Lösning : Skriva ut en gång vad som blev fel och varför vi avslutar programmet

Fall 2 : Byta filnamn
Utfall : Fick samma som innan
Lösning : Gå in i "bin\Debug\net10.0\" och ta bort numbers.txt 

Fall 3 : Byta filnamn
Utfall : Skriver ut att vi stänger streamen och sedan att vi har ett Okänt fel, det gick inte att processa filen. Cleanup avslutat anrop. Att programmet avslutas normalt.
Lösning : Ange att vi inte hitta fil med det filnamnet istället för att det inte gick att processa.
Kanske inte heller att streamen stängs? Ändra och förklara varför det avslutas och loggning på det?

I ProcessFile (Exception ex) så kastar vi ett nytt InvalidOperationException som tar oss till Mains (Exception ex) och skriver ut igen. 

catch (FileNotFoundException) i Main kan alltså aldrig köras, eftersom ProcessFile byter typ på felet innan det kommer dit.

Fall 4 : Skriv 0 i filen
Utfall : 8 (oändlighetstecken) / division med decimaltal kastar inte fel vid noll, bara vid heltal
Lösning : Göra en egen kontroll av 0


Fall 5 : tom fil
Utfall : Okänt fel
löstes med en egen catch för InvalidOperationException i Main


Fall 6 : testade skriva något större än en int (99999999999)
Utfall : Okänt fel: Value was either too large or too small for an Int32.  
Det var väntat efter, har ingen egen Catch och hamnar därför i fallbacken

