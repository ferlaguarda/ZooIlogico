using CommonEntities.Entidades;
using CommonEntities.Interfaces;
using FileAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;

namespace AuthenicationLogic
{
    public class FileAccess : IAuthentication
    {
        public bool Login(string username, string password)
        {
            UsuarioBO myUser = null;
            if (string.IsNullOrEmpty(username))
                throw new AuthenticationException("Por favor ingrese su nombre de usuario.");
            if (string.IsNullOrEmpty(password))
                throw new AuthenticationException("Por favor ingrese su contraseña.");

            IGenericFileManager<UsuarioBO> jsonManager = new GenericJasonManager<UsuarioBO>();
            List<UsuarioBO> users = jsonManager.Leer("C:\\Temporal\\Progg2\\usuariosBO.json");
            if (users is null || !users.Any())
                return false;

            foreach(UsuarioBO user in users)
            {
                if(user.UserName == username && user.Password == password)
                {
                    user.UltimoAcceso = DateTime.Now;
                    myUser = user;
                    break;
                }
            }
            if(myUser != null)
            {
                jsonManager.Guardar("C:\\Temporal\\Progg2\\usuariosBO.json", users);
                return true;
            }
                
            //UsuarioBO userLamda = users
            //    .Where(u => u.UserName == username && u.Password == password)
            //    .FirstOrDefault();

            //if(userLamda != null)
            //    return true;

            return false;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
