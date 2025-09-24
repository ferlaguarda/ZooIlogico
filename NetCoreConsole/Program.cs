// See https://aka.ms/new-console-template for more information
using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using FileAccess;

//Forma 1 de declarar y almacenar en una lista
UsuarioBO usuario = new UsuarioBO("pepito", "Juan", "Fortito", "admin1234", "usuario@gmail.com");
List<UsuarioBO> usuarios = new List<UsuarioBO>();
usuarios.Add(usuario);
IGenericFileManager<UsuarioBO> jsonManager = new GenericJasonManager<UsuarioBO>();
jsonManager.Guardar("usuariosBO.json", usuarios);

//PruebaConAcrchivos();

static void PruebaConAcrchivos()
{
    List<Persona> personas = new List<Persona>
{
    new Persona { Id = 1, Nombre = "Berto", Apellido = "Martinez" ,FechaNacimiento = new DateTime(2001, 06, 17) },
    new Persona { Id = 2, Nombre = "Anali", Apellido = "Martinez" ,FechaNacimiento = new DateTime(2001, 06, 17) },
    new Persona { Id = 3, Nombre = "Luis Pedro", Apellido = "Martinez" ,FechaNacimiento = new DateTime(2001, 06, 17)  }
};
    //Forma 2 de declarar y almacenar en una lista
    Persona persona1 = new Persona { Id = 1, Nombre = "Juan Martin", Apellido = "Martinez", FechaNacimiento = new DateTime(2001, 06, 17) };
    Persona persona2 = new Persona { Id = 2, Nombre = "Ana Luisa", Apellido = "Martinez", FechaNacimiento = new DateTime(2001, 06, 17) };
    Persona persona3 = new Persona { Id = 3, Nombre = "Luis Miguel", Apellido = "Martinez", FechaNacimiento = new DateTime(2001, 06, 17) };
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
    var personasLeidas = fileManager.Leer("personasTexto.txt");
    foreach (var persona in personasLeidas)
    {
        Console.WriteLine($"Persona {persona.Id} con nombre: {persona.Nombre}, {persona.Apellido}");
    }
    Console.WriteLine("Leyendo archivo personasXml.xml");
    var personasxml = xmlManager.Leer("personasXml.xml");
    foreach (var persona in personasxml)
    {
        Console.WriteLine($"Xml - Persona {persona.Id} con nombre: {persona.Nombre},{persona.Apellido}");
    }
    Console.WriteLine("Leyendo archivo personasJson.txt");
    var personasjson = jsonManager.Leer("personasJson.json");
    foreach (var persona in personasjson)
    {
        Console.WriteLine($" Json - Persona {persona.Id} con nombre: {persona.Nombre}, {persona.Apellido}");
    }
    Console.WriteLine("Lectura finalizada !!!!");
    Console.ReadLine();
}