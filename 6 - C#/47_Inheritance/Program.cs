// See https://aka.ms/new-console-template for more information
using _9_Inheritance;

Console.WriteLine("Hello, World!");
// Create a myCar object
Car myCar = new Car();

// Call the honk() method (From the Vehicle class) on the myCar object
myCar.honk();

// Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
Console.WriteLine(myCar.brand + " " + myCar.modelName);



// access modifier

var cycyle = new Cycle();
var tri = new Tricycle();
tri.Pedal(); // Pedal method will not be accessible because its protected and only access within the inherited class

Console.ReadLine();