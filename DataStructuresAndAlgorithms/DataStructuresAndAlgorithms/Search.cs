using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    class Search
    {        
        /// <summary>
        /// Method for binary search
        /// </summary>
        /// <param name="array"></param>
        /// <param name="wordToSearch"></param>
        /// <returns></returns>
        public int BinarySearch(string[] array, string wordToSearch)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle].CompareTo(wordToSearch) == 0)
                    return middle;

                if (array[middle].CompareTo(wordToSearch) > 0)
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }
        
        public void PrintArray(string[] array)
        {
            for(int index=0; index < array.Length; index++)
            {
                Console.Write(array[index] + " ");
            }
        }
    }     
}
