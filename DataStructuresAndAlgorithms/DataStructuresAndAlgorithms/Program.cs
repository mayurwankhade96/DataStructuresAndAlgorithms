using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main()
        {
            int programNumber = 0;
            do
            {
                Console.WriteLine("***Welcome to Data Structures and Algorithms Practice Problems!***" + "\n");
                Console.WriteLine("Press 3. For Insertion Sort");
                Console.WriteLine("Press 4. For Bubble Sort");
                programNumber = Convert.ToInt32(Console.ReadLine());

                switch (programNumber)
                {
                    case 3:
                        string[] array = { "Rob", "Mark", "John", "Mary", "Shaun" };
                        InsertionSort I = new InsertionSort();
                        Console.WriteLine("Before Sorting :");
                        I.ToPrint(array);
                        Console.WriteLine("\n" + "After Sorting :");
                        I.InsSort(array);
                        I.ToPrint(array);
                        Console.ReadLine();
                        break;

                    case 4:
                        int[] arr = { 12, 25, 9, 34, 21, 17, 29 };
                        BubbleSort B = new BubbleSort();
                        Console.WriteLine("Before Sorting :");
                        B.ToPrint(arr);
                        Console.WriteLine("\n" + "After sorting : ");
                        B.Sort(arr);
                        B.ToPrint(arr);
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid Input! Please enter a valid choice..." + "\n");
                        break;
                }
            } while (programNumber != 3 && programNumber != 4);
        }
    }
}
