using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Common
{
    public class Request
    {
        public PageContext PageContext { get; set; }
        public UserContext UserContext { get; set; }
        public List<Param> Params { get; set; }
    }

    public class Param
    {
        public string Key { get; set; }
        public Object Value { get; set; }
    }

    public class PageContext
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalRecords { get; set; }
    }

    public class UserContext
    {
        public string UserId { get; set; }
    }
}
