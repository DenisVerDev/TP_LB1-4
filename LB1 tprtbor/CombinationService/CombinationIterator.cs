using LB1_tprtbor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_tprtbor
{
    public class CombinationIterator : IIterator<int[]>
    {
        private List<int[]> combinations;
        private int index;

        public CombinationIterator(List<int[]> combinations)
        {
            this.combinations = combinations;
            this.index = 0;
        }

        public bool HasNext()
        {
            return index < combinations.Count;
        }

        public int[] Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No more combinations available");
            }

            int[] nextCombination = combinations[index];
            index++;
            return nextCombination;
        }
    }

}
