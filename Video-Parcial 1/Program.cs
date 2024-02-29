int opcion, nfactorial;
double nRaiz, rRaiz;

do
{
    Console.WriteLine("Ingresa el numero de la opcion que desea");
    Console.WriteLine("1. Calcular el factorial de un numero ");
    Console.WriteLine("2. Calcular la raiz cuadrada de un numero ");
    Console.WriteLine("3. Salir ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el numero que desea ");
            nfactorial = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= nfactorial; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("El resultado es: " + factorial);

            break;
        case 2:
            Console.WriteLine("Ingrese el numero que desea");
            nRaiz = double.Parse(Console.ReadLine());
            rRaiz = Math.Sqrt(nRaiz);
            Console.WriteLine("La raiz es: " + rRaiz);
            break;
        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("El número ingresado no esta disponible actualmente.");
            break;


    }

} while (opcion != 3);