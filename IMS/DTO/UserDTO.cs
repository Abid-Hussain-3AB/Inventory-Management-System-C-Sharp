using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DTO
{
    class UserDTO
    {

        private string _userID;
        private string _password;
        private string _name;
        private string _role;
        private string _address;
        private string _phone;

        public string UserID { get => _userID; set => _userID = value; }
        public string Password { get => _password; set => _password = value; }
        public string Name { get => _name; set => _name = value; }
        public string Role { get => _role; set => _role = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}
