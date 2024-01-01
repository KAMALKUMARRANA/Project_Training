using System;
public class Enums
{
    //from 45 to 47
    public static void Main()
    {
        int[] valuse=(int[])(Enum.GetValues(typeof(Gender)));
        foreach(int i in valuse)
        {
            Console.WriteLine(i);
        }
        string[] names=Enum.GetNames(typeof(Gender));
        foreach(var i in names)
        {
            Console.WriteLine(i);
        }
        Gender gender = (Gender)3;
        int num =(int)Gender.Male;

        Gender gen = (Gender)Season.Winter;

        Customer[] customer = new Customer[3];
        customer[0] = new Customer()
        {
            Name = "Test",
            Gender = Gender.Unknown

        }; 
        customer[1] = new Customer()
        {
            Name = "Sam",
            Gender = Gender.Male

        };
              
        customer[2] = new Customer()
        {
            Name = "Marry",
            Gender = Gender.Female

        };
        foreach(var item in customer)
        {
            Console.WriteLine("Name={0} && Gender={1}",item.Name,GetGender(item.Gender));
            
        }
        


        Console.ReadLine();
    }
    #region Switch
    public static string GetGender(Gender gen)
    {
        switch(gen)
        {
            case Gender.Unknown:
                return "Unknown";
                break;
            case Gender.Male:
                return "Male";
                break;
            case Gender.Female:
                return "Female";
                break;
             default: 
                return "Invalid ";
        }
    }
    #endregion
}

public enum Gender //:short -- this is short type
{
    Unknown, //=1
    Male, //=5
    Female //=3
}
public enum Season
{
    Winter,
    Spring,
    Summer
}

//if 0-unknown, 1-male,2-female
public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}