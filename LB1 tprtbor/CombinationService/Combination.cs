using LB1_tprtbor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_tprtbor
{
    public class Combination : ICreateCombination
    {
        public string Value {  get; set; }

        public  void GenerateCombinations(int[] prefix,int cols, List<int[]> combinations)
        {
            if (prefix.Length == cols)
            {
                combinations.Add(prefix);
                return;
            }

            for (int i = 1; i <= 3; i++)
            {
                List<int> newPrefix = new List<int>(prefix) { i };
                GenerateCombinations(newPrefix.ToArray(),cols,combinations);
            }
        }

        public  string[] CreateCombinationString(int value,int cols)
        {
            Combination[] combinations = new Combination[cols];
            string[] combination = new string[cols];
            for (int i = 0; i < cols; i++)
            {
                combinations[i] = new Combination();
                combinations[i].Value = $"k{i + 1}{value}";
                combination[i] = combinations[i].Value;
            }
            return combination;
        }

        public void DisplayBestAndWorstCombinations(int cols, TextBox textBox1, TextBox textBox2)
        {
            textBox1.Text = " лучшая - " + string.Join(", ", CreateCombinationString(1, cols));
            textBox2.Text = " худшая - " + string.Join(", ", CreateCombinationString(3, cols));
        }

    }

}
