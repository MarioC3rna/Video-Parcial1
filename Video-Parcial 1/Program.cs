
Console.WriteLine("Ingrese el primer número entero:");
if (!int.TryParse(Console.ReadLine(), out int numero1))
{
    Console.WriteLine("Numero Invalido en el ingreso del primer numero");
    return;
}

Console.WriteLine("Ingrese el segundo número entero:");
if (!int.TryParse(Console.ReadLine(), out int numero2))
{
    Console.WriteLine("Numero Invalido en el ingreso del segundo numero");
    return;
}

Console.WriteLine("Ingrese el operador matematico (+, -, *, /):");
string operador = Console.ReadLine();

double resultado;

switch (operador)
{
    case "+":
        resultado = numero1 + numero2;
        break;
    case "-":
        resultado = numero1 - numero2;
        break;
    case "*":
        resultado = numero1 * numero2;
        break;
    case "/":
        if (numero2 == 0)
        {
            Console.WriteLine(" No se puede dividir entre cero.");
            return;
        }
        resultado = (double)numero1 / numero2;
        break;
    default:
        Console.WriteLine("Operador inválido.");
        return;
}

Console.WriteLine($"El resultado de los numeros {numero1} {operador} {numero2} es: {resultado}");
