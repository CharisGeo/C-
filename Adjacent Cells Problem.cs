//An algorithm to output the state of the cell after a given number of days
using System;

class Solution
{
    static void findSateOfCells(int[] cell, int day)
    {
        //Create an array with 2 extra cells to represent the empty cells on both ends
        int[] tempArray = new int[cell.Length + 2];

        //Copy the cell array into a new temporary array leaving the value of the first and last indexes as zero
        for (int i = 0; i < cell.Length; i++)
        {
            tempArray[i + 1] = cell[i];
        }

        //Decrement the day count while checking that we are still above zero days
        while (day-- > 0)
        {
            int oldCellValue = 0;

            //Loop through the array ignoring the empty cells at the ends which are always inactive)
            for (int i = 1; i < tempArray.Length - 1; i++)
            {
                if (oldCellValue == tempArray[i + 1])
                {
                    //if the cells next to our current index are the same then the target cell becomes inactive(0)
                    oldCellValue = tempArray[i]; // saving the cells old value so that we can use that to do the next comparison
                    tempArray[i] = 0;
                }
                else
                {
                    //otherwise if they are different then the target cell will be set to active(1)
                    oldCellValue = tempArray[i];
                    tempArray[i] = 1;
                }
            }
        }

        //Create a new output array that doesn't include the empty cells on each end
        int[] outputArray = new int[cell.Length];

        for (int i = 0; i < outputArray.Length; i++)
        {
            outputArray[i] = tempArray[i + 1];
        }

        Console.Write("[");

        for (int i = 0; i < outputArray.Length - 1; i++)
        {
            Console.Write(outputArray[i] + ", ");
        }

        Console.Write(outputArray[outputArray.Length - 1] + "]" + "\n");
    }

    public static void Main()
    {
        int[] arr = { 1, 0, 0, 0, 0, 1, 0, 0 };
        int days = 1;
        findSateOfCells(arr, days);

        int[] arr1 = { 1, 1, 1, 0, 1, 1, 1, 1 };
        int days1 = 2;
        findSateOfCells(arr1, days1);
    }
}
