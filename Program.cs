string[] personas = { "Juan", "Felipe", "María", "José" };

//Creacion de List
List<string> stringList = new List<string>();

//Agregar data al List desde un array string[]
stringList.AddRange(personas);

//Agregar un elemento a la lista
stringList.Add("Luis");
stringList.Add("Victoria");

//Contar elementos de una lista
Console.WriteLine($"La lista List tiene esta cantidad de items: {stringList.Count}");

ImprimirLista(stringList);

//Crear metodo para imprimir todos los elementos de la lista
void ImprimirLista(List<string> listaParaImprimir)
{
    foreach (var str in listaParaImprimir)
    {
        Console.WriteLine(str);
    }
}