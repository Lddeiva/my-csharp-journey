//Program.cs
using System;
class Numbers
{
    static void Main()
    {

        Console.WriteLine(sbyte.MinValue); // prints -128
        Console.WriteLine(sbyte.MaxValue); // prints 127
        Console.WriteLine("\n"); // prints a new line

        Console.WriteLine(UIntPtr.MinValue); // prints 0
        Console.WriteLine(UIntPtr.MaxValue); // prints 18446744073709551615
    }
}
