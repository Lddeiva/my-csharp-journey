//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        sbyte number1 = 128; // throws error CS0031: Constant value '128' cannot be converted to a 'sbyte'
        Console.WriteLine(number1);
        Console.WriteLine(number1.GetType());
        Console.WriteLine("\n");
        
        byte number2 = 256; //throws error CS0031: Constant value '256' cannot be converted to a 'byte'
        Console.WriteLine(number2);
        Console.WriteLine(number2.GetType());
    }
}
