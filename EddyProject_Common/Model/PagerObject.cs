using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyProject_Common.Model
{
    public class PagerObject
    {
        bool hasPrevious;
        bool hasNext;
        String previousURL;
        String nextURL;
        List<PagerElement> pageElements;

        public bool HasPrevious
        {
            get
            {
                return hasPrevious;
            }

            set
            {
                hasPrevious = value;
            }
        }

        public bool HasNext
        {
            get
            {
                return hasNext;
            }

            set
            {
                hasNext = value;
            }
        }

        public List<PagerElement> PageElements
        {
            get
            {
                return pageElements;
            }

            set
            {
                pageElements = value;
            }
        }

        public string PreviousURL
        {
            get
            {
                return previousURL;
            }

            set
            {
                previousURL = value;
            }
        }

        public string NextURL
        {
            get
            {
                return nextURL;
            }

            set
            {
                nextURL = value;
            }
        }

        public PagerObject(bool hasPrevious, bool hasNext, List<PagerElement> pageElements)
        {
            this.HasPrevious = hasPrevious;
            this.HasNext = hasNext;
            this.PageElements = pageElements;
        }

        public PagerObject()
        {
        }
    }

    public class PagerElement
    {
        
        string pageNumber;

        PagerElementAttr attr;

        public PagerElement()
        {
        }

        public PagerElement(string pageNumber, PagerElementAttr attr)
        {
            this.pageNumber = pageNumber;
            this.attr = attr;
        }

        public string PageNumber
        {
            get
            {
                return pageNumber;
            }

            set
            {
                pageNumber = value;
            }
        }

        public PagerElementAttr Attr
        {
            get
            {
                return attr;
            }

            set
            {
                attr = value;
            }
        }
    }

    public class PagerElementAttr
    {
        String href;
        bool isActivated;

        public PagerElementAttr(string href, bool isActivated)
        {
            this.Href = href;
            this.IsActivated = isActivated;
        }

        public PagerElementAttr()
        {
        }

        public string Href
        {
            get
            {
                return href;
            }

            set
            {
                href = value;
            }
        }

        public bool IsActivated
        {
            get
            {
                return isActivated;
            }

            set
            {
                isActivated = value;
            }
        }
    }
}
