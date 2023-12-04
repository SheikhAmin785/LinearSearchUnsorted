using System;

namespace LinearSearchUnsorted
{
    class Program
    {

        public static int Linear(int[] arr, int n, int value)
        {
            for (int i = 0; i < n; i++)
            {
                if (value == arr[i])
                    return i;
            }

            return -1;
        }
    
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
            //which position of n=10
        int n = 10;
          // Function call 
        int result = Linear(arr, arr.Length, n);
        if (result == -1) // result==-1 out of array
            Console.WriteLine("Element is not present in array");
        else
        Console.WriteLine("Element is present at index "+ result);
 }
} 
}

//Time Complexity: O(n)
//Space Complexity: O(1)

