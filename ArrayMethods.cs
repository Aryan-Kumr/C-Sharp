using System;

class ArrayMethods
{
    static void Main(string[] args) 
    {
        // NOTE : Arrays are static data and they are fixed size.
        int[] numbers = new int[] 
        {
            1, 3, 2, 6, 9, 4, 5, 7, 8
        };   // dynamic list
        
        Array.Sort(numbers);     
        
        foreach(int num in numbers)
        {
            Console.Write($"{num} ");
        }
        
        Console.WriteLine();
        
        Array.Reverse(numbers);
        
        foreach(int num in numbers)
        {
            Console.Write($"{num} ");
        }
        
        Console.WriteLine();
        
        /*
        Array.IndexOf(Array array, object value, int startIndex, int count)
        Searches for the specific obj and returns the idx of its 1st
        occurence in a 1D array.
        
        startIndex: from which index I want to search on for the specified element.
        By default it's 0 if not specified.
        
        count : length of array in which I want to search(basically search space).
        
        Return type : int(position of value) if found else -1;
        */
        
        int pos = Array.IndexOf(numbers, 5);
        Console.WriteLine($"Value 5 is found in position: {pos}");
        
        /*
        Array.Clear(Array array, int index, int length)
        Sets a range od elements in an array to the default value of
        each element type.
        index : the starting index of the range of elements to clear.
        */
        
        Array.Clear(numbers, 0, numbers.Length);
        
        /*
        This piece of code works same as Array.Clear();
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = default;
        }
        */
        
        foreach(int num in numbers)
        {
            Console.Write($"{num} ");
        }
        
    }
}
