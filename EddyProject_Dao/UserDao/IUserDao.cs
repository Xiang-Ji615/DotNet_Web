using EddyProject_Dao.Model_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyProject_Dao.UserDao
{
    public interface IUserDao
    {
        List<User> listUser();

        List<User> listUser(int pageNumber, int pageSize);

        List<User> listUser(int pageNumber, int pageSize, String username, String password);

        User getUser(String username);

        int getUserSize();

        int getUserSize(String username, String password);
    }
}
