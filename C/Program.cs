using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> kortlek = new Dictionary<string, int>(); // Skapar en ett "dictionary" för kortleken där varje kort har ett namn och ett värde.

        string[] färger = { "k", "h", "s", "r" };
        string[] valörer = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "E", "D", "K", "Kn" };
        int[] värden = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 1 }; // en array som representerar värdet av varje valör.

        foreach (string färg in färger)  // Bygger upp kortleken genom att kombinera varje färg med varje valör.
        {
            for (int i = 0; i < valörer.Length; i++)
            {
                string kortNamn = färg + valörer[i];  // Skapar kortets namn tex: "k2" för klöver 2.
                kortlek[kortNamn] = värden[i]; 
            }
        }
        int parAntal = 0; // Variabel för att hålla reda på antalet par som dras.
        int dragningar = 1000;   // Antalet gånger kort ska dras, vilket är 1000.

        List<string> nycklar = new List<string>(kortlek.Keys); // Skapar en lista med alla kortnycklar i kortleken.

        Random slump = new Random(); // Skapar en Random-instans för att slumpa kort.

        for (int i = 0; i < dragningar; i++) // Loopar ett angivet antal dragningar.
        {
            int index1 = slump.Next(nycklar.Count);  // Hämtar namnen på de två dragna korten
            int index2 = slump.Next(nycklar.Count);

            string kort1 = nycklar[index1];
            string kort2 = nycklar[index2];

            Console.WriteLine($"Dragna kort: {kort1} och {kort2}");

            if (kortlek[kort1] == kortlek[kort2]) // Kontrollerar om de dragna korten har samma värde.
            {
                Console.WriteLine($"{kortlek[kort1]} {kortlek[kort2]} PAR!"); // Om korten är ett par, så skrivs det ut och ökar parAntal.
                parAntal++;
            }
        }
        Console.WriteLine($"Antal par i {dragningar} dragningar: {parAntal}"); // Skriver ut totalt antal par som dragits under de angivna dragningarna.
    }
}
