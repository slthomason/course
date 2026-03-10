// See https://aka.ms/new-console-template for more information
using _10_encapsulation_abstraction;

Console.WriteLine("Hello, World!");

#region Encapsulation



// creating object
_1_encapsulation obj = new _1_encapsulation();

// calls set accessor of the property Name, 
// and pass "Ankita" as value of the 
// standard field 'value'
obj.Name = "Ankita";

// calls set accessor of the property Age, 
// and pass "21" as value of the 
// standard field 'value'
obj.Age = 21;

// Displaying values of the variables
Console.WriteLine("Name: " + obj.Name);
Console.WriteLine("Age: " + obj.Age);
#endregion 


#region Abstraction

// creating reference of Shape class
// which refer to Square class instance
Shape sh = new Square(4);

// calling the method
double result = sh.area();

Console.Write("{0}", result);

#endregion 

#region interfaces

// creating an instance of Bicycle 
// doing some operations 
Bicycle bicycle = new Bicycle();
bicycle.changeGear(2);
bicycle.speedUp(3);
bicycle.applyBrakes(1);

Console.WriteLine("Bicycle present state :");
bicycle.printStates();

// creating instance of bike.
Bike bike = new Bike();
bike.changeGear(1);
bike.speedUp(4);
bike.applyBrakes(3);

Console.WriteLine("Bike present state :");
bike.printStates();

Console.ReadLine();
#endregion