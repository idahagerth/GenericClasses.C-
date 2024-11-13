using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> inmatadeTal = new List<int>(); // Skapar en lista för att lagra de tal som användaren matar in.

        bool visaDialog = true;  // Variabel för att hålla reda på om dialogen ska visas igen.

        while (visaDialog) // En loop som körs så länge visaDialog är true.
        {
            Console.Write("Ange ett tal eller 0 för att avsluta programmet: ");

            int inmatatTal;

            if (int.TryParse(Console.ReadLine(), out inmatatTal)) // Försöker omvandla användarens inmatning till ett heltal.
            {
                if (inmatatTal == 0) // Om användaren matar in 0, så avslutas programmet genom att sätta "visaDialog" till false.
                {
                    visaDialog = false;
                }
                else
                {
                    inmatadeTal.Add(inmatatTal);

                    double medelvärdet;

                    int sum = 0;

                    foreach (int tal in inmatadeTal) // Loopar igenom varje tal i listan och adderar dem till "sum".
                    {
                        sum += tal;
                    }
                    medelvärdet = (double)sum / inmatadeTal.Count;
                    Console.WriteLine($"Medelvärdet är: {medelvärdet}");
                }
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning!"); // visar ett felmeddelande vid fel inmatning.
            }
        }
    }
}
