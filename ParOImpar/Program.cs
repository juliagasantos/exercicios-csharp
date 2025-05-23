var n1 = 0;

Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());

if (n1 % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}