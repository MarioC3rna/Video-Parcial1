Random random = new Random();
int nSecreto = random.Next(1, 100);
int intentos = 0;

Console.WriteLine("Bienvenido al juego de adivinar un número secreto entre 1 y 100.");

while (true)
{
    Console.Write("Introduce tu suposición: ");
    if (!int.TryParse(Console.ReadLine(), out int nUsuario))
    {
        Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
        continue;
    }

    intentos++;

    if (nUsuario < nSecreto)
    {
        Console.WriteLine("El numero es mayor que tu suposición.");
    }
    else if (nUsuario > nSecreto)
    {
        Console.WriteLine("El numero es menor que tu suposición.");
    }
    else
    {
        Console.WriteLine($"Has adivinado el número {nUsuario}");
        break;
    }
}

