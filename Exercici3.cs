//PRE: rep 3 números
using System;

public class Program
{
    // Funció per verificar si l'any és bisiest
    public static void ComprovarBisiest(int any, ref int diesMes)
    {
        if (any % 400 == 0 || (any % 4 == 0 && any % 100 != 0))
        {
            diesMes = 29; // Febrer té 29 dies si és bisiest
        }
        else
        {
            diesMes = 28; // Febrer té 28 dies si no és bisiest
        }
    }

    // Funció per obtenir el número de dies del mes
    public static void ComprovarDiesMes(int mes, int any, ref int diesMes)
    {
        // Mesos amb 31 dies
        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
        {
            diesMes = 31;
        }
        // Mesos amb 30 dies
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            diesMes = 30;
        }
        // Si és febrer, comprova si l'any és bisiest
        else if (mes == 2)
        {
            ComprovarBisiest(any, ref diesMes);
        }
        else
        {
            diesMes = -1; // Mes invàlid
        }
    }

    public static void Main()
    {
        // Sol·licitar la data a l'usuari
        Console.WriteLine("Introdueix el dia, mes i any:");

        // Llegir els valors del dia, mes i any
        int dia = int.Parse(Console.ReadLine());
        int mes = int.Parse(Console.ReadLine());
        int any = int.Parse(Console.ReadLine());

        // Comprovació de la validesa de la data
        int diesMes = 0;

        if (mes < 1 || mes > 12)
        {
            Console.WriteLine("El mes no és vàlid.");
        }
        else
        {
            ComprovarDiesMes(mes, any, ref diesMes);

            // Si diesMes és -1, vol dir que el mes no existeix
            if (diesMes == -1)
            {
                Console.WriteLine("El mes no és vàlid.");
            }
            else
            {
                // Comprovar si el dia és vàlid per al mes
                if (dia < 1 || dia > diesMes)
                {
                    Console.WriteLine("El dia no és vàlid.");
                }
                else
                {
                    Console.WriteLine("La data és vàlida.");
                }
            }
        }
    }
}
//POST: retorna si els números (dd, mm, yyyy) estan dins del rang de data corresponent
