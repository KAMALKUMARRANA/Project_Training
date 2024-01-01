using System;

public delegate void HelloFunction(string message);

public class Program 
{ 
    // Delegates is a type safe function pointer
   
    public static void Main()
    {// From 36 to
     
        HelloFunction del=new HelloFunction(Hello);
        del("Hello from delegate!");

        Console.ReadLine();
    }
    public static void Hello(string s)
    {
        Console.WriteLine(s);
    }
}