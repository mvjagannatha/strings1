using System;
using System.ComponentModel.Design;
class program
{
    static void Main(string[] args)
    {
        string string1 = "jagannatha";
        string string2 = "mvjagannatha";
        if(string.Compare(string1, string2) == 0)
        {
            Console.WriteLine("strings are equal");
            
        }
        else
        {
            Console.WriteLine("strings are not equal");
        }
        Console.ReadKey();
    }
}