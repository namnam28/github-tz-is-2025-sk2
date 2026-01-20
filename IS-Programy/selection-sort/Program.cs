string again = "a";
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
    int[] numbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        numbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", numbs[i]);
    }


    // Selection sort
    for (int i = 0; i < n; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (numbs[j] > numbs[maxIndex])
            {
                maxIndex = j;
            }
        }
        int tmp = numbs[maxIndex];
        numbs[maxIndex] = numbs[i]; 
        numbs[i] = tmp;
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("Seřazená čísla pomocí Selection Sortu: ");
    for (int i = 0; i < n; i++)
        {
            Console.Write("{0}; ", numbs[i]);
        }


    int uniqueCount = 0;
    int lastValue = int.MinValue;
    int second = 0, third = 0, fourth = 0;
    for (int i = 0; i < n; i++)
    {
        if (numbs[i] != lastValue)
        {
            uniqueCount++;
            lastValue = numbs[i];

            if (uniqueCount == 2)
                second = numbs[i];
            if (uniqueCount == 3)
                third = numbs[i];
            if (uniqueCount == 4)
                fourth = numbs[i];
        }
    }

    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("Druhé největší číslo: " + second);
    Console.WriteLine("Třetí největší číslo: " + third);
    Console.WriteLine("Čtvrté největší číslo: " + fourth);





    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}