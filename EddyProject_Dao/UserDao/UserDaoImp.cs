using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EddyProject_Dao.Model_Login;
using EddyProject_Dao.DataContext;

namespace EddyProject_Dao.UserDao
{
    public class UserDaoImp : IUserDao
    {
        private static UserDaoImp userDaoImp = new UserDaoImp();
        private UserDaoImp()
        {

        }

        public static UserDaoImp getInstance()
        {
            return userDaoImp;
        }
        public User getUser(string username)
        {
            throw new NotImplementedException();
        }

        public int getUserSize()
        {
            int ret;
            using (UserDAL userDal = new UserDAL())
            {
                ret = userDal.users.Count();
            }
            return ret;
        }

        public int getUserSize(string username, string password)
        {
            int ret;
            using (UserDAL userDal = new UserDAL())
            {
                ret = userDal.users.Where(a => (string.IsNullOrEmpty(username) || a.Username.Contains(username))).Count();
            }
            return ret;
        }

        public List<User> listUser()
        {
            List<User> ret;
            using(UserDAL userDal = new UserDAL())
            {
                List<User> users = (from a in userDal.users select a).ToList<User>();
                ret = users;
            }
            return ret;
        }

        public List<User> listUser(int pageNumber, int pageSize)
        {
            List<User> ret;
            var skip = (pageNumber - 1) * pageSize;
            using (UserDAL userDal = new UserDAL())
            {
                List<User> users = (from a in userDal.users select a).OrderBy(a=>a.Username).Skip(skip).Take(pageSize).ToList<User>();
                ret = users;
            }
            return ret;
        }

        public List<User> listUser(int pageNumber, int pageSize, string username, string password)
        {
            List<User> ret;
            var skip = (pageNumber - 1) * pageSize;
            using (UserDAL userDal = new UserDAL())
            {
                List<User> users = (from a in userDal.users select a).Where(a=> (string.IsNullOrEmpty(username) || a.Username.Contains(username)) && (string.IsNullOrEmpty(password) || a.Password.Contains(password))).OrderBy(a => a.Username).Skip(skip).Take(pageSize).ToList<User>();
                ret = users;
            }
            return ret;
        }
    }
}
