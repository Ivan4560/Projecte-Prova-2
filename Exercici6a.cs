/* valors limit:
els valor limits tindriem com fora de rang tot el que serian acents i caracters especial tambe fora de rang
tidriem tot els valors introduits que no superin els 5 caracters o que tinguin mes de 15 caracters i que tinguin un numero al
principi o final



*/
using System;
using System.Text.RegularExpressions;

public class ContrasenyaValidator
{
    public static bool EsValida(string contrasenya)
    {
        // Comprovar longitud
        if (contrasenya.Length < 6 || contrasenya.Length > 15)
        {
            return false;
        }

        // Comprovar que només conté lletres i números
        if (!Regex.IsMatch(contrasenya, "^[a-zA-Z0-9]+$"))
        {
            return false;
        }

        // Comprovar que no comença ni acaba amb un número
        if (Char.IsDigit(contrasenya[0]) || Char.IsDigit(contrasenya[contrasenya.Length - 1]))
        {
            return false;
        }

        return true;
    }
}
