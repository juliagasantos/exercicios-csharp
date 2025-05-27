var n1 = 0;
var n2 = 0;

Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
n2 = int.Parse(Console.ReadLine());
 
do
{
    if (n2 == 0)
    {
        Console.WriteLine("O segundo número não pode ser zero. Digite novamente: ");
        n2 = int.Parse(Console.ReadLine());
    }
} while (n2 == 0);

Console.WriteLine("\n A soma dos números é: " + (n1 + n2) + "\n A subtração dos números é: " + (n1 - n2) + "\n A divisão dos números é: " + (n1 / n2) + "\n A multiplicação dos números é: " + (n1 * n2));