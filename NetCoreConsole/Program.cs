// See https://aka.ms/new-console-template for more information
using Animales;

Animal miAnimal = new Animal("Genérico", TipoAnimal.Indefinido, null,
                "Desconocida", "Desconocida", TipoAlimentacion.Indefinido,
                "Desconocida", "Ninguno");

Mamifero miMamifero = new Mamifero("Leo", 5, "León", "Panthera leo",
    TipoAlimentacion.Carnivoro, "Carne", "Rugido", 110, true);

Console.WriteLine(miMamifero.ToString());

Console.ReadLine();
