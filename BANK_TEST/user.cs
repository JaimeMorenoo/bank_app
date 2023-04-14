using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_TEST
{
    internal class user
    {
        public string Name { get; set; }   
        public string Surname { get; set; }
        public string Password { get; set; }
        public string email { get; set; }

        public user(string Name, string Surname, string Password, string email)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Password = Password;
            this.email = email;

        }
    }
}
