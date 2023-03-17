// An algorithm to determine the GCD of N positive integers.
using System;

// For an array of elements, we can compute the GCD of all elements by repeatedly taking the GCDs of pairs of numbers.
public class GCD
{
    // Function to return gcd of two positive numbers
    static int findGcd(int a, int b)
    {

        if (a < 0 || b < 0)
        {
            throw new ArgumentException("Cannot compute the GCD if one integer is negative.");
        }

        while (a > 0 && b > 0)
        {
            if (a > b)
            {
                a = a % b;
            }
            else
            {
                b = b % a;
            }
        }
        if (a == 0)
        {
            return b;
        }
        return a;
    }

    // Function to return gcd of all array numbers
    static int findGcdOfArray(int[] arr)
    {
        if (arr.Length < 2)
        {
            throw new ArgumentException("Cannot compute GCD! We have less than two numbers in the array.");
        }

        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result = findGcd(result, arr[i]);
        }

        return result;
    }

    public static void Main()
    {
        int[] arr = { 2, 4, 6, 8, 10};
        Console.Write(findGcdOfArray(arr) + "\n");

        int[] arr1 = { 2, 3, 4, 5, 6 };
        Console.Write(findGcdOfArray(arr1));
    }
}
