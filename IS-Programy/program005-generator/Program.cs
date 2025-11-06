﻿string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** Ngo Nam Khánh ***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    // záporná, kladná, nuly
    int negativeNumbs = 0; //záporná čísla
    int positiveNumbs = 0; //kladná čísla
    int zeros = 0; //nuly

    // sudá a lichá
    int evenNumbs = 0;
    int oddNumbs = 0;




    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);

        /*if (myRandNumbs[i] < 0)
            negativeNumbs++;
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        if (myRandNumbs[i] == 0)
            zeros++;            */

        if (myRandNumbs[i] < 0)
            negativeNumbs++;
        else if (myRandNumbs[i] > 0)
            positiveNumbs++;
        else
            zeros++;

        if (myRandNumbs[i] % 2 == 0)
            evenNumbs++;
        else
            oddNumbs++;    

    }

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("=============================================");
    Console.WriteLine("Počet záporných: {0}", negativeNumbs);
    Console.WriteLine("Počet kladných: {0}", positiveNumbs);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("=============================================");
    Console.WriteLine("Počet sudých: {0}", evenNumbs);
    Console.WriteLine("Počet lichých: {0}", oddNumbs);
    Console.WriteLine("=============================================");
    Console.WriteLine("=============================================");


    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}