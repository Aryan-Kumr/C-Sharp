using System;
using System.Threading;   // to use Sleep function

class StringMethods 
{
    static void Main(string[] args) 
    {
        /* 
        It is same as name = ""
        string.Empty represent a string with length 0
        */
        string name = string.Empty;  
        
        
        // string equals function
        /* NOTE: == compares value + memory address location
            .Equals(arg) compares the string literal i.e value
        */ 
        string message = "Hello";
        string compare = "Hello";
        
        if(message.Equals(compare))
        {
            Console.WriteLine("Same");
        }
        else
        {
            Console.WriteLine("Different");
        }
        
        // string iteration looping
        string s = "I am learning C#";
        for(int i = 0; i < s.Length; i++)
        {
            Console.Write(s[i]);
            Thread.Sleep(250);  // delays the execution of thread by 250 ms
        }
        
        // .Contains() check if whether a specific substring or character exists within a string
        // returns bool
        
        Console.WriteLine();
        Console.WriteLine(s.Contains("C"));
        
        /* 
        IsNullOrEmpty function : indicates whether the specified string is empty("") or null
        string m = null; a NULL string
        string = ""; empty string with no value
        If I run any function on null string then I will get null reference exception.
        */
        if(!string.IsNullOrEmpty(s))
        {
            Console.WriteLine("Neither empty or null");
        }
        
    }
}
