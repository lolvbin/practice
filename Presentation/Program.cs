
System.Console.Write("Digite um número para ver a tabuada dele ate 10: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; 10 >= i; i++)
{
    double mult = n * i;
    System.Console.WriteLine($"{n} x {i} = {mult} ");
}