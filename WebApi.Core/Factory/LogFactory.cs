using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Core.Interface;

namespace WebApi.Core.Factory
{
    public class LogFactory
    {
        public static ILogger Get<T>() where T : ILogger, new()
        {
            return new T();
        }
    }
}
