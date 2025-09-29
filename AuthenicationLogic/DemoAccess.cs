using CommonEntities.Entidades;
using CommonEntities.Entidades.Exceptions;
using CommonEntities.Interfaces;
using System;

namespace AuthenicationLogic
{
    public class DemoAccess : IAuthentication
    {
        public bool Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username))
                throw new AuthenticationException("Por favor ingrese su nombre de usuario.");
            if(string.IsNullOrEmpty(password))
                throw new AuthenticationException("Por favor ingrese su contraseña.");

            if (username == "admin" && password == "password")
                return true;
            return false;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
