double n1 = 0;
double n2 = 0;
double media = 0;

Console.WriteLine("Digite uma nota:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite outra nota:");
n2 = double.Parse(Console.ReadLine());

media = (n1 + n2) / 2;

Console.WriteLine($"A média é: {media}");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}
