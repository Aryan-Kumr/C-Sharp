using System;
using System.Collections.Generic;   // imports Dictionary

class DictionaryDS
{
    static void Main(string[] args) 
    {
        // keys must be unique and NOT null
        Dictionary<int, string> names = new Dictionary<int, string>();
        names.Add(1, "Timmy");
        names.Add(2, "Finn");
        names.Add(3, "Panda");
        
        // we also initialise like this
        /*
        Dictionary<int, string> names = new Dictionary<int, string>()
        {
            {1, "Timmy"}, {2, "Finn"}, {3, "Panda"}
        };
        */
        
        for(int i = 0; i < names.Count; i++)
        {
            KeyValuePair<int, string> pair = names.ElementAt(i);
            int key = pair.Key;
            string value = pair.Value;
            Console.WriteLine($"{key} - {value}");
        }
        
        Console.WriteLine();
        
        foreach(KeyValuePair<int, string> items in names)
        {
            Console.WriteLine($"{items.Key} - {items.Value}");
        }
        
        Console.WriteLine();
        
        Dictionary<string, string> teachers = new Dictionary<string, string>
        {
            { "Math", "Terance Tao" },
            { "Science", "Test" }
        };
        
        // Console.WriteLine(teachers["Math"]); // if key is not available then it will throw runtime error Key Not found error
        if(teachers.TryGetValue("Math", out string teacher))
        {
            Console.WriteLine(teacher);
        }
        else
        {
            Console.WriteLine("Math teacher not found");
        }
    }
}
