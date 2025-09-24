using CommonEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenicationLogic
{
    public class FileAccess : IAuthentication
    {
        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
