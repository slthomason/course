Console.WriteLine("You're going to give me 10 numbers");


int number1 = 0;
int number2 = 0;
int number3 = 0;
int number4 = 0;
int number5 = 0;
int number6 = 0;
int number7 = 0;
int number8 = 0;
int number9 = 0;
int number10 = 0;

Console.Write("Enter 1st Number: ");
number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 2nd Number: ");
number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 3rd Number: ");
number3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 4th Number: ");
number4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 5th Number: ");
number5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 6th Number: ");
number6 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 7th Number: ");
number7 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 8th Number: ");
number8 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 9th Number: ");
number9 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter 10th Number: ");
number10 = Convert.ToInt32(Console.ReadLine());


int average  = (number1+number2+number3+number4+number5+number6+number7+number8+number9+number10)/10;
for (int i = 1; i <= average; i ++){
    for(int j = 1; j <= i; j++){
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.ReadLine();