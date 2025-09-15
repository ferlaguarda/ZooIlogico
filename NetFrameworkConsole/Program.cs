using Animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal miAnimal = new Animal("Genérico", TipoAnimal.Indefinido, null, 
                "Desconocida", "Desconocida", TipoAlimentacion.Indefinido, 
                "Desconocida", "Ninguno");

            Mamifero miMamifero = new Mamifero("Leo", 5, "León", "Panthera leo",
                TipoAlimentacion.Carnivoro, "Carne", "Rugido", 110, true);  

            Console.WriteLine(miMamifero.ToString());
        }
    }
}
