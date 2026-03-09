using LinqAndCollections;

IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 } 
};

IList<Standard> standardList = new List<Standard>() { 
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};


//Multiple Select and where Operator
var studentNames = studentList.Where(s => s.Age > 18)
                              .Select(s => s)
                              .Where(st => st.StandardID > 0)
                              .Select(s => s.StudentName);





//LINQ Query returns Collection of Anonymous Objects
var teenStudentsName = from s in studentList
                       where s.Age > 12 && s.Age < 20
                       select new { 
                        StudentName = s.StudentName 
                        };

teenStudentsName.ToList().ForEach(s => Console.WriteLine(s.StudentName));



//LINQ GroupBy Query - C#
var studentsGroupByStandard = from s in studentList
                              where s.StandardID > 0
                              group s by s.StandardID into sg
                              orderby sg.Key 
                                    select new { sg.Key, sg };


foreach (var group in studentsGroupByStandard)
{
    Console.WriteLine("StandardID {0}:", group.Key);
    
    group.sg.ToList().ForEach(st => Console.WriteLine(st.StudentName ));
}



// LINQ Left Outer Join - C#
var studentsWithStandard = from stad in standardList
                           join s in studentList
                           on stad.StandardID equals s.StandardID
                           into sg
                               from std_grp in sg 
                               orderby stad.StandardName, std_grp.StudentName 
                               select new { 
                                                StudentName = std_grp.StudentName, 
                                                StandardName = stad.StandardName 
                                };


foreach (var group in studentsWithStandard)
{
    Console.WriteLine("{0} is in {1}", group.StudentName, group.StandardName);
}