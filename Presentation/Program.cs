using System;
using System.Globalization;
using System.Linq;

System.Console.Write("Digite una frase ae: ");
string fraseD = Console.ReadLine().ToLower();
int contVogais = 0;
int contConsoante = 0;

char[] vogais = ['a','e','i','o','u'];

foreach (char letra in fraseD)
{
    if (vogais.Contains(letra))
    {
        contVogais++;
    }
    /*else if(char.IsLetter(letra) && !vogais.Contains(letra)){
        contConsoante++;
    }*/
}

System.Console.WriteLine($"Sua frase possui {contVogais} vogais!");
//System.Console.WriteLine();
//System.Console.WriteLine($"Sua frase possui {contVogais} consoantes!");