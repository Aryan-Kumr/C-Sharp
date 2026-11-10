using System;

class Lists
{
    static void Main(string[] args) 
    {
        List<int> listNumbers = new List<int>();  // in bracket we can specify the size of the list
        // same as vector<int>, list is a dynamic array
        
        for(int i = 0; i < 5; i++)
        {
            listNumbers.Add(i + 1);
        }
        
        // foreach(var num in listNumbers)
        // {
        //     Console.Write($"{num} ");
        // }
        
        for(int i = 0; i < listNumbers.Count; i++)
        {
            Console.Write($"{listNumbers[i]} ");
        }
    }
}
