﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************");
    Console.WriteLine("***** Největšíí ze tří čísel *****");
    Console.WriteLine("**********************************");
    Console.WriteLine("*********** Ngo Nam Khánh **********");
    Console.WriteLine("**********************************");
    Console.WriteLine();

    Console.Write("Zadejte celočíselnou hodnotu A: ");
    int a;

    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu A znovu: ");
    }

    Console.Write("Zadejte celočíselnou hodnotu B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu B znovu: ");
    }

    Console.Write("Zadejte celočíselnou hodnotu C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu C znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("===========================================================");
    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největší číslo je A = {a}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší číslo je B = {b}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    Console.WriteLine("===========================================================");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}