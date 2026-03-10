
using _11_methods;

var calc = new _1_calculator();

int a = 12;
int b = 23;

// Display Result
calc.printSumOf2And2();

// Display Result
Console.WriteLine("The Value of the sum is " + calc.sumOf2And2());

// Display Result
Console.WriteLine("The Value of the sum is " + calc.Sum(a, b));


// Display Result
Console.WriteLine("The Value of the sum is " + calc.Sum(a, b, 45));


var paramsExample = new _2_parameters();
// calling the method with named 
// parameters without any order
paramsExample.addstr(s3: "Hakk", s1: "Start", s2: "up");


// Assigning value
string val = "Dog";

// Pass as a reference parameter
paramsExample.CompareValue(ref val);

// Display the given value
Console.WriteLine(val);



// Creating variable
// without assigning value
int num;

// Pass variable num to the method
// using out keyword
paramsExample.AddNum(out num);

// Display the value of num
Console.WriteLine("The sum of"
  + " the value is: {0}", num);




// Calling the detail method 
paramsExample.detail("XYZ", 123);
paramsExample.detail("ABC", 456, "B-");
paramsExample.detail("DEF", 789, "B+",
   "Software Developer");



// Calling mulval method
int x = paramsExample.mulval(20, 49, 56, 69, 78);

// show result
Console.WriteLine(x);


#region overriding  


////Example 1: Method Overriding without using virtual and override modifiers

// 'obj' is the object of
// class 'baseClass'
baseClass obj = new baseClass();


// invokes the method 'show()'
// of class 'baseClass'
obj.show();

obj = new derived();

// it also invokes the method
// 'show()' of class 'baseClass'
obj.show();


//Example 2: Method overriding using virtual and override modifiers.


baseClassWithVirtual objVirtual;

// 'obj' is the object
// of class 'baseClass'
objVirtual = new baseClassWithVirtual();

// it invokes 'show()'
// of class 'baseClass'
objVirtual.show();


// the same object 'obj' is now
// the object of class 'derived'
objVirtual = new derivedWithOveride();

// it invokes 'show()' of class 'derived'
// 'show()' of class 'derived' is overridden
// for 'override' modifier
objVirtual.show();

#endregion