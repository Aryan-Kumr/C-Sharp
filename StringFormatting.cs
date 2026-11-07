using System;

class StringFormatting
{
    static void Main() 
    {
        double value = 1000D / 12.34D;     // 81.03727714748784
        Console.WriteLine(value);                  
        Console.WriteLine(string.Format("{0:0.00}", value));    // 81.04
        /*{0} represents the first Value : Value
        {0:} colon helps to tell which format I want the value to be(upto hich decimal places
        {0: 0.00} means from the 1st Value 1st number will be displayed and after 2 decimal places will be displayed
        It will round up 
        */
        Console.WriteLine(string.Format("{0:0.0}", value));  // 81.0
        Console.WriteLine(string.Format("{0:0.#}", value)); // 81  
        // # will trim any trailing 0s.
    }
}
