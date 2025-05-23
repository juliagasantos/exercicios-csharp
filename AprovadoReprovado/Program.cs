var n = 0;

Console.WriteLine("Digite uma nota: ");
n = int.Parse(Console.ReadLine());

if (n >= 7)
{
    Console.WriteLine("Aprovado!");
}
else if (n >= 5)
{
    Console.WriteLine("Recuperação!");
}
else
{
    Console.WriteLine("Reprovado!");
}