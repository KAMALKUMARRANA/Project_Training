using System;


public class Program
{
    // from 52 to

    public static void Main()
    {
        List<int> list = new List<int>()
        {
            1, 2, 3,
        };
        Console.WriteLine(Calculator.Add(list));
       /* Calculator.Add(10,20);*/
       Calculator.Add(new List<int>() {10,20,30 });


        Console.ReadLine();
    }
}

public class Calculator
{
    [Obsolete("Use Add(List<int> numbers) Method")]
    public static int Add(int n1,int n2)
    {
      
        return n1+n2;
    }
    public static int Add(List<int> numbers)
    {
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;    
        }
        return sum;
    }
}