var n1 = 0;

Console.WriteLine("Digite um um número: ");
n1 = int.Parse(Console.ReadLine());

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(n1 + " x " + i + " = " + (n1 * i));
}