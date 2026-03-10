// Here x, _x, x_x, x_x, x_x_2, studentMarks is identifier

// Here 100 is a constant/literal.

// Here x, _x, x_x, x_x, x_x_2, studentMarks is a variables.



int x = 100;
int _x = 100;
int x_x = 100;
int x_x_2 = 100;
int studentMarks = 100;

//Decimal literals(Base 10)

int decimalLiteral = 101;
// The octal number should be prefix with 0.
int octalLiteral = 0146;

// The hexa-decimal number should be prefix
// with 0X or 0x.
int hexaLiteral = 0X123Face;


// The binary number should be prefix with 0b.
int binaryLiteral = 0b101;



//07778     invalid: 8 is not an octal digit 
//045uu     invalid: suffix (u) is repeated
//0b105     invalid: 5 is not a binary digit
//0b101     valid binary literal
//456       valid decimal literal
//02453     valid octal literal 
//0x65d     valid hexadecimal literal 
//12356     valid int literal 
//304U      valid unsigned int literal 
//3078L     valid long literal 
//965UL     valid unsigned long literal 



//variables


// declaring character
char a = 'G';

// Integer data type is generally
// used for numeric values
int i = 89;

short s = 56;

// this will give error as number
// is larger than short range
// short s1 = 87878787878;

// long uses Integer values which 
// may signed or unsigned
long l = 4564;

// UInt data type is generally
// used for unsigned integer values
uint ui = 95;

ushort us = 76;
// this will give error as number is
// larger than short range

// ulong data type is generally
// used for unsigned integer values
ulong ul = 3624573;

// by default fraction value
// is double in C#
double d = 8.358674532;

// for float use 'f' as suffix
float f = 3.7330645f;

// for float use 'm' as suffix
decimal dec = 389.5m;

Console.WriteLine("char: " + a);
Console.WriteLine("integer: " + i);
Console.WriteLine("short: " + s);
Console.WriteLine("long: " + l);
Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("decimal: " + dec);
Console.WriteLine("Unsinged integer: " + ui);
Console.WriteLine("Unsinged short: " + us);
Console.WriteLine("Unsinged long: " + ul);



// boolean data type
bool b = true;
if (b == true)
    Console.WriteLine("Startup hakk");



string s1 = "hello"; // creating through string keyword  
String s2 = "welcome"; // creating through String class  

