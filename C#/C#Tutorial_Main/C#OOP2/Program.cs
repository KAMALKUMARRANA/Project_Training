using System;

/*public class BaseClass
{
    public virtual  void Print()
    {
        Console.WriteLine("Base Class Print Method!");
    }
    public virtual void Show()
    {
        Console.WriteLine("Base Class Show Method!");
    }
}
public class DerivedClass:BaseClass
{
    public override void Print()
    {
        Console.WriteLine("Derived Class Print Method!");
    }
    public new void Show() // Hiding Derived class method
    {
        Console.WriteLine("Derived Class Show Method!");
    }
}
*/
public class Program
{

    public static void Main()
    { // From 24 to 25

        /*     BaseClass baseClass = new DerivedClass();
             baseClass.Print();
             baseClass.Show();
             DerivedClass derivedClass = new DerivedClass();
             derivedClass.Show();
             derivedClass.Print();
     */
        Add(10, 20);
        Add(10, 20, 30);
        Add(10.5F, 2.8F);// Function Overloading
        Add(10, 20);

        Console.ReadLine();
    }

    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum={0}", FN + SN);
    }
    public static void Add(float FN, float SN)
    {
        Console.WriteLine("Sum={0}", FN + SN);
    }
    public static void Add(int FN, int SN,int TN)
    {
        Console.WriteLine("Sum={0}", FN + SN+TN);
    }
    public static void Add(int FN, int SN, out int TN)
    {
        Console.WriteLine("Sum={0}", FN + SN );
        TN = FN + SN;
    }
    public static void Add(int FN, int SN, int TN,int FrN=10)
    {
        Console.WriteLine("Sum={0}", FN + SN + TN+FrN);
    }
}