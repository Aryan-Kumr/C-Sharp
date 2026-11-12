using System;
using System.Collections.Generic;   // imports Dictionary

class NamedParameter
{
    static void PrintDetails(string name, int age, string address)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address}");
    }
    
    static void Main(string[] args) 
    {
        string nameInput = "Finn";
        int ageInput = 23;
        string addressInput = "Take left from the river";
        
        PrintDetails(address: addressInput, 
                     age: ageInput, 
                     name: nameInput);
        // In named parameters we can pass arguments out of order.  
    }
}
