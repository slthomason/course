//Swap two numbers
Console.WriteLine("Swapping Program");
string water = "Water";
string milk = "Milk";

Console.WriteLine($"Water Container contains {water}");
Console.WriteLine($"Milk Container contains {milk}");

string thirdContainer = "";
thirdContainer = water;
water = milk;
milk = thirdContainer;

Console.WriteLine($"Water Container contains {water}");
Console.WriteLine($"Milk Container contains {milk}");



//Check Negative and Positive Numbers
int number = 0;


number = Convert.ToInt32(Console.ReadLine());
if(number < 0){
    Console.WriteLine($"YOUR Provided Number => {number} is Negative");
}
else{
    Console.WriteLine($"YOUR Provided Number => {number} is Positive");
}




//Check if two provided numbers are equal or not
int number1 = 0;
int number2 = 0;

Console.Write("Provide First Number: ");
number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Provide Second Number: ");
number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2){
    Console.Write("Numbers are equal");
}
else{
    Console.Write("Numbers are not equal");
}




//Make it alive
Console.ReadLine();




