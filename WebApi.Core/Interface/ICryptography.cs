using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Core.Interface
{
    public interface ICryptography
    {
        string Encrypt(string content);
        string Decrypt(string content);
    }
}
