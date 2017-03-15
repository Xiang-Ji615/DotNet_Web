using EddyProject_Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyProject_Common.CommonUtil
{
    public interface IPagerUtil
    {
        PagerObject getPagerObject(Pager pager, int numberOfLinks, String baseURL);
    }
}
