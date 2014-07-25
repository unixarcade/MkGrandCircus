using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CommandLine2
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Num of Command Param = {0}", args.Length);
        foreach(string s in args)
        {
            Console.WriteLine(s);
        }
    }
}
