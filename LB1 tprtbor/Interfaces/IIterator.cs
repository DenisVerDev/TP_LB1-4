using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_tprtbor.Interfaces
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
