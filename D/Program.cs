using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text =
            "Läs igenom noga de metoder som finns till de olika generiska klasserna som vi gått igenom.Du kommer hitta många lösningar där. Undersök också klassen Random och dess metoder.";

        Dictionary<string, int> ordFrekvenser = new Dictionary<string, int>(); // Skapar ett "dictionary" för att lagra varje ord och antalet gånger det förekommer.

        string[] raderaTecken = { ".", ",", "!", "?" }; // Tecken som ska tas bort från texten för att bara ha kvar orden

        string renText = text.ToLower(); // Gör texten till små bokstäver.

        foreach (string tecken in raderaTecken) // Tar bort onödiga tecken från texten.
        {
            renText = renText.Replace(tecken.ToString(), "");
        }

        string[] ord = renText.Split(); // Delar upp texten i ord genom att använda mellanslag som "avskiljer".

        foreach (string ordet in ord) // Loopar genom varje ord för att räkna förekomsterna.
        {
            if (ordFrekvenser.ContainsKey(ordet)) // Ökar räkningen om ordet redan finns i ordfrekvens-ordboken
            {
                ordFrekvenser[ordet]++;
            }
            else
            {
                ordFrekvenser[ordet] = 1;
            }
        }
        SortedList<int, List<string>> sorteradFörekomst = new SortedList<int, List<string>>(); // Skapar en sorterad lista där vi grupperar ord.
        foreach (var par in ordFrekvenser)
        {
            int frekvens = par.Value;
            string ord1 = par.Key;

            if (!sorteradFörekomst.ContainsKey(frekvens))
            {
                sorteradFörekomst[frekvens] = new List<string>();
            }
            sorteradFörekomst[frekvens].Add(ord1); // Lägg till ordet i listan för dess specifika frekvens.
        }
        Console.WriteLine("Ord och deras förekomster:");

        for (int i = sorteradFörekomst.Count - 1; i >= 0; i--) // från den högsta frekvensen till den lägsta
        {
            int frekvens = sorteradFörekomst.Keys[i];

            foreach (string ord2 in sorteradFörekomst[frekvens]) // Skriver ut alla ord som har samma frekvens.
            {
                Console.WriteLine($"{ord2}: {frekvens}");
            }
        }
    }
}
