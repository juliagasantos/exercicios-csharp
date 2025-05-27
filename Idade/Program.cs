var i1 = 0;
var i2 = 0;

Console.WriteLine("Digite a idade do primeiro filho: ");
i1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a idade do segundo filho: ");
i2 = int.Parse(Console.ReadLine());

Console.WriteLine("A idade da Dona Mônica é: " + (i1 + i2 + 1));