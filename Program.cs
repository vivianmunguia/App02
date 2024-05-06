string[] personas = { "Juan Manuel García", "Felipe", "María", "José" };

//Creacion de List
List<string> stringList = new List<string>();

//Agregar data al List desde un array string[]
stringList.AddRange(personas);

//Agregar un elemento a la lista
stringList.Add("Luis");
stringList.Add("Victoria");

//Contar elementos de una lista
Console.WriteLine($"La lista List tiene esta cantidad de items: {stringList.Count}");

//Consultar un elemento de la lista
Console.WriteLine($"Imprime el primer elemento de la lista {stringList[0]}");

//Elimina un elemento de la lista
//stringList.RemoveAt(3);
//stringList.Remove("María");

//Ordenando alfabeticamente la lista
stringList.Sort();

ImprimirLista(stringList);

//Crear metodo para imprimir todos los elementos de la lista
void ImprimirLista(List<string> listaParaImprimir)
{
    foreach (var str in listaParaImprimir)
    {
        Console.WriteLine(str);
    }
}

//Este metodo te permite saber si un elemento existe en la lista
Console.WriteLine($"Existe Felipe en la lista {stringList.Contains("Felipe")}");

//Buscar aquellos nombres en la lista que tengan mas de 10 caracteres
var resultadoExists = stringList.Exists(x => x.Length > 10);

Console.WriteLine($"¿Existe un nombre de mas de 10 caracteres? : {resultadoExists}");

//Buscar un nombre que comience con la letra V
var elementoConV = stringList.Find(x => x.StartsWith("V"));
Console.WriteLine($"El nombre que comienza con la letra V es: {elementoConV}");

//Buscar todos los nombres que comiencen con la letra J
var elementosConJ = stringList.FindAll(x => x.StartsWith("J"));
Console.WriteLine("Esta es la lista de nombres que comienzan con J: ");
ImprimirLista(elementosConJ);