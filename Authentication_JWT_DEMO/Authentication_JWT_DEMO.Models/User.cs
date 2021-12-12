using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication_JWT_DEMO.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int UserId { get; set; }
        
        [JsonProperty("firtname")]
        public string FirstName { get; set; }
        
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        
        [JsonProperty("username")]
        public string UserName { get; set; }
        
        [JsonProperty("password")]
        public string Password { get; set; }
        
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
