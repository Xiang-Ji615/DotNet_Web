using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EddyProject_Dao.Model_Login;
using EddyProject_Dao.UserDao;

namespace EddyProject_Bo.UserBo
{
    public class UserBoImp : IUserBo
    {
        private static IUserBo userBoImp = new UserBoImp();

        private UserBoImp()
        {

        }

        public static IUserBo getInstance()
        {
            return userBoImp;
        }

        IUserDao userDao = UserDaoImp.getInstance();
        public User getUser(string username)
        {
            return userDao.getUser(username);
        }

        public List<User> listUser()
        {
            return userDao.listUser();
        }

        public List<User> listUser(int pageNumber, int pageSize)
        {
            return userDao.listUser(pageNumber, pageSize);
        }

        public int getUserSize()
        {
            return userDao.getUserSize();
        }

        public List<User> listUser(int pageNumber, int pageSize, string username, string password)
        {
            return userDao.listUser(pageNumber, pageSize, username, password);
        }

        public int getUserSize(string username, string password)
        {
            return userDao.getUserSize(username, password);
        }
    }
}
