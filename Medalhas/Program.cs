var p = 0;

Console.WriteLine("Digite a posiçãop do atleta: ");
p = int.Parse(Console.ReadLine());

switch (p)
{
    case 1:
        Console.WriteLine("A medalha do atleta é ouro.");
        break;
    case 2:
        Console.WriteLine("A medalha do atleta é prata.");
        break;
    case 3:
        Console.WriteLine("A medalha do atleta é bronze.");
        break;
    default:
        Console.WriteLine("O atleta não ganhou medalha.");
        break;
}
