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
        Console.Write("Nezadali jste celé číslo, Zadejte počet čísel znovu ");
    }

    Console.Write("Zadejte dolní mez (celé číso): ");
    int lowerBound; // Dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo, Zadejte dolní mez znovu ");
    }

    Console.Write("Zadejte horní mez (celé číso): ");
    int upperBound; // Horní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo, Zadejte horní mez znovu ");
    }

    Console.WriteLine();
    Console.WriteLine("======================================");
    Console.WriteLine("Počet čísel: {0}, {1}, {2}", n, lowerBound, upperBound);
    Console.WriteLine("======================================");
    Console.WriteLine();

    // deklarace pole (array)

    int[] myRandoNumbrs = new int[n];

    // příprava pro využití třídy random
     Random myRandoNumbrs = new Random();
    // Random myRandoNumbrs = new Random(15);

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myRandoNumbrs[i] = myRandoNumbrs.Next(lowerBound, upperBound); //vygeneruje se číslo a uloží se do [i]
        Console.Write("{0}", myRandoNumbrs[i]);
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}


      /*if (myRandNumbs[i] < 0)
            negativeNumbs++;
        if (myRandNumbs[i] > 0)
            positiveNumbs++;
        if (myRandNumbs[i] == 0)
            zeros++;            */