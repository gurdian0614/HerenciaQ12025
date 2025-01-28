using HerenciaQ12025;

Vertebrado vertebrado = new Vertebrado();
Invertebrado invertebrado = new Invertebrado();
int opcion;
string? tienePatas, esDomestico, esHerbivoro, esCarnivoro, tieneConcha;

Console.WriteLine("****************************");
Console.WriteLine("*           MENU           *");
Console.WriteLine("* 1. Animal Vertebrado     *");
Console.WriteLine("* 2. Animal Invertebrado   *");
Console.WriteLine("****************************");
Console.WriteLine("Escoja la opción:");
opcion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch (opcion)
{
    case 1:
        Console.WriteLine("Escriba el nombre:");
        vertebrado.Nombre = Console.ReadLine();

        Console.WriteLine("Escriba el color:");
        vertebrado.Color = Console.ReadLine();

        Console.WriteLine("Escriba el tamaño:");
        vertebrado.Tamano = Console.ReadLine();

        Console.WriteLine("Escriba la Familia:");
        vertebrado.Familia = Console.ReadLine();

        Console.WriteLine("¿Tiene patas? (s/n)");
        tienePatas = Console.ReadLine();

        if (tienePatas.ToLower() == "s")
        {
            vertebrado.TienePatas = true;
        }

        Console.WriteLine("¿Es doméstico? (s/n)");
        esDomestico = Console.ReadLine();

        if (esDomestico.ToLower() == "s")
        {
            vertebrado.EsDomestico = true;
        }

        Console.WriteLine("¿Es herbívoro? (s/n)");
        esHerbivoro = Console.ReadLine();

        if (esHerbivoro.ToLower() == "s")
        {
            vertebrado.EsHerbivoro = true;
        }

        Console.WriteLine("¿Es carnívoro? (s/n)");
        esCarnivoro = Console.ReadLine();

        if (esCarnivoro.ToLower() == "s")
        {
            vertebrado.EsCarnivoro = true;
        }

        vertebrado.Imprimir();
        break;

    case 2:
        Console.WriteLine("Escriba el nombre:");
        invertebrado.Nombre = Console.ReadLine();

        Console.WriteLine("Escriba el color:");
        invertebrado.Color = Console.ReadLine();

        Console.WriteLine("Escriba el tamaño:");
        invertebrado.Tamano = Console.ReadLine();

        Console.WriteLine("Escriba la Familia:");
        invertebrado.Familia = Console.ReadLine();

        Console.WriteLine("Tipo de animal invertebrado:");
        invertebrado.Tipo = Console.ReadLine();

        Console.WriteLine("¿Tiene patas? (s/n)");
        tienePatas = Console.ReadLine();

        if (tienePatas.ToLower() == "s")
        {
            invertebrado.TienePatas = true;

            Console.WriteLine("Número de patas");
            invertebrado.NumeroPatas = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("¿Tiene concha? (s/n)");
        tieneConcha = Console.ReadLine();

        if (tieneConcha.ToLower() == "s")
        {
            invertebrado.TieneConcha = true;
        }

        invertebrado.Imprimir();
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}