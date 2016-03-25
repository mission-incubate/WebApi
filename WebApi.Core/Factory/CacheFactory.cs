using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Core.Interface;

namespace WebApi.Core.Factory
{
    public class CacheFactory
    {
        public ICache Get<T>() where T : ICache, new()
        {
            return new T();
        }
    }
}
