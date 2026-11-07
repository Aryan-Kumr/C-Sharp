using System;

class TryParseFunc 
{
    static void Main() 
    {
        Console.WriteLine("Enter a number");
        string numInput = Console.ReadLine();
        int num = 0;
        
        bool success = int.TryParse(numInput, out num);
        /*
        expects string as 1st arg and out int result as 2nd arg parameters
        Converts the string representation of a number to its 
        32 bit signed integer equivalent.
        
        return type is bool -> indicates whether the conversion succeeded or not
        result will contain the integer if succeded or 0 if failed
        */
        
        if(success) 
        {
            Console.WriteLine(num);
        }
        else 
        {
            Console.WriteLine("Failed to convert !");
        }
    }
}
