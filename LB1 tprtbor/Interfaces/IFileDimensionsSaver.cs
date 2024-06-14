using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_tprtbor
{
    public interface IFileDimensionsSaver
    {
        void SaveDimensions(int columns, int rows, int gipCount, int alternativeCount);
    }
}
