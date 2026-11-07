using System;

namespace String_Chars 
{
    class Convert 
    {
        static void Main(string[] args) 
        {
            string text = "Hello";
            char letter = 'a';
            
            Console.Write(text);   // writes in same line
            Console.WriteLine();
            Console.Write(letter);
            Console.WriteLine();
            
            // converting string to numbers
            
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);
            
            string textBigNumber = "900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);
            
            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);
            
            string textPrecision = "5.000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);
            
            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
            
            
            // bools are same as C++
            
            // operators same as C++
            
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);  // o/p = Ã,  It is Unicorn code values of both 'a' and 'b' and try to add them together as integer
            
            
            
            // var keyword
            
            // var age = 23; // var has to be initiaized when declared to infer the type;
            // var double = 5.2F;
            // var name = "Hello";
            // var ch = 'a'; 
            
            
            // const keyword
            const int val = 20;  // local constant as we no access modifier
            // val = 30;  // can't be reassigned
            
            // Taking input from Console
            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.Write("Enter your age: ");
            // string ageInput = Console.ReadLine();
            // int myAge = Convert.ToInt32(ageInput); 
            // instead of 2 lines we can do this
            
            int myAge = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            
            Console.Write("Your name is " + name + " and your age is " + myAge);
            
            
            
            
            
        }
    }
}
