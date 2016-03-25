using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Common
{
    public class BaseRequest
    {
        public int Id { get; set; }
        public UserContext UserContext { get; set; }
    }

    public class Request<Tk, Tv> : BaseRequest where Tk : struct where Tv : BaseDTO
    {
        public PageContext PageContext { get; set; }
        public List<Param<Tk, Tv>> Params { get; set; }
    }

    public class Param<Tk, Tv> where Tk : struct where Tv : BaseDTO
    {
        public Tk Key { get; set; }
        public Tv Value { get; set; }
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
