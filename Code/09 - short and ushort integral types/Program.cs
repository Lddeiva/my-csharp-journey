//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        short number1 = -736;
        Console.WriteLine(number1); // prints -736
        Console.WriteLine(number1.GetType()); // prints System.Int16
        Console.WriteLine("\n"); // prints a new line
        
        ushort number2 = 8544;
        Console.WriteLine(number2); // prints 8544
        Console.WriteLine(number2.GetType()); // prints System.UInt16
    }
}
