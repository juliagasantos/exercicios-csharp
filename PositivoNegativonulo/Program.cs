using System.ComponentModel.Design;

var n = 0;

Console.WriteLine("Digite um número: ");
n = int.Parse(Console.ReadLine());

if (n > 0)
{
    Console.WriteLine("O número é positivo!");
}
else if(n < 0)
{
    Console.WriteLine("O número é negativo!");
}
else
{
    Console.WriteLine("O número é zero!");
}