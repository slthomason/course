using System.ComponentModel.DataAnnotations;

namespace Contracts
{
    public class AuthenticateRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
