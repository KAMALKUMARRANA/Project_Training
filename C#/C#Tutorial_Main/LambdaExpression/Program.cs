using System;
using System.Linq;
public class Program
{
    // Anonymous Method and lambda expression
    public static void Main()
    {
        // from 98 to

        
        List<Employee> listEmployees = new List<Employee>
        {
            new Employee {ID=101,Name="Kamal"},
            new Employee {ID=102,Name="Kumar"},
            new Employee {ID=103,Name="Rana"},

        };
        // step 2
        /*  Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);*/
        //step 3

        /* Employee employee = listEmployees.Find(emp => FindEmployee(emp));*/

        // using Anonymous function
        /* Employee employee = listEmployees.Find(
        delegate (Employee emp)
         {

             return emp.ID == 102;

         });*/


        // Using Lambda Expression
        Employee employee = listEmployees.Find(Emp => Emp.ID == 102);
       // Employee employee = listEmployees.Find((Employee Emp) => Emp.ID == 102);

        if (employee != null)
        {
            Console.WriteLine("Id={0} && Name={1}", employee.ID,  employee.Name);
        }
        else 
        {
            Console.WriteLine("No Employee Found!");
        }

        int count=listEmployees.Count(x=>x.Name.StartsWith("K"));
        Console.WriteLine("Count={0}",count);
      
        
            
        
        Console.ReadLine();
    }
    //step 1
   /* public static bool FindEmployee(Employee employee)
    {
       
        return employee.ID == 102;
    }*/
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
