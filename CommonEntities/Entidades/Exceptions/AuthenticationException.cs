using System;
using System.Collections.Generic;
using System.Text;

namespace CommonEntities.Entidades.Exceptions
{
    public class AuthenticationException : Exception 
    {
        public AuthenticationException(string message) : base(message)
        {
        }

        public override string ToString()
        {
            return $"Fallo en autenticación: {Message}";
        }
    }
}
