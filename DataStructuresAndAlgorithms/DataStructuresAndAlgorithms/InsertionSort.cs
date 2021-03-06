using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    class InsertionSort
    {
        /// <summary>
        /// Method to sort string
        /// </summary>
        /// <param name="array"></param>
        public void InsSort(string[] array)
        {
            for (int i = 1; i <= array.Length - 1; i++) // Loop for passes
            {
                string key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        /// <summary>
        /// Method to print string array
        /// </summary>
        /// <param name="array"></param>
        public void ToPrint(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
