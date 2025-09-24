using CommonEntities.Interfaces;
using System;

namespace AuthenicationLogic
{
    public class DemoAccess : IAuthentication
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
