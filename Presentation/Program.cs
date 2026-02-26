
//Tentar usar depois com Try.Parse(), ao inves de parse comum para pratica e uso mais seguro
//Tentar fazer tambem com do-while tambem, para pratica

using System.Security.Cryptography;

var rng = new Random();

System.Console.WriteLine(" --- Jogo da adivinhação --- ");

System.Console.WriteLine("Pensando...");
int randNumb = rng.Next(1, 20);

System.Console.Write("Pensei em um número de 1 a 20, qual acha que é: ");
int number = int.Parse(Console.ReadLine());

while (number != randNumb)
{
    if(number > randNumb)
    {
        System.Console.Write("Muito alto! \nTente novamente: ");
        number = int.Parse(Console.ReadLine());
    }
    else
    {
        System.Console.Write("Muito baixo! \nTente novamente: ");
        number = int.Parse(Console.ReadLine());
    }
}

System.Console.WriteLine($"Parabéns você acertou o número! \nEle era: {randNumb}");

