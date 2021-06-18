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
                Console.WriteLine("Press 4. For Bubble Sort");
                programNumber = Convert.ToInt32(Console.ReadLine());

                switch (programNumber)
                {
                    case 4:
                        BubbleSort B = new BubbleSort();
                        B.ToPrint();
                        Console.WriteLine("After sorting : ");
                        B.Sort();
                        B.ToPrint();
                        break;

                    default:
                        Console.WriteLine("Invalid Input! Please enter a valid choice...");
                        break;
                }
            } while (programNumber <= 0 || programNumber > 4);
        }
    }
}
