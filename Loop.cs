using System;

class Loop 
{
    static void Main() 
    {
        /* 
        if else is same as C++ but th code below will not work as C# doesn't convert
        int to bool implicitly and throws error
        
        error CS0029: Cannot implicitly convert type `int' to `bool'
        Compilation failed: 1 error(s), 0 warnings 
        
        It stricty requires true boolean value 
        */

        int x = 20;
        
        // if(x)  // not work
        // {
        //     Console.WriteLine("True");
        // }
        
        if(x != 0)
        {
            Console.WriteLine("True");
        }
        
        
        
        // Switch Case
        
        int value = Convert.ToInt32(Console.ReadLine());
        
        switch (value) 
        {
            case 1: Console.WriteLine("One");
                // break; // If you forget break C# throws a compile error
                break;
            case 2: // We can chain the cases , same as in C++
            case 3: Console.WriteLine("Two or Three"); 
                break;
            default: Console.WriteLine("default");
                break;
        }

    }
}
