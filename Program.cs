//Crear un stack collection
Stack<string> miStack = new Stack<string>();

//Insertar elementos al stack
miStack.Push("uno");
miStack.Push("dos");
miStack.Push("tres");
miStack.Push("cuatro");
miStack.Push("cinco");
miStack.Push("seis");

//Imprimir los elementos del stack
foreach (string s in miStack)
{
    Console.WriteLine(s);
}

//Buscar al primero elemento
string miPrimerElemento = miStack.Peek();
Console.WriteLine($"Este es mi primer elemento {miPrimerElemento}");

//Remover eliminar un elemento
string elementoParaEliminar = miStack.Pop();
Console.WriteLine($"Este elemento ha sido eliminado {elementoParaEliminar}");
foreach (string s in miStack)
{
    Console.WriteLine(s);
}

//Buscamos elementos con Contains
var existeElemento = miStack.Contains("tres");
Console.WriteLine($"¿Existe el elemento en la coleccion?: {existeElemento}");