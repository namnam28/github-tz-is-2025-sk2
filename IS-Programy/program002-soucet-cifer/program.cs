﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("***** Ciferný součet a součin *****");
    Console.WriteLine("***********************************");
    Console.WriteLine("*********** Tomáš Žižka ***********");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    //Vstup hodnoty do programu
    Console.Write("Zadejte celé číslo pro nějž chcete určit součet a součin cifer: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ZNOVU celé číslo pro nějž chcete určit součet a součin cifer: ");
    }

    int suma = 0;
    int numberBackup = number;
    int digit;

    if (number < 0) {
        number = -number;
    }

    while (number >= 10) {
        digit = number % 10; // zbytek po dělení 10 nám bude určovat jednotlivé cifry (zprava)
        number = (number - digit) / 10;
        Console.WriteLine("Zbytek = {0}", digit);
        suma = suma + digit;
    }
    Console.WriteLine("Zbytek = {0}", number);

    // nesmíme zapomenout příčíst poslední číslici do sumy
    suma = suma + number;

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}",numberBackup, suma);


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}