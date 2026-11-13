using System;
using System.Collections.Generic;   // imports Dictionary

class OutParameter
{
    // static void test(int num)
    // {
    //     num = 5;
    // }   // this will not change the num in main to 5
    
    static bool test(out int num)  // 2 return values from 1 function
    {
        num = 5;
        return true;
    }
    
    static void Main(string[] args) 
    {
        int num = 0;
        bool success = test(out num);
        Console.WriteLine(num);
        Console.WriteLine(success);
    }
}
