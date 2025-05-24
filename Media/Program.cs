double n1 = 0;
double n2 = 0;
double media = 0;

Console.WriteLine("Digite um número:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número:");
n2 = double.Parse(Console.ReadLine());

media = (n1 + n2) / 2;

Console.WriteLine($"A média é: {media}");
