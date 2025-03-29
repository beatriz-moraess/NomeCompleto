Console.Clear();

Console.WriteLine("Escreva seu primeiro nome: ");
String nome = Console.ReadLine()!;

Console.WriteLine("Escreva seu sobrenome: ");
String sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");