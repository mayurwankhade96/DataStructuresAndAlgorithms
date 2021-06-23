using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    class BubbleSort
    {
        public int temp;        

        /// <summary>
        /// Method to sort array
        /// </summary>
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) // For number of pass 
            {
                for (int j = 0; j < arr.Length - 1 - i; j++) // For comparison in each pass
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Method to print array
        /// </summary>
        public void ToPrint(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
