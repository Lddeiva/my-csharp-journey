//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        sbyte number1 = 122;
        Console.WriteLine(number1); // prints 122
        Console.WriteLine(number1.GetType()); // prints System.SByte
        Console.WriteLine("\n"); // prints a new line
        
        byte number2 = 200;
        Console.WriteLine(number2); // prints 200
        Console.WriteLine(number2.GetType()); // prints System.Byte
    }
}
