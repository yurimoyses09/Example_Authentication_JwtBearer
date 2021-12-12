using Authentication_JWT_DEMO.Models;

namespace Authentication_JWT_DEMO.Services.Interfaces
{
    public interface IAuthenticationService
    {
        User Authenticate(string name, string password); 
    }
}
