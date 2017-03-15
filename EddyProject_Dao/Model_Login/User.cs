using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyProject_Dao.Model_Login
{
    public class User
    {

        private String username;
        private String password;
        private String returnURL;

        public User()
        {

        }

        public User(string username, string password, string returnURL)
        {
            this.username = username;
            this.password = password;
            this.returnURL = returnURL;
        }

        [Key]
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string ReturnURL
        {
            get
            {
                return returnURL;
            }

            set
            {
                returnURL = value;
            }
        }
    }
}
