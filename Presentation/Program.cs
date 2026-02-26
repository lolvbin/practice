
List<double> nums = new List<double>();

System.Console.WriteLine("Quantas notas serão digitadas para calculo da media?");
int n = int.Parse(Console.ReadLine());


for(int i = 1; i <= n; i++)
{
    System.Console.Write($"Nota {i}: ");
    double note = double.Parse(Console.ReadLine());
    nums.Add(note);
}

double MedAri = nums.Sum() / n;

if (MedAri >= 7)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Aprovado caba");
}else if (MedAri <= 6.9 && MedAri >= 5)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Recuperação meu chapa");
}
else
{
    System.Console.WriteLine();
    System.Console.WriteLine("Reprovado meno");
}

System.Console.WriteLine();
System.Console.WriteLine($"Sua media foi: {MedAri:F1}");