using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_tprtbor.Interfaces
{
    public interface ICreateTestFile
    {
        void SaveDimensionsToFile(int columns, int rows, int gipCount, int alternativeCount);
    }
}
