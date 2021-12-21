### :dog2: My C# journey :cat2:

```C#
Tested in dotnet version 6.0.101
```

#### 01 - Hello World
```C#
//Program.cs
using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Hello, World"); // prints Hello, World
    }
}

//Output
Hello, World
```

#### 02 - Print an unassigned integer
```C#
//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        int number1;
        Console.WriteLine(number1); // throws error CS0165
    }
}

//Output
error CS0165: Use of unassigned local variable 'number1'
```

#### 03 - Print the default value of an integer
```C#
//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        int number1 = default(int);
        Console.WriteLine(number1); // prints 0 with warning CS0168
    }
}

//Output
warning CS0168: The variable 'number1' is declared but never used
0
```

#### 04 - Print the value of an integer
```C#
//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        int number1 = 7;
        Console.WriteLine(number1); // prints 7
    }
}

//Output
7
```

#### 05 - Print the sum of two integers
```C#
//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        int number1 = 7, number2 = 8, result;
        Console.WriteLine(number1 + number2); // prints 15
        
        result = number1 + number2;
        Console.WriteLine(result); // prints 15
    }
}

//Output
15
15
```

#### 06 - Print the default run time type of an integer
```C#
//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        int number1 = 7;
        Console.WriteLine(number1.GetType()); // prints System.Int32
    }
}

//Output
System.Int32
```
##### Characteristics of the `int` and `unit` integral types
|C# type/keyword|Range|Size|.NET type|
|----------|-----------|----------|-------------|
|`int`|-2,147,483,648 to 2,147,483,647|Signed 32-bit integer|[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)|
|`uint`|0 to 4,294,967,295|Unsigned 32-bit integer|[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32)|

#### 07 - `sbyte` and `byte` integral types
```csharp
//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        sbyte number1 = 122;
        Console.WriteLine(number1);
        Console.WriteLine(number1.GetType());
        Console.WriteLine("\n");
        
        byte number2 = 200;
        Console.WriteLine(number2);
        Console.WriteLine(number2.GetType());
    }
}

//Output
122
System.SByte


200
System.Byte
```

##### Characteristics of the `sbyte` and `byte` integral types
|C# type/keyword|Range|Size|.NET type|
|----------|-----------|----------|-------------|
|`sbyte`|-128 to 127|Signed 8-bit integer|[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/system.sbyte)|
|`byte`|0 to 255|Unsigned 8-bit integer|[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte)|

#### 08 - Testing the range limits of `sbyte` and `byte`
```csharp
//Program.cs
using System;
class Numbers
{
    static void Main()
    {
        sbyte number1 = 128;
        Console.WriteLine(number1);
        Console.WriteLine(number1.GetType());
        Console.WriteLine("\n");
        
        byte number2 = 256;
        Console.WriteLine(number2);
        Console.WriteLine(number2.GetType());
    }
}

//Output
error CS0031: Constant value '128' cannot be converted to a 'sbyte'
error CS0031: Constant value '256' cannot be converted to a 'byte'
```

