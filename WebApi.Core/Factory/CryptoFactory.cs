using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Core.Interface;

namespace WebApi.Core.Factory
{
    public class CryptoFactory
    {
        public static ICryptography Get<T>() where T : ICryptography, new ()
        {
            return new T();
        }
    }
}
