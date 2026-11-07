using System;

class StringFormat 
{
    static void Main(string[] args) 
    {
        string name = "Timmy";
        int age = 5;
        
        Console.WriteLine("My name is {0}\nMy age is {1}", name, age);
        
        // string interpolation
        Console.WriteLine($"My name is {name} and my age is {age}");
        
        // composite formatting
        Console.WriteLine("My name is {0} and my age is {1}", name, age);
        
        // concatenation
        string concat = string.Concat("My name is ", name, " and my age is ", age);
        Console.WriteLine(concat);
    }
}
