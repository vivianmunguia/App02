string[] canciones =
{
    "Imagine",
    "One",
    "Billie Jean",
    "Hey Jude",
    "God Save The Queen",
    "Born To Run",
    "Creep",
    "Yesterday",
    "My Generation",
    "Respect"
};

//Creando un LinkedList
LinkedList<string> cancionesLinkedList = new LinkedList<string>(canciones);

//Agregando elementos al inicio y al final de la lista
cancionesLinkedList.AddFirst("Mi Primera Cancion");
cancionesLinkedList.AddLast("Mi Ultima Cancion");

//Imprimir elementos de la lista 
foreach(string str in cancionesLinkedList)
{
    Console.WriteLine(str);
}

//Buscando el primer y ultimo elementos de la lista
LinkedListNode<string> primeraCancion = cancionesLinkedList.First!;
LinkedListNode<string> ultimaCancion = cancionesLinkedList.Last!;

Console.WriteLine($"Primera cancion: {primeraCancion.Value}\nUltima cancion: {ultimaCancion.Value}");

//Los elementos pueden ser agregados o removidos dependiendo de un item existente
cancionesLinkedList.AddAfter(primeraCancion, "Mi Segunda Cancion");

Console.WriteLine("Lista de canciones con Mi Segunda Cancion");
foreach (string str in cancionesLinkedList)
{
    Console.WriteLine(str);
}

//Buscar elementos utilizando el metodo Contains
Console.WriteLine($"Buscando la cancion Imagine: {cancionesLinkedList.Contains("Imagine")}");

//Acceder a la data utilizando los metodos siguientes (next) y anterior (previous)
Console.WriteLine($"La cancion que continua despues de la primera cancion: {primeraCancion.Next!.Value}");
Console.WriteLine($"La cancion que anterior la ultima cancion: {ultimaCancion.Previous!.Value}");