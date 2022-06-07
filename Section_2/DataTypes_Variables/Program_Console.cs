/*
//print hello world in the next line (Line break)-> "\n"
Console.WriteLine("Hello Welcome");

//No new line spaces
Console.Write("hehe");
Console.Write(" world");

Console.ReadKey();

Console.Write("Enter a string an press enter");
string readInput = Console.ReadLine();
Console.WriteLine("You have entered {0}", readInput);

//Returns a ascii version of the text
Console.Write("Enter a string an press enter");
int asciiValue = Console.Read();
Console.WriteLine("ASCII value is {0}", asciiValue);
Console.ReadKey();

*/

/*
Console.WriteLine("Enter any string and press enter");
string text = Console.ReadLine();
Console.WriteLine("You have entered: {0}" , text);

Console.WriteLine("Enter any key and press enter");
int ascii = Console.Read();
Console.WriteLine("ASCII value of the entered value is {0}", ascii);
Console.Beep();
*/

/*
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Green;
//Clears the console terminal
Console.Clear();
Console.WriteLine("REuben was here");
*/


//Class names like ClientActivity
//Class names try to use nouns for the names
//Methods name like CalculateValues
//Method arguments like firstNumber
//local variables lie itemCount
//Dont use numbers at the start of variable names
//Dont use a number at the start of a variable
//Use int, string , bool instad of Int32, Boolean, String

/*
double myDouble = 13.37;
int myInt;

//explicit conversion
//cast double to int
myInt = (int)myDouble;
Console.WriteLine(myInt);

//implicit Conversion
int num = 222212121;
long bigNum = num;

float myFloat = 13.37F;
double myNewDouble = myFloat;

//type conversion
string myString = myNewDouble.ToString(); // "13.37"
string floatString = myFloat.ToString();
Console.WriteLine(floatString);

bool sunIsShining = true;
Console.WriteLine(sunIsShining.ToString());
*/

/*
string myString = "15";
int x = short.Parse(myString) + 1;
Console.WriteLine(x);

string stringForFloat = "0.85"; // datatype should be float
string stringForInt = "12345"; // datatype should be int

float floatVariable = float.Parse(stringForFloat);
int intVariable = int.Parse(stringForInt);
*/

/*
int age = 31;
string name = "Alfonso";

//String concatenation
Console.WriteLine("String concat");
Console.WriteLine("Hello my name is " + name + " I am ...");

//String formatting
Console.WriteLine("String formatting");
Console.WriteLine("Hello my name is {0}, I am {1} ", name, "man");

//String interpolation
Console.WriteLine("String Interpolation");
Console.WriteLine($"Hello my name is {name}, i am {age} years old");

//Verbatim strings
//take the strings as literally what its written, will show \n etc
Console.WriteLine("Verbatim strings");
Console.WriteLine(@"Loren ipsum dolar \n
wfwfs
fsf
sfs

f

sfs
fsfsfsfsfsfsfsfsffssf ff
sfsfsfsfsfsfsfff
sfsfssfsfsfsfsfsfs");
*/

/*
string firstName = "Denis";
string lastName = "Panjuta";
string fullName = string.Concat(" ", lastName, firstName, " ");
Console.WriteLine(fullName);

Console.WriteLine(firstName.Substring(2));
Console.WriteLine(lastName.IndexOf('e'));
string name = "Reuben";
String.Format("My name is {0}", name);
*/

string var;

Console.WriteLine("Please enter your name and press enter");
var = Console.ReadLine();

Console.WriteLine(var.ToUpper());
Console.WriteLine(var.ToLower());
Console.WriteLine(var.Trim());
Console.WriteLine(var.Substring(4));