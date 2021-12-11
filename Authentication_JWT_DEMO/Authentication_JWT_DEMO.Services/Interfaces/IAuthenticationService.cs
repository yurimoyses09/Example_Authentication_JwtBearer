using Authentication_JWT_DEMO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication_JWT_DEMO.Services.Interfaces
{
    public interface IAuthenticationService
    {
        User Authenticate(string name, string password); 
    }
}
