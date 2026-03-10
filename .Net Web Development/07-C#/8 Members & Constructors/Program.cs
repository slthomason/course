// See https://aka.ms/new-console-template for more information
using _8_members_constructors;

Console.WriteLine("Hello, World!");


// creating the object of the class

Person person = new Person();
Console.WriteLine(person.GetFullName());


//using default constructor
Employee employee = new Employee();
Console.WriteLine(employee.GetFullName());


//using parameterized constructor
Employee employee_2 = new Employee("Talon", "Smith");
Console.WriteLine(employee_2.GetFullName());

// accessing the fields
Console.WriteLine(employee_2.FirstName);
Console.WriteLine(employee_2.LastName);

//using copy constructor
Employee employee_3 = new Employee(employee_2);
Console.WriteLine(employee_2.GetFullName());

Console.ReadLine();