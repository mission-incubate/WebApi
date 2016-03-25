using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Common
{
    public class Response<T> where T : BaseDTO
    {
        public PageContext PageContext { get; set; }
        public List<T> Data { get; set; }
        public Error Error { get; set; }
    }

    public class Error
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
