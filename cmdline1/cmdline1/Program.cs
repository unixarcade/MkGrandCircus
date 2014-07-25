using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CommandLine
{
    public static void Main(string[] args)
    {
        // length property used to obtain length of array
        Console.WriteLine("Number of command line parameters = {0}", args.Length);
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
        }
    }
}
