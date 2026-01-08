using System;
using System.Threading;

namespace RuskaRuletaPro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int penize = 1000;

            Console.WriteLine("===========================================");
            Console.WriteLine("       RUSKÁ RULETA: CASINO EDITION        ");
            Console.WriteLine("===========================================");
            Console.WriteLine($"Vítej! Tvůj počáteční kapitál je {penize} Kč.");

            while (penize > 0)
            {
                Console.WriteLine("\n-------------------------------------------");
                int sazka = 0;

                // OŠETŘENÍ VSTUPU PRO SÁZKU
                while (true)
                {
                    Console.Write($"Kolik chceš vsadit? (Tvůj zůstatek: {penize} Kč): ");
                    string vstupSazka = Console.ReadLine();

                    if (int.TryParse(vstupSazka, out sazka) && sazka > 0 && sazka <= penize)
                    {
                        break; // Sázka je v pořádku, vyskočíme z této malé smyčky
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"CHYBA: Zadej platné číslo od 1 do {penize}!");
                        Console.ResetColor();
                    }
                }

                // Příprava zbraně na dané kolo
                int poziceNaboje = random.Next(0, 6);
                int aktualniKomora = 0;
                bool koloBezi = true;
                int aktualniPot = sazka;

                Console.WriteLine("\n[Vkládám náboj do jedné z 6 komor a roztáčím bubínek...]");
                Thread.Sleep(1500);

                while (koloBezi)
                {
                    Console.WriteLine("\n*******************************************");
                    Console.WriteLine($"KOMORA: {aktualniKomora + 1} / 6");
                    Console.WriteLine($"V BANKU JE: {aktualniPot} Kč");
                    Console.WriteLine("*******************************************");
                    Console.WriteLine("1 - ZMÁČKNOUT SPOUŠŤ");
                    Console.WriteLine("2 - VZÍT PENÍZE A UKONČIT KOLO");
                    Console.Write("Tvoje volba: ");
                    
                    string volba = Console.ReadLine();

                    if (volba == "1")
                    {
                        Console.Write("Napřahuji kohoutek... ");
                        Thread.Sleep(1000);
                        Console.Write("Cvak...");
                        Thread.Sleep(1000);

                        if (aktualniKomora == poziceNaboje)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nBOOOOOOOM! Prohrál jsi.");
                            Console.ResetColor();
                            penize -= sazka;
                            koloBezi = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            // S každým přežitím se bank zvýší o 50% původní sázky jako bonus
                            int bonus = (int)(sazka * 0.5); 
                            aktualniPot += bonus;
                            
                            Console.WriteLine(" PŘEŽIL JSI!");
                            Console.ResetColor();
                            
                            aktualniKomora++;

                            if (aktualniKomora == 5 && poziceNaboje == 5)
                            {
                                Console.WriteLine("\nPoslední komora obsahuje náboj! Bereš bank a končíš.");
                                penize += (aktualniPot - sazka);
                                koloBezi = false;
                            }
                        }
                    }
                    else if (volba == "2")
                    {
                        int zisk = aktualniPot - sazka;
                        Console.WriteLine($"\nChytré rozhodnutí. Odnášíš si čistý zisk {zisk} Kč.");
                        penize += zisk;
                        koloBezi = false;
                    }
                    else
                    {
                        // OŠETŘENÍ VSTUPU PRO MENU
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n[!] Nezadali jste nic z menu. Zvolte 1 nebo 2.");
                        Console.ResetColor();
                    }
                }

                if (penize <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nJsi na mizině! Casino tě vyhazuje na ulici.");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.WriteLine($"\nTvůj aktuální zůstatek je {penize} Kč.");
                    Console.Write("Chceš zkusit další kolo? (ano/ne): ");
                    if (Console.ReadLine().ToLower() != "ano") break;
                }
            }

            Console.WriteLine("\n===========================================");
            Console.WriteLine($"KONEC HRY. Odcházíš s částkou: {penize} Kč.");
            Console.WriteLine("===========================================");
            Console.WriteLine("Stiskni libovolnou klávesu pro ukončení...");
            Console.ReadKey();
        }
    }
}