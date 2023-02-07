namespace DotNetWithAuth
{
    public interface IjwtAuthenticationManager
    {
       string Authenticate(string username, string password);
    }
}
