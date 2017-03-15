using EddyProject_Dao.Model_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyProject_Bo.ViewModel_Login
{
    public class UserViewModel
    {
        private String username;
        private String password;
        private string returnURL;

        public UserViewModel(User user)
        {
            this.username = user.Username;
            this.password = user.Password;
            this.returnURL = user.ReturnURL;
        }

        public UserViewModel()
        {
        }

        public UserViewModel(string username, string password, String returnURL)
        {
            this.username = username;
            this.password = password;
            this.returnURL = returnURL;
        }

        //[StringLength(2, ErrorMessage = "Username can't be longer than 2")]
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
