using LB1_tprtbor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace LB1_tprtbor
{
    public class Alternative : ICreateAlternatives
    {
        public int[] GenerateRandomAlternative(int cols)
        {
            var selectedAlternative = new int[cols];
            var rnd = new Random();
            for (int i = 0; i < cols; i++)
            {
                selectedAlternative[i] = rnd.Next(1, 4);
            }
            return selectedAlternative;
        }

        public void CompareAlternatives(int[] selectedAlternative, List<int[]> combinations, int cols, TextBox textBox3, TextBox textBox7, TextBox textBox6)
        {
            int betterCount = 0, worseCount = 0, incomparableCount = 0;

            foreach (int[] combination in combinations)
            {
                bool isBetter = true, isWorse = true;

                for (int i = 0; i < cols; i++)
                {
                    if (combination[i] < selectedAlternative[i]) isBetter = false;
                    if (combination[i] > selectedAlternative[i]) isWorse = false;
                }

                if (isBetter) betterCount++;
                else if (isWorse) worseCount++;
                else incomparableCount++;
            }

            textBox3.Text = $"Кращих: {betterCount}";
            textBox7.Text = $"Гірших: {worseCount}";
            textBox6.Text = $"Не порівнянних: {incomparableCount}";
        }

        public void DisplayAlternativeCounts(int cols,int gipCount, int alternativeCount, TextBox textBox5, TextBox textBox4)
        {         
            textBox5.Text = $"Гипотетически всего альтернатив: {gipCount}";
            textBox4.Text = $"Фактически всего альтернатив: {alternativeCount}";
        }
    }
}
