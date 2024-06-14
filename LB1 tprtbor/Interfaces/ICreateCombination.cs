using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_tprtbor.Interfaces
{
    public interface ICreateCombination
    {
        void GenerateCombinations(int[] prefix, int cols, List<int[]> combinations);
        string[] CreateCombinationString(int value, int cols);
        void DisplayBestAndWorstCombinations(int cols, TextBox textBox1, TextBox textBox2);
    }
}
