var r1 = 0;
var r2 = 0;

Console.WriteLine("Pontuação do primeiro robô: ");
r1 = int.Parse(Console.ReadLine());

Console.WriteLine("Pontuação do segundo robô: ");
r2 = int.Parse(Console.ReadLine());

if (r2 < r1)
{
    Console.WriteLine("O robô com pontuação " + r1 + " venceu o robô com pontuação " + r2);
}
else if (r1 < r2)
{
    Console.WriteLine("O robô com pontuação " + r2 + " venceu o robô com pontuação " + r1);
}
else
{
    Console.WriteLine("Ambos os robôs têm a mesma pontuação.");
}