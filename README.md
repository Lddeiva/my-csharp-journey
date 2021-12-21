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
