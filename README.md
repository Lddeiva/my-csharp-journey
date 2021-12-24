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
        Console.WriteLine(number1); // throws error CS0165: Use of unassigned local variable 'number1'
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
        Console.WriteLine(number1); // prints 0
    }
}

//Output
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
        Console.WriteLine(number1); // prints 122
        Console.WriteLine(number1.GetType()); // prints System.SByte
        Console.WriteLine("\n"); // prints a new line
        
        byte number2 = 200;
        Console.WriteLine(number2); // prints 200
        Console.WriteLine(number2.GetType()); // prints System.Byte
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
        sbyte number1 = 128; // throws error CS0031: Constant value '128' cannot be converted to a 'sbyte'
        Console.WriteLine(number1);
        Console.WriteLine(number1.GetType());
        Console.WriteLine("\n");
        
        byte number2 = 256; //throws error CS0031: Constant value '256' cannot be converted to a 'byte'
        Console.WriteLine(number2);
        Console.WriteLine(number2.GetType());
    }
}

//Output
error CS0031: Constant value '128' cannot be converted to a 'sbyte'
error CS0031: Constant value '256' cannot be converted to a 'byte'
```

#### 09 - `short` and `ushort` integral types
```C#
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

//Output
-736
System.Int16

8544
System.UInt16
```
##### Characteristics of the `short` and `ushort` integral types
|C# type/keyword|Range|Size|.NET type|
|----------|-----------|----------|-------------|
|`short`|-32,768 to 32,767|Signed 16-bit integer|[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/system.int16)|
|`ushort`|0 to 65,535|Unsigned 16-bit integer|[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/system.uint16)|

#### 10 - `long` and `ulong` integral types
```C#
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

//Output
-2147483649
System.Int64

2147483648
System.UInt64
```

##### Characteristics of the `long` and `ulong` integral types
|C# type/keyword|Range|Size|.NET type|
|----------|-----------|----------|-------------|
|`long`|-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807|Signed 64-bit integer|[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64)|
|`ulong`|0 to 18,446,744,073,709,551,615|Unsigned 64-bit integer|[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64)|


#### 11 - `nint` and `nunit` integral types
```C#
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

//Output
-24548
System.IntPtr

75842584
System.UIntPtr
```

##### Characteristics of the `nint` and `nunit` integral types
|C# type/keyword|Range|Size|.NET type|
|----------|-----------|----------|-------------|
|`nint`|Depends on platform|Signed 32-bit or 64-bit integer|[System.IntPtr](https://docs.microsoft.com/en-us/dotnet/api/system.intptr)|
|`nuint`|Depends on platform|Unsigned 32-bit or 64-bit integer|[System.UIntPtr](https://docs.microsoft.com/en-us/dotnet/api/system.uintptr)|

#### 12 - Min and Max values of `sbyte` and `nunit` integral types
```C#
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

//Output
-128
127

0
18446744073709551615
```
