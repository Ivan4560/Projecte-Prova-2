using System;

public class Programa
{
    static void Main()
    {
        int[] valors = new int[20];

        // Demanem 20 valors enters a l'usuari
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Introdueix el valor {i + 1} de 20:");
            valors[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        for (int i = 0; i < valors.Length - 1; i++)
        {
            for (int j = 0; j < valors.Length - i - 1; j++)
            {
                if (valors[j] < valors[j + 1])
                {
                    // Intercanviem els valors
                    int temp = valors[j];
                    valors[j] = valors[j + 1];
                    valors[j + 1] = temp;
                }
            }
        }

        // Mostrem la llista ordenada de manera descendent
        Console.WriteLine("\nLlista ordenada de manera descendent:");
        for (int i = 0; i < valors.Length; i++)
        {
            Console.Write(valors[i] + " ");
        }
        Console.WriteLine();

        // Demanem un valor enter per comprovar si està a la llista
        Console.WriteLine("\nIntrodueix un valor per comprovar si està a la llista:");
        int valorCercat = Convert.ToInt32(Console.ReadLine());

        // Comprovem si el valor es troba a la llista
        int iCercat = 0;
        while (iCercat < 20)
        {
            if (valors[iCercat] == valorCercat)
            {
                Console.WriteLine($"El valor {valorCercat} es troba a la llista.");
                break;
            }
            iCercat++;
        }

        // Si el valor no es troba
        if (iCercat == 20)
        {
            Console.WriteLine($"El valor {valorCercat} no es troba a la llista.");
        }
    }
}
