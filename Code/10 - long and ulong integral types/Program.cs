//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        long number1 = -2147483649;
        Console.WriteLine(number1); // prints -2147483649
        Console.WriteLine(number1.GetType()); // prints System.Int64
        Console.WriteLine("\n"); // prints a new line
        
        ulong number2 = 2147483648;
        Console.WriteLine(number2); // prints 2147483648
        Console.WriteLine(number2.GetType()); // prints System.UInt64
    }
}
