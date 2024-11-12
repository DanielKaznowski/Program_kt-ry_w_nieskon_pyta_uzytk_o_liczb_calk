using System;

class Program
{
    static void Main()
    {
        while (true) // Pętla nieskończona
        {
            Console.Write("Podaj liczbę całkowitą: ");

            // Odczytujemy i konwertujemy wprowadzoną wartość na liczbę całkowitą
            if (int.TryParse(Console.ReadLine(), out int liczba))
            {
                if (liczba < 0) // Sprawdzamy, czy liczba jest mniejsza od zera
                {
                    Console.WriteLine("Wprowadzono liczbę mniejszą od zera. Kończenie programu.");
                    break; // Opuszczenie pętli
                }

                Console.WriteLine("Wprowadzono liczbę: " + liczba);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format. Spróbuj ponownie.");
            }
        }
    }
}
