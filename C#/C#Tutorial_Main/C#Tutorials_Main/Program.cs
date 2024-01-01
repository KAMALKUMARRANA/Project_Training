using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;


class Program
{
    public static void Main()
    {
        // kudvenkat tutorials upto 18


        // Nullable Types---- Null Coalescing Operator
        /*int? TicketOnSale =100;
        int AvailableTikets = TicketOnSale ?? 0;
        Console.WriteLine("AvailableTicket={0}", AvailableTikets);*/


        /*float f=123.5898F;
        int i=Convert.ToInt32(f);
        Console.WriteLine(i); // Explicit Conversion
        string s = "100";
        int num=int.Parse(s);
        Console.WriteLine(num);*/

        // Array in C#

        /*int[] enenNumber = new int[3];
        enenNumber[0] =Convert.ToInt32("1");
        enenNumber[1] = 2;
        enenNumber[2] = 3;

        foreach (var item in enenNumber)
        {
            Console.WriteLine(item);

        }*/

        // Switch Cases

        /*Console.WriteLine("Enter a number: ");
        int? num=Convert.ToInt32( Console.ReadLine());
        switch (num)
        {

                case 0:
                case 1:
                case 2:
                Console.WriteLine("Your Case is: {0}", num);
                break;
            case 3:
                Console.WriteLine("case 3");
                break;
                default: Console.WriteLine("not applicable");
                break;
        }*/

        /*int totalCoffeeCost = 0;
        Start:
        Console.WriteLine("1 - small, 2 - Medium , 3 - Large");
        int userChoice=Convert.ToInt32( Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                totalCoffeeCost += 10;
                break;
            case 2:
                totalCoffeeCost += 20;
                break;
            case 3:
                totalCoffeeCost += 30;
                break;
            default:
                Console.WriteLine("Your Choice {0} is invalid",userChoice); break;
        }
        Decide:
        Console.WriteLine("Do You want to bye another coffee- Yes or No?");
        string userDecision=Console.ReadLine();
        switch (userDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Invalid Choice! Please Try Again later.............");
                goto Decide;

        }

        Console.WriteLine("Bill Amount={0}",totalCoffeeCost);*/

        // foreatch
        /*  Program p= new Program();
          p.EvenNumbers(30); // Call instance method using object.
        int sum=  p.Add(10, 20);
          Console.WriteLine("Sum is : {0}",sum); 
          OddNumbers(10);// call static method directly from static main method 
          Program.OddNumbers(20);// starting execution from after 10 because of static*/

        /*        int i = 10;
                SimpleMethod ( ref i); // pass by reference
                Console.WriteLine(i);*/


        /*    int total = 0, product = 0;
            Calculation(10,20,out total,out product);
            Console.WriteLine("Sum={0} && Product = {1}",total,product);*/

        /*   int[] num=new int[3];
           num[0] = 101;
           num[1] = 102;
           num[2] = 103;
           ParamsMethod();
           ParamsMethod(num);
           ParamsMethod(1,3,45,6,7); */

        // Namespace 

        /*   ProjectA.TeamA.ClassA.Print();
             PATA. ClassA.Print();
           ProjectA.TeamB.ClassA.Print(); // avoid ambiguity
           PATB.ClassA.Print();*/

        ProjectA.TeamA.ClassA.Print();
        PATB.ClassA.Print();



        Console.ReadLine();
    }
    /*   public static void ParamsMethod(params int[] Numbers) //  parameter array and parameters are optional , it is pass by last parameter
       {
           Console.WriteLine("There are {0} elements",Numbers.Length);
           foreach (int i in Numbers) Console.WriteLine(i);
       }*/

    /*   public static void Calculation(int fn,int sn,out int x,out int y) // Output Parameters
       {
           x = fn + sn;
           y=fn*sn;
       }
   */
    /*    public static void SimpleMethod(ref int j)
        {
            j = 101;
        }
    */


    /*  public void EvenNumbers(int t) // Instance Method
      {
          int s = 0;
          while (s <= t)
          {
              Console.WriteLine(s);
              s += 2;
          }
      }
      public static void OddNumbers(int t) // static Method
      {
          int s = 1;
          while (s <= t)
          {
              Console.WriteLine(s);
              s += 2;
          }
      }

      public int Add(int fn,int sn)
      {
          return fn+sn;
      }
  */


}

/*namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {

            public static void Print()
            {
                Console.WriteLine("Team A print Method!");
            }


        }
    }
}*/


/*namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {

            public static void Print()
            {
                Console.WriteLine("Team B print Method!");
            }


        }
    }
}*/
