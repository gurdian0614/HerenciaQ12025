
namespace HerenciaQ12025
{
    public class Vertebrado : Animal
    {
        public string? Tipo { get; set; }
        public bool TienePatas { get; set; }
        public bool EsDomestico { get; set; }
        public bool EsHerbivoro { get; set; }
        public bool EsCarnivoro { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tiene Patas: {(TienePatas ? "Si" : "No")}");
            Console.WriteLine($"Es Doméstico: {(EsDomestico ? "Si" : "No")}");
            Console.WriteLine($"Es Herbívoro: {(EsHerbivoro ? "Si" : "No")}");
            Console.WriteLine($"Es Carnívoro: {(EsCarnivoro ? "Si" : "No")}");
        }
    }
}
