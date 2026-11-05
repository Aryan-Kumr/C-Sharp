using System;  // for Console

namespace DataTypes {
    
    class Program {
      static void Main() {
        int age = 23;
        Console.WriteLine(age);
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
        
        // long bigNumber = 9000000; // if we dont specify that the number assigned is long it will interpret as int32
        long bigNumber = 9000000L; // now this is int64
        Console.WriteLine(bigNumber);
        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);
        
        double negative = -55.2D;
        Console.WriteLine(negative);
        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.MaxValue);
        
        // float precision = 5.00001; // if we dont specify that the number assigned is float it will interpret as double
        float precision = 5.00001F;
        Console.WriteLine(precision);
        Console.WriteLine(float.MinValue);
        Console.WriteLine(float.MaxValue);
        
        // decimal money = 14.99; // if we dont specify that the number assigned is decimal it will interpret as double
        decimal money = 14.99M;
        Console.WriteLine(money);
        Console.WriteLine(decimal.MinValue);
        Console.WriteLine(decimal.MaxValue);
      }
    }
}
