using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoBirra
{
    class UtenteMapper
    {
        private string email;
        private string password;

        public UtenteMapper(string email, string password)
        {
            this.email = email;
            this.password = password;
            /// test coommit
        }

        public string getEmail() {
            return email;
        }

        public string getPassword()
        {
            return password;
        }


        public void setEmail(string email) {
            this.email = email;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }


    }
}
