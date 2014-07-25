using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DeclareArraySample
{
    public static void Main()
    {

        // Single-dimensional Array
        int[] numbers = new int[5];

        // Multidimensional Array
        string[,] names = new string[5, 4];

        // Array of Arrays jagged array
        byte[][] scores = new byte[5][];

        // Create the jagged array
        for (int i = 0; i< scores.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
        }
    }
}