using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kortlek = new List<string>(); // Skapar en lista för att representera en kortlek.

        string[] färger = { "k", "h", "s", "r" }; // Array som innehåller alla färger i kortleken.
        string[] valörer = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "E", "D", "K", "Kn" }; // Array som innehåller alla valörer i kortleken.

        foreach (string färg in färger) // Skapar hela kortleken genom att kombinera varje färg med varje valör.
        {
            foreach (string valör in valörer)
            {
                kortlek.Add(färg + valör);
            }
        }
        Random slump = new Random();  // Skapar en instans av "Random" för att slumpa kort.

        while (kortlek.Count > 0)  // Loopar så länge det finns kort kvar i kortleken.
        {
            int index = slump.Next(kortlek.Count); // Genererar ett slumpmässigt index för att dra ett kort från kortleken.
            string dragetKort = kortlek[index];

            Console.WriteLine($"Draget kort är: {dragetKort}"); // Skriver ut det dragna kortet.

            kortlek.RemoveAt(index); // Tar bort det dragna kortet från kortleken.
        }
    }
}
