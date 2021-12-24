//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        nint number1 = -24548;
        Console.WriteLine(number1); // prints -24548
        Console.WriteLine(number1.GetType()); // prints System.IntPtr
        Console.WriteLine("\n"); // prints a new line
        
        nuint number2 = 75842584;
        Console.WriteLine(number2); // prints 75842584
        Console.WriteLine(number2.GetType()); // prints System.UIntPtr
    }
}
