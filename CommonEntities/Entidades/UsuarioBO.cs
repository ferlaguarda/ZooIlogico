using System;

namespace CommonEntities.Entidades
{
    public class UsuarioBO : Persona
    {
        /// <summary>
        /// Es el nombre del usuario registrado en el sistema
        /// </summary>
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? UltimoAcceso { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// Crea una nueva instancia de un objeto UsuarioBo
        /// </summary>
        /// <param name="userName">Nombre de usuarios en le sistema</param>
        /// <param name="nombre">Nombre de pila</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="password">Cpntraseña de acceso</param>
        /// <param name="email">Correo electronico para contacto</param>
        public UsuarioBO(string userName,string nombre, string apellido,string password,
            string email)
        {
            UserName = userName;
            Nombre = nombre;
            Apellido = apellido;
            Password = password;
            Email = email;
            FechaCreacion = DateTime.Now;
            IsActive = true;
        }
        public override string ToString()
        {
            return $"{ Apellido}, { Nombre}";
        }
    }
}
