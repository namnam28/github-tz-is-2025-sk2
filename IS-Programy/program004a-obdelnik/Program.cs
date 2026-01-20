﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení obdélníku *****");
    Console.WriteLine("********************************");
    Console.WriteLine("********* Ngo Nam Khánh **********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    Console.Write("Zadejte šířku obrazce (celé číslo): ");
    int width;

    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obrazce znovu: ");
    }

    Console.Write("Zadejte výška obrazce (celé číslo): ");
    int height;

    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obrazce znovu: ");
    }


    /*    for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                Console.Write("* ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150)); // zpoždění
            }
            Console.WriteLine();
        }
     */

    // --- Obrazec: Čtverec rozdělený na 4 části ---
    // height a width jsou rozměry čtverce
    
// --- Obrazec: Čtverec s rámečkem a 4 částmi uvnitř ---
    int halfHeight = height / 2;
    int halfWidth = width / 2;

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            // 1. KONTROLA OKRAJE (Vnější ohraničení)
            if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
            {
                Console.Write("* ");
            }
            // 2. VNITŘEK (Rozdělení na 4 části)
            else
            {
                // Horní polovina vnitřku
                if (i < halfHeight)
                {
                    if (j < halfWidth) Console.Write("0 "); // Vlevo nahoře
                    else Console.Write("* ");               // Vpravo nahoře
                }
                // Dolní polovina vnitřku
                else
                {
                    if (j < halfWidth) Console.Write("| "); // Vlevo dole
                    else Console.Write("1 ");               // Vpravo dole
                }
            }
            
            // Zpoždění pro efekt vykreslování
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(150));
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}