using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddyProject_Common.CommonUtil
{
    public class Pager
    {
        private int currentPage;
        private int pageSize;
        private int totalSize;
        private int totalPage;
        private bool hasFirst;
        private bool hasPrevious;
        private bool hasNext;
        private bool hasLast;

        public Pager(int currentPage, int pageSize, int totalSize)
        {
            this.currentPage = currentPage;
            this.totalSize = totalSize;
            this.pageSize = pageSize;
        }

        public int CurrentPage
        {
            get
            {
                return currentPage;
            }

            set
            {
                currentPage = value;
            }
        }

        public int PageSize
        {
            get
            {
                return pageSize;
            }

            set
            {
                pageSize = value;
            }
        }

        public int TotalSize
        {
            get
            {
                return totalSize;
            }

            set
            {
                totalSize = value;
            }
        }


        public int TotalPage
        {
            get
            {
                totalPage = totalSize / pageSize;
                if (totalSize % pageSize != 0)
                    totalPage++;
                return totalPage;
            }
            set
            {
                this.totalPage = value;
            }
        }
        public bool HasFirst
        {
            get
            {
                if (currentPage == 1)
                {
                    return false;
                }
                return true;
            }
            set
            {
                this.hasFirst = value;
            }
        }
        public bool HasPrevious
        {
            get
            {
                if (HasFirst)
                    return true;
                else
                    return false;
            }
            set
            {
                this.hasPrevious = value;
            }
        }

        public bool HasNext
        {
            get
            {
                if (HasLast)
                    return true;
                else
                    return false;
            }
            set
            {
                this.hasNext = value;
            }
        }

        public bool HasLast
        {
            get
            {
                if (currentPage == TotalPage)
                    return false;
                else
                    return true;
            }
            set
            {
                this.hasLast = value;
            }
        }
    }
}
