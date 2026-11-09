using System;

class Array
{
    static void Main(string[] args) 
    {
        int[] numbers = new int[3];
        int n = numbers.Length;
        
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter a number : ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        // for(int i = 0; i < n; i++)
        // {
        //     Console.Write(numbers[i] + " ");
        // }
        
        // for each loop
        
        foreach(int num in numbers)
        {
            Console.Write($"{num} ");
        }
        
    }
}
