//-------------------------------METODOS----------------------------

//Length

//int[] numbers = { 1, 2, 3, 4, 5 };
//Console.WriteLine("El número de elementos en la matriz es: " + numbers.Length);

//ToUpper

//string original = "hola mundo";
//string mayusculas = original.ToUpper();
//Console.WriteLine(mayusculas);

//Tolower
//string original = "HOLA MUNDO";
//string minusculas = original.ToLower();
//Console.WriteLine(minusculas);

//IndexOF
//string texto = "hola mundo";
//int indice1 = texto.IndexOf('m');
//int indice2 = texto.IndexOf("mundo");
//Console.WriteLine("índice de la primera 'm': " + indice1);
//Console.WriteLine("índice de la primera aparición de 'mundo' " + indice2);

////LastInderxOf 
//string texto = "Hola Mundo Hola";
//int ultimoIndice1 = texto.LastIndexOf('o');
//int ultimoIndice2 = texto.LastIndexOf("Hola");
//Console.WriteLine("Último índice de 'o': " + ultimoIndice1);
//Console.WriteLine("Último índice de 'Hola': " + ultimoIndice2);


//Substring
//string original = "hola mundo";
//string subcadena1 = original.Substring(5);
//string subcadena2 = original.Substring(0, 4);
//Console.WriteLine(original);
//Console.WriteLine(subcadena1);
//Console.WriteLine(subcadena2);


//Replace 
//string original = "Hola Mundo";
//string reemplazo1 = original.Replace('o', '0');
//string reemplazo2 = original.Replace("Mundo", "Universo");
//Console.WriteLine(original);
//Console.WriteLine(reemplazo1);
//Console.WriteLine(reemplazo2);

//StartsWith
//string texto = "Hola Mundo";
//bool resultado1 = texto.StartsWith("Hola");
//bool resultado2 = texto.StartsWith("hola");
//bool reultado3 = texto.StartsWith("hola", StringComparison.OrdinalIgnoreCase);
//Console.WriteLine(texto);
//Console.WriteLine(resultado1);
//Console.WriteLine(resultado2);
//Console.WriteLine(reultado3);


//EndsWith
//string texto = "Hola Mundo";
//bool termina1 = texto.EndsWith("Mundo");
//bool termina2 = texto.EndsWith("mundo");
//bool termina3 = texto.EndsWith("mundo", StringComparison.OrdinalIgnoreCase);
//Console.WriteLine(texto);
//Console.WriteLine(termina1);
//Console.WriteLine(termina2);
//Console.WriteLine(termina3);


//-------------------------------------PROPIEDADES---------------------------------------

//IsReadOnly
//No funciona
//var lista = new List<string> { "a", "b", "c" };
//Console.WriteLine("La lista es de solo lectura: " + lista.IsReadOnly);
//try
//{
//    lista.Add("d");
//    Console.WriteLine("La lista NO es de solo lectura.");
//}
//catch (NotSupportedException)
//{
//    Console.WriteLine("La lista es de solo lectura.");
//}


//Chars
//string cadena = "hola mundo";
//char[] caracteres = cadena.tochararray();
//foreach (char c in caracteres)
//{
//    console.write(c);
//}
//string nuevacadena = new string(caracteres);
//console.writeline("");
//console.writeline(nuevacadena);

//----------------------------------OPERACIONES CON CADENAS---------------------------------------


//Comparacion de cadenas

//string cadena1 = "hola";
//string cadena2 = "adios";
//int resultado = string.Compare(cadena1, cadena2);
//if (resultado < 0)
//{
//    Console.WriteLine("la cadena1 es menor que la cadena2");
//}
//else if (resultado == 0)
//{
//    Console.WriteLine("las cadenas son iguales");
//}
//else
//{
// Console.WriteLine("la cadena1 es mayor que la cadena2");
//}



//Concatenacion de cadenas

//string cadena1 = "hola";
//string cadena2 = "mundo";
//string concatenacion = cadena1 + " " + cadena2;
//Console.WriteLine(concatenacion);

//Busqueda de patrones

//string texto = "El gato está en la casa";
//string patron = "gato";

//if (texto.Contains(patron))
//{
//    Console.WriteLine("Se encontró el patrón 'gato' en el texto.");
//}
//else
//{
//    Console.WriteLine("No se encontró el patrón 'gato' en el texto.");
//}


//Formateo  de Cadenas
//string nombre;
//Console.WriteLine("Ingresesu nombre");
//nombre = Console.ReadLine();
//Console.WriteLine("Ingresesu edad");
//int edad;
//edad = int.Parse(Console.ReadLine());
//string cadena = $"Mi nombre es {nombre} y tengo {edad} años.";
//Console.WriteLine(cadena);