using LINQ1;

/*string strName = "pragim";
//Using Extension Method
string result=strName.changeFirstLetterCase();
//string result =StringHelper.changeFirstLetterCase(strName);

Console.WriteLine(result);

int num = 10;
Console.WriteLine( num.PlusNumber(2000));*/
/*
List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
IEnumerable<int> EvenNumbers = Numbers.Where(x => (x % 2 == 0));
//IEnumerable<int> EvenNumbers = Enumerable.Where(Numbers,x => (x % 2 == 0));

foreach (int number in EvenNumbers)
{
    Console.WriteLine(number);
}*/

// Without using LINQ
/*int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int? result = null;
foreach (int i in Numbers)
{
    if (i % 2 == 0)
    {
        if (!result.HasValue || i < result)
        {
            result = i;
        }
    }
  
}
Console.WriteLine(result);
*/

// using LINQ
/*int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int result = Numbers.Where(x=> (x % 2 == 0)).Min();
//int result = Numbers.Where(x => (x % 2 == 0)).Sum();
string[] countries = { "India", "USA", "UK","Canada","Australia" };
int count=countries.Min(c => c.Length);
Console.WriteLine(count);*/

// Aggregate Function 
//string result = countries.Aggregate((a,b)=>a+","+b);
/*int result = Numbers.Aggregate((a,b)=>a*b);
Console.WriteLine(result);*/

//Restriction Operator--->
List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10 };
Func<int,bool>predicate= x=>x%2==0;
IEnumerable<int> EvanNumbers =numbers.Where(predicate);
foreach (int x in EvanNumbers)
{
    Console.WriteLine(x); 
}

Console.ReadLine();
