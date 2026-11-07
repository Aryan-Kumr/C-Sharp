using System;

class Verbatim 
{
    static void Main(string[] args) 
    {
        string path = "C:\\Users\\me\\Deskstop\\C#";
        Console.WriteLine("Path is: {0}", path);
        
        path = @"C:\Users\panda\Deskstop\C#";   // it reads everything as string literal
        Console.WriteLine("Verbatim path is: {0}", path);
        /*
        first \ is the escape charater so if we want to show our path in correct format we have to use 
        escape charater so that next \ could be recognised
        
        we use: 
        \t for tab
        \n for newline
        \n for speech mark
        \\ for \
        
        */
        
        string speech = "He said \"something\" peculier";
        Console.WriteLine("Panda said: {0}", speech);
        
        speech = @"He is ""cute""";    // double quoute for speech mark
        Console.WriteLine("Verbatim speech: {0}", speech);
    }
}
