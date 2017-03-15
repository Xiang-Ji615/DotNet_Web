using EddyProject_Common.CommonUtil;
using EddyProject_Common.Model;
using EddyProject_Dao.Model_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyProject_Bo.ViewModel_Curd
{
    [DisplayName("This is CURD View Model")]
    public class CurdViewModel
    {
        [Required]
        List<User> userList;
        [Required]
        Pager pager;
        [Required]
        PagerObject pagerObject;

        public CurdViewModel()
        {
        }

        public CurdViewModel(List<User> userList, Pager pager, PagerObject pagerObject)
        {
            this.userList = userList;
            this.pager = pager;
            this.PagerObject = pagerObject;
        }

        public List<User> UserList
        {
            get
            {
                return userList;
            }

            set
            {
                userList = value;
            }
        }

        public Pager Pager
        {
            get
            {
                return pager;
            }

            set
            {
                pager = value;
            }
        }

        public PagerObject PagerObject
        {
            get
            {
                return pagerObject;
            }

            set
            {
                pagerObject = value;
            }
        }
    }
}
