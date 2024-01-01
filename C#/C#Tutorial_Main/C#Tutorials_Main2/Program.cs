using System;

//structure
public struct Customer
{
    private int _id;
    private string _name;

    public string Name {  get { return _name;}set { _name = value;} }
    public int Id { get { return _id;}set { _id = value;} }

    public Customer(int id,string name)
    {
        _id = id;
        _name = name;   
    }
    public void PrintDetails()
    {
        Console.WriteLine("ID={0} && Name={1}",_id, _name);
    }
}

public class Program
{ // From 26 to 29
 public static void Main()
{       // Properties // Encapsulation

        Student s1 = new Student();
       /* s1.SetId(101);
        s1.SetName("Kamal");
       // int Id=s1.GetId();
        *//*s1.SetName(null);*//*
        //Console.WriteLine(s1.GetName());
       Console.WriteLine("ID={0} && Name={1} && PassMarks={2}",s1.GetId(),s1.GetName(),s1.GetPassMark());
   */
        //s1.Id = 1;
        /*Console.WriteLine("ID={0} && Name={1} && PassMarks={2}", s1.Id=10,s1.Name="Rahul",s1.PassMarks);
        Console.WriteLine(s1.City );
        Console.WriteLine(s1.Email);*/

        Customer customer = new Customer(10,"Rana");
        customer.PrintDetails();

        Customer customer2 = new Customer();
        customer2.Id = 10;
        customer2.Name = "Kumar";
        customer2.PrintDetails();

        Customer customer3 = new Customer // Object Initialization Syntax // create in stack
        {
            Id = 10,
            Name="Kamal"
            
        };
        customer3.PrintDetails();


        Console.ReadLine();
}
}
public sealed class Student // this class is not inherited because of sealed keyword
{
    private int _Id;
    private string _Name;
    private int _PassMarks = 35;
/*    private string _city;
    private string _email;*/
    public string City{get;set; }
    public string Email { get;set; } // Auto Implement Properties

    /*   public int GetPassMark()
       {
           return this.PassMarks;
       }
       public void SetId(int Id)
       {
           if(Id < 0)
           {
               throw new Exception("Student Id  Cannot be negative");
           }
           else
           {
               this.Id = Id;
           }
       }
       public void SetName(string Name = null)
       {
           if(string.IsNullOrEmpty(Name))
           {
               throw new Exception("Name Cannot be null");
           }
           this.Name = Name;
       }
       public int GetId()
       {
           return this.Id;
       }
       public string GetName()
       {
           return string.IsNullOrEmpty(this.Name)?"No Name":this.Name;
       }*/

    // Properties use Get(read only) and Set(Write Only) accessor
    public int Id
    {
        set { 
        if (value < 0)
        {
            throw new Exception("Student Id  Cannot be negative");
        }
        else
        {
            this._Id = value;
        }
        }
        get
        {
            return this._Id;
        }
    }
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value)) {
                throw new Exception("Name is not empty!");
            }
            this._Name = value;
        }
        get 
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
    }
    public int PassMarks
    {
       get { return this._PassMarks; }
    }

}
