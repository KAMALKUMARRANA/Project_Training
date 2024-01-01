using System;

/*interface ICustomer1
{
    void Print1();
    
}
interface ICustomer2:ICustomer1
{
    void Print2();
}
public class Customer : ICustomer1, ICustomer2// Support Multiple interface Implimentation
{
    public void Print1()
    {
        Console.WriteLine("Print1");
    }

    public void Print2()
    {
       Console.WriteLine("Print2");
    }
}*/

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

public class Program:I1,I2
{// from 30 to 31

    public static void Main() 
    { // Interface


   /*   Customer c1= new Customer();
        c1.Print1();
        c1.Print2();


        ICustomer1 c2= new Customer();
        c2.Print1();
       
        ICustomer2 c3= new Customer();
        c3.Print1();
        c3.Print2();*/
        Program program = new Program();
        program.InterfaceMethod();
       ((I1)program).InterfaceMethod();
       ((I2)program).InterfaceMethod(); // Explicitly interface implimentation

        I1 i1 = new Program();
        I2 i2 = new Program();
        i1.InterfaceMethod();
        i2.InterfaceMethod();

        Console.ReadLine();
    }

     void I1.InterfaceMethod() //Explicitly interface implimentation
    {
       Console.WriteLine("I1 interface Method!");
    }
     void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface Method!");
    }
 public void InterfaceMethod()
    {
        Console.WriteLine("interface Method!");
    }
}