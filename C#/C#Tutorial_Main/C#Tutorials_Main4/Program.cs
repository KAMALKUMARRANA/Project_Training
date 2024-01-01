using System;
public abstract class Customer
{
    public abstract void Print();
}

public  class Program:Customer
{
    public override void Print()
    {
        Console.WriteLine("Print Method!");
    }

    public static void Main()
    {
        // From 32 to
        Program program = new Program();  
        program.Print();

        Customer c1 = new Program();
        c1.Print();


        Console.ReadLine();
    }
}