using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Interface
{
    public interface ITransportCloneable<T> where T : class
    {
        T BaseClone();
    }
}
