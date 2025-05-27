var c1 = 0;
var c2 = 0;

do {
    Console.WriteLine("Digite o número da carta (somente valores entre 1 e 13): ");
    c1 = int.Parse(Console.ReadLine());
} while (c1 < 1 || c1 > 13);


do
{
    Console.WriteLine("Digite o número da outra carta (somente valores entre 1 e 13): ");
    c2 = int.Parse(Console.ReadLine());
} while (c2 < 1 || c2 > 13);


if (c2 < c1)
{
    Console.WriteLine("A carta com o valor " + c1 + ", é maior que a carta com o valor " + c2);
}
else if (c1 < c2)
{
    Console.WriteLine("A carta com o valor " + c2 + ", é maior que a carta com o valor " + c1);
}
else
{
    Console.WriteLine("Ambas as cartas têm o mesmo valor.");
}
