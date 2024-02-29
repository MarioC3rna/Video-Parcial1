
Console.WriteLine("Tabla de multiplicar");
Console.WriteLine("---Ingresa un numero aqui---");
Console.WriteLine("");

if (!int.TryParse(Console.ReadLine(), out int n1))
{

    Console.WriteLine("Ingrese un numro entero por favor");
    return;
}
Console.WriteLine($"Tabla de multiplicar del {n1}:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n1}x{i}={n1 * i}");
}

