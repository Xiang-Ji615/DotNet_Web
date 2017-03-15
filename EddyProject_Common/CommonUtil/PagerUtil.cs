using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EddyProject_Common.Model;

namespace EddyProject_Common.CommonUtil
{
    public class PagerUtil : IPagerUtil
    {
        static IPagerUtil pagerUtil = new PagerUtil();
        private PagerUtil()
        {

        }

        public static IPagerUtil getInstance()
        {
            return pagerUtil;
        }

        public PagerObject getPagerObject(Pager pager, int numberOfLinks, String baseURL)
        {
            PagerObject ret = new PagerObject();
            ret.HasNext = pager.HasNext;
            ret.HasPrevious = pager.HasPrevious;
            List<PagerElement> pagerElements = new List<PagerElement>();
            ret.PreviousURL = baseURL + "&page=" + (pager.CurrentPage - 1);
            ret.NextURL = baseURL + "&page=" + (pager.CurrentPage + 1);
            if (pager.CurrentPage <= numberOfLinks/2)
            {
                for (int i = 1; i <= numberOfLinks; i++)
                {
                    PagerElementAttr attrs = new PagerElementAttr() { IsActivated = i == pager.CurrentPage ? true : false, Href = baseURL + "&page=" + i };
                    pagerElements.Add(new PagerElement() { PageNumber = i.ToString(), Attr = attrs });
                }
            }
            else if (pager.TotalPage - pager.CurrentPage <= numberOfLinks/2)
            {
                for (int i = 1; i <= numberOfLinks; i++)
                {
                    PagerElementAttr attrs = new PagerElementAttr() { IsActivated = pager.TotalPage - numberOfLinks + i == pager.CurrentPage ? true : false, Href = baseURL + "&page=" + (pager.TotalPage - numberOfLinks + i) };
                    pagerElements.Add(new PagerElement() { PageNumber = (pager.TotalPage - numberOfLinks + i).ToString(), Attr = attrs });
                }
            }
            else
            {
                for (int i = 0; i < numberOfLinks; i++)
                {
                    PagerElementAttr attrs = new PagerElementAttr() { IsActivated = pager.CurrentPage- numberOfLinks/2 + i == pager.CurrentPage ? true : false, Href = baseURL + "&page=" + (pager.CurrentPage - numberOfLinks / 2 + i) };
                    pagerElements.Add(new PagerElement() { PageNumber = (pager.CurrentPage - numberOfLinks / 2 + i).ToString(), Attr = attrs });
                }
            }
            ret.PageElements = pagerElements;
            return ret;
        }
    }
}
