using System;
using System.Collections.Generic;

class Program 
{
    class Sheep
    {
        private string name;
        private int age;
        
        // Auto implemeted properties 
        // To know more: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
        // public string Name { get; set; }
        // public int Age {get; set; }
        
        // Class Properties
        public string Name
        {
            get
            {
                return name;
            }
            
            set
            {
                name = !string.IsNullOrEmpty(value) ? value : "Invalid Name";
            }
        }
        
        public int Age
        {
            get
            {
                return age;
            }
            
            set
            {
                age = (value >= 0 && value <= 150) ? value : -1;
            }
        }
        
        public Sheep() {}
        
        public Sheep(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public string GetDetails()
        {
            return $"Name: {name}, Age: {age}";
        }
        
        public void SetName(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                this.name = name;
            }
            else
            {
                this.name = "Invalid Name";
            }
            
        }
        
        public void SetAge(int age)
        {
            if(age >= 0 && age <= 150)
            {
                this.age = age;
            }
            else
            {
                this.age = -1;
            }
        }
    }
    
    static void Main() {
        
        Sheep s1 = new Sheep("Timmy", 4);
        Sheep s2 = new Sheep();
        
        Console.WriteLine(s1.GetDetails());
        
        s1.SetName("Shaun");
        s1.SetAge(31);
        
        Console.WriteLine($"{s1.GetDetails()}");
        
        s2.Name = "Shirley";
        s2.Age = 21;
        
        Console.WriteLine($"Name: {s2.Name}, Age: {s2.Age}");
    }
}
