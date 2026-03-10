// Student collection
IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };
// string collection
IList<string> stringList = new List<string>() {
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java"
};

#region query syntax 1
{
    // LINQ Query Syntax
    var result = from s in stringList
                 where s.Contains("Tutorials")
                 select s;

    // LINQ Query Syntax to find out teenager students
    var teenAgerStudent = from s in studentList
                          where s.Age > 12 && s.Age < 20
                          select s;
}
#endregion


#region Method  syntax 2
{
    // LINQ Method Syntax
    var result = stringList.Where(s => s.Contains("Tutorials"));

    // LINQ Method Syntax to find out teenager students
    var teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20)
                                      .ToList<Student>();
}
#endregion


#region order by example

var orderByResult = from s in studentList
                    orderby s.StudentName
                    select s;

var orderByDescendingResult = from s in studentList
                              orderby s.StudentName descending
                              select s;


var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);

#endregion

#region all Any

// checks whether all the students are teenagers    
bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);

Console.WriteLine(areAllStudentsTeenAger);


bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);

Console.WriteLine(isAnyStudentTeenAger);

#endregion

#region first/ firstordefault

IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
IList<string> emptyList = new List<string>();

Console.WriteLine("1st Element in intList: {0}", intList.First());
Console.WriteLine("1st Even Element in intList: {0}", intList.First(i => i % 2 == 0));

Console.WriteLine("1st Element in strList: {0}", strList.First());

Console.WriteLine("emptyList.First() throws an InvalidOperationException");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine(emptyList.First());



Console.WriteLine("1st Element in intList: {0}", intList.FirstOrDefault());
Console.WriteLine("1st Even Element in intList: {0}",
                                 intList.FirstOrDefault(i => i % 2 == 0));

Console.WriteLine("1st Element in strList: {0}", strList.FirstOrDefault());

Console.WriteLine("1st Element in emptyList: {0}", emptyList.FirstOrDefault());


Console.WriteLine("Last Element in intList: {0}", intList.Last());

Console.WriteLine("Last Even Element in intList: {0}", intList.Last(i => i % 2 == 0));

Console.WriteLine("Last Element in strList: {0}", strList.Last());

Console.WriteLine("emptyList.Last() throws an InvalidOperationException");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine(emptyList.Last());


Console.WriteLine("Last Element in intList: {0}", intList.LastOrDefault());

Console.WriteLine("Last Even Element in intList: {0}",
                                 intList.LastOrDefault(i => i % 2 == 0));

Console.WriteLine("Last Element in strList: {0}", strList.LastOrDefault());

Console.WriteLine("Last Element in emptyList: {0}", emptyList.LastOrDefault());





Console.WriteLine("The only element in oneElementList: {0}", strList.Single());
Console.WriteLine("The only element in oneElementList: {0}",
             strList.SingleOrDefault());

Console.WriteLine("Element in emptyList: {0}", emptyList.SingleOrDefault());

Console.WriteLine("The only element which is less than 10 in intList: {0}",
             intList.Single(i => i < 10));

//Followings throw an exception
//Console.WriteLine("The only Element in intList: {0}", intList.Single());
//Console.WriteLine("The only Element in intList: {0}", intList.SingleOrDefault());
//Console.WriteLine("The only Element in emptyList: {0}", emptyList.Single());

#endregion


#region skip/take // skip and take are used to apply pagination in linq

{
    IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };

    var newList = strList1.Skip(2);

    foreach (var str in newList)
        Console.WriteLine(str);


    var takeEx = strList.Take(2);

    foreach (var str in takeEx)
        Console.WriteLine(str);
}
#endregion