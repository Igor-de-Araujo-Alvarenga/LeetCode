using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionAlgorithms.Algorithms
{
    /// <summary>
    ///  The first algorithm that was presented is Insertion Dort, It is efficient for sorting a small number of elements
    /// </summary>
    public class InsertionSort
    {
        /// <summary>
        ///  Sorts an unsorted integer array - Complexity O(n^2) 
        /// </summary>
        /// <param name="input">A ramdom integer array</param>
        /// <returns>A sorted integer array </returns>
        public int[] Sort(int[] input)
        {
            for(int j = 1; j < input.Length; j++)
            {
                int key = input[j];
                int i = j - 1;
                while( i >= 0 && input[i] > key)
                {
                    input[i + 1] = input[i];
                    i = i - 1;
                }
                input[i + 1] =  key;
            }
            return input;
        }

        public int[] SortDesc(int[] input)
        {
            for (int j = 1; j < input.Length; j++)
            {
                int key = input[j];
                int i = j - 1;
                while (i >= 0 && input[i] < key)
                {
                    input[i + 1] = input[i];
                    i = i - 1;
                }
                input[i + 1] = key;
            }
            return input;
        }
    }
}
