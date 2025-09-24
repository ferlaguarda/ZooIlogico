namespace CommonEntities.Interfaces
{
    public interface IAuthentication
    {
        bool Login(string username, string password);
        void Logout();
    }
}
