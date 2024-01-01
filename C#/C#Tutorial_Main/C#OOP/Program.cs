using System;

/*class Customer
{
    string _fn;
    string _ln;
    public Customer() :this("No First name Provided", "No Last Name Provided")
    { 
    
    }
    public Customer(string FirstName, string LastName) //Constructor
    {
        this._fn = FirstName;
       this. _ln = LastName;
    }
    public void Print()
    {
        Console.WriteLine("FullName = {0}",this._fn+" "+this._ln);

    }
    ~Customer() // distructor
    {
        // Clean up code
    }
} */

/*class Circle
{
   public static float _PI ;// static member not need to this keyword
    int Radius;

     static Circle() 
    {
        Console.WriteLine("Static Constructor");
        Circle._PI = 3.141F;
    }
    public Circle(int Radius)
    {
        Console.WriteLine("Instance Constructor");
        this.Radius = Radius;  
    }
    public float CalculateArea()
    {
        return _PI * this.Radius*this.Radius;
    }
    public static void Print()
    {
        Console.WriteLine("This is static Method!");
    }
}*/
class Program
{
    public static void Main()

    {
        // 19 to 23 

        /*   Customer customer=new Customer("Kamal","Rana"); //customer object,
            customer.Print();
            Customer customer1 = new Customer(); // Constructor Overloading(n umber and type)
            customer1.Print();*/

        /*     Circle c1 = new Circle(5);
             Console.WriteLine("Area is : {0}",c1.CalculateArea());
             Circle c2 = new Circle(6);
             Console.WriteLine("Area is : {0}", c2.CalculateArea());
             Circle.Print();
             Console.WriteLine(Circle._PI);
     */
        /*   FullTimeEmployee FTM= new FullTimeEmployee();
                FTM.FN = "Kamal";
                FTM.LN = "Rana";
                FTM.YearlySalary = 100000;
                FTM.Print();

                PartTimeEmployee PTM = new PartTimeEmployee();
                PTM.FN = "Part";
                PTM.LN = "Time";
                PTM.HourlyRate = 10;
                PTM.Print();*/

        //  ChildClass cc=new ChildClass();

        // Method Hiding --- Method Overriding
        /*   FullTimeEmployee FTE=new FullTimeEmployee();
           FTE.FN = "Full";
           FTE.LN = "Time";
           FTE.Print();



           PartTimeEmployee PTE = new PartTimeEmployee();
           PTE.FN = "Part";
           PTE.LN = "Time";
           PTE.Print();*/

        /* Employee employee = new FullTimeEmployee();
         employee.FN = "kokde";
         employee.LN = "kdok";
         employee.Print();*/
        /*
                Employee employee = new FullTimeEmployee();
                employee.FN = "kokde";
                employee.LN = "kdok";
                employee.Print();*/
        Employee[] employees=new Employee[4];
        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee();
        employees[2] = new FullTimeEmployee();
        employees[3]=new TemporaryEmployee();

        foreach(Employee e in employees)
        {
            e.Print();
        }

       

        Console.ReadLine();
    }
}

//Class  Inheritance
public class Employee
{
    public string FN="FN", LN="LN", Email;
    public virtual void Print()
    {
        Console.WriteLine(FN + " " + LN);
    }

}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
    public override void Print()
    {
        Console.WriteLine(FN + " " + LN+" - Full Time");
    }
}
public class PartTimeEmployee : Employee // Not Support Multiple class Inheritance but in case  interface it is supported.
{
    public float HourlyRate;
    public override void Print()
    {
        Console.WriteLine(FN + " " + LN+" - Part Time");
    }

    /*    public void Print()
       {
           Console.WriteLine(FN + " " + LN+ " - Contractual"); // Override Print Method -- Method Overriding
       }*/
}
public class TemporaryEmployee : Employee
{
/*    public override void Print()
    {
        Console.WriteLine(FN + " " + LN+" -Temporary");
    }*/
}

public class A : PartTimeEmployee
{

}


// Constructor Inheritance
/* public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor Called ");
    }
    public ParentClass(string msg)
    {
        Console.WriteLine(msg);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass(): base("Derived class controlling Parent Class!")
    {

        Console.WriteLine("ChildClass Constructor Called ");
    }
}*/