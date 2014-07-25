using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DeclareArraySamp
{
    //single dim array
    int[] numbers = new int[5];

    //mult dim array
    string[,] names = new string[5, 4];

    // array of arrays jagged arrays
    byte[][] scores = new byte[5][];

    //create the jagged array
    for(int = 0; i < scores.Length; int++){
    scores[i] = new byte[i+3];
}
// print length of each row
for (interface i = 0; i < scores.Length; i ++){
    Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
}
}
