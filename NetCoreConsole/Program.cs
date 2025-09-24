// See https://aka.ms/new-console-template for more information
using Animales;
using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using FileAccess;

//Forma 1 de declarar y almacenar en una lista
List<Persona> personas = new List<Persona>
{
    new Persona { Id = 1, Nombre = "Berto", Edad = 30 },
    new Persona { Id = 2, Nombre = "Anali", Edad = 25 },
    new Persona { Id = 3, Nombre = "Luis Pedro", Edad = 28 }
};
//Forma 2 de declarar y almacenar en una lista
Persona persona1 = new Persona { Id = 1, Nombre = "Juan Martin", Edad = 30 };
Persona persona2 = new Persona { Id = 2, Nombre = "Ana Luisa", Edad = 25 };
Persona persona3 = new Persona { Id = 3, Nombre = "Luis Miguel", Edad = 28 };
List<Persona> personas1 = new List<Persona> { persona1, persona2, persona3 };
//Forma 3 de declarar y almacenar en una lista
List<Persona> personas2 = new List<Persona>();
personas2.Add(persona1);
personas2.Add(persona2);
personas2.Add(persona3);

IFileManager fileManager = new TextManager();
fileManager.Guardar("personasTexto.txt", personas);

IFileManager xmlManager = new XmlManager();
xmlManager.Guardar("personasXml.xml", personas2);

IFileManager jsonManager = new JsonManager();
jsonManager.Guardar("personasJson.json", personas1);

Console.WriteLine("Archivos guardados !!!!");
Console.ReadLine();
Console.WriteLine("Leyendo archivo personasTexto.txt");
var personasLeidas = fileManager.Leer("personas.txt");
foreach (var persona in personasLeidas)
{
    Console.WriteLine($"Persona {persona.Id} con nombre: {persona.Nombre} de edad {persona.Edad}");
}
Console.WriteLine("Leyendo archivo personasXml.xml");
var personasxml = xmlManager.Leer("personas.xml");
foreach (var persona in personasxml)
{
    Console.WriteLine($"Xml - Persona {persona.Id} con nombre: {persona.Nombre} de edad {persona.Edad}");
}
Console.WriteLine("Leyendo archivo personasJson.txt");
var personasjson = jsonManager.Leer("personasJson.json");
foreach (var persona in personasjson)
{
    Console.WriteLine($" Json - Persona {persona.Id} con nombre: {persona.Nombre} de edad {persona.Edad}");
}
Console.WriteLine("Lectura finalizada !!!!");
Console.ReadLine();
