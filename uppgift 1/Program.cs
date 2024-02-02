using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> namnLista = new List<string>();

        while (true)
        {
            Console.Write("Skriv in ett namn (tryck enter för att avsluta): ");
            string namn = Console.ReadLine();

            if (string.IsNullOrEmpty(namn))
                break; 

            namnLista.Add(namn);
        }

        Console.WriteLine("\nNamnen i omvänd bokstavsordning:");
        for (int i = namnLista.Count - 1; i >= 0; i--)
        {
            string omvandNamn = new string(namnLista[i].ToCharArray().Reverse().ToArray());
            Console.WriteLine(omvandNamn);
        }
    }
}
