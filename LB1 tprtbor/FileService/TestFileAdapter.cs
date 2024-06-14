using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_tprtbor
{
    public class TestFileAdapter : IFileDimensionsSaver
    {
        private readonly TestFile testFile;

        public TestFileAdapter(TestFile testFile)
        {
            this.testFile = testFile;
        }

        public void SaveDimensions(int columns, int rows, int gipCount, int alternativeCount)
        {
            // Вызываем метод SaveDimensionsToFile с аргументами, полученными из метода SaveDimensions
            testFile.SaveDimensionsToFile(columns, rows, gipCount, alternativeCount);
        }
    }
}
