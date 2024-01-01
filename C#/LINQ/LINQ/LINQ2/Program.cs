using LINQ2;

IEnumerable<int> employees=Employee.GetAllEmployees().Where(x=>x.AnnualSalary>=50000).Select(x=>x.EmployeeID).ToList();
foreach (var employee in employees)
{
    Console.WriteLine(employee);
}

var result = Employee.GetAllEmployees().Select(x => new {FirstName=x.FirstName,LastName=x.LastName });
foreach (var employee in result)
{
    Console.WriteLine(employee.FirstName+"-"+employee.LastName);
}

var res = Student.GetAllStudetns().SelectMany(x => x.Subjects);
foreach (var subject in res)
{
    Console.WriteLine(subject);
}
Console.WriteLine("-----------------------------------------------------------------------------------------");
IEnumerable<string>sub=from student in Student.GetAllStudetns()
                       from subject in student.Subjects select subject;
foreach(var s in sub)
{
    Console.WriteLine(s);
}


Console.ReadLine();