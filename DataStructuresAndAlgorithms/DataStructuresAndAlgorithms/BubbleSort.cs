using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    class BubbleSort
    {
        public int temp;
        public int[] array = { 12, 25, 9, 34, 21, 17, 29 };

        /// <summary>
        /// Method to sort array
        /// </summary>
        public void Sort()
        {
            for (int i = 0; i < array.Length - 1; i++) // For number of pass 
            {
                for (int j = 0; j < array.Length - 1 - i; j++) // For comparison in each pass
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Method to print array
        /// </summary>
        public void ToPrint()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
