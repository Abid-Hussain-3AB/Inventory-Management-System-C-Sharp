using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DTO
{
    class LogInDTO
    {
        public LogInDTO()
        {

        }
        private String _username;
        private String _password;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }

}
