using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_tprtbor.Interfaces
{
    public interface ICreateAlternatives
    {
        int[] GenerateRandomAlternative(int cols);
        void CompareAlternatives(int[] selectedAlternative, List<int[]> combinations, int cols, TextBox textBox3, TextBox textBox7, TextBox textBox6);
        void DisplayAlternativeCounts(int cols, int gipCount, int alternativeCount, TextBox textBox5, TextBox textBox4);
    }
}
