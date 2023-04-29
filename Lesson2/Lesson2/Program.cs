// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Xml;
/*
int first = 10;
int second = 5;
int third = first + second;
*/





/*
Console.WriteLine(10/2);
Console.WriteLine(11/2);
Console.WriteLine(12/2);
Console.WriteLine(13/2);
*/
/*
double a = 6.2;
float b = 6.2F;         операции над дробными типами
decimal d = 6.2M;
Console.WriteLine(a/3);
Console.WriteLine(b/3);
Console.WriteLine(a/3);
*/



// мультипликации
/*
int a = 10;
int b = 5;
Console.WriteLine(a * b);
*/




//int first = 1;
//Console.WriteLine(++first);
//Console.WriteLine(first);




/* остатток от деления
int a = 13;
int b = 5;
Console.WriteLine(a / b);
Console.WriteLine(a % b );
*/

//comparison сравнение
/*
int first = 12;
int second = 12;
bool result = first >= second;
bool secondResult = first < second;


Console.WriteLine(first != second);
*/
//Console.WriteLine(result == secondResult); //true == false ==> false
/*
int a = 10;
int b = int.MaxValue;
long l =long.MaxValue;

// unsigned
ulong r =ulong.MaxValue;
short s = short.MaxValue;
short s1=short.MinValue;


Console.WriteLine(b);
Console.WriteLine(l);
Console.WriteLine(r);
Console.WriteLine(s);
Console.WriteLine(s1);
*/

//int a = 1;
//int b = Math.Max(1, 2);
/*
double a = 1.5;

Console.WriteLine("Round:" + Math.Round(a));
Console.WriteLine("Truncate:" + Math.Truncate(a));
Console.WriteLine("Floor:" + Math.Floor(a));
Console.WriteLine("Ceiling" + Math.Ceiling(a));
*/
//Console.WriteLine(b);

//double a = 5.8;
//Console.WriteLine(Math.Pow(a, 2)); // 5 * 5
//double a = 125; //5 * 5 * 5
//Console.WriteLine(Math.Cbrt(a)); //5



/* оператосы со строками
string a = "Hello";
string b = " World";
string c = a + b;
a += b;

Console.WriteLine(c);
Console.WriteLine(a);
*/
//операторы с типами boll
//bool a = false;
//bool b = false;
//bool c = true;


//Console.WriteLine(a && b && c);
/*
bool cash = false;
bool card = false;
bool paypal = true;
Console.WriteLine(cash || card || paypal);
*/

//bool a = true;

//Console.WriteLine(!a);

//int a = 10;
//int b = 10;
//Console.WriteLine(a != b);


//intm long - numbers
// string -text/string
//DateTime
/*
DateTime date = DateTime.Now;
int minute = date.Minute;
int day = date.Day;
int year = date.Year;
Console.WriteLine("Minutes:" + minute );
Console.WriteLine("Days:" + day);
Console.WriteLine("Year:" + year );
*/
/*
DateTime januaryFirst = new DateTime(2023, 1, 1);
DateTime todayFirst =  DateTime.Now.Date;
Console.WriteLine(januaryFirst < todayFirst);
*/




/* -6*x^3+5*x^2-10*x+15
  
 
string a = Console.ReadLine();

int x = Convert.ToInt32(a);

Console.WriteLine( -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15);


string a = Console.ReadLine();

long x = Convert.ToInt32(a);
Console.WriteLine(-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15);
*/




/*
      2*pi*x 

string a = Console.ReadLine();

long x = Convert.ToInt32(a);
double d = Math.PI;

Console.WriteLine(2 * d * x);
*/



//    max(x, y)

/*
string a = Console.ReadLine();

long x = Convert.ToInt32(a);

x = long.MaxValue;
Console.WriteLine(x);

string b = Console.ReadLine();

int y = Convert.ToInt32(b);

y = int.MaxValue;
Console.WriteLine(y);
*/





   // до/после нового гота
/*

Console.WriteLine("До Нового года осталось:");
var today = DateTime.Today;
var newYear = new DateTime(today.Year + 0, 12, 31);
var days = (newYear - today).TotalDays;
Console.WriteLine("{0} дней.", days);
*/
Console.WriteLine("после нового года пошло:");
var today = DateTime.Today;
var oldYear = new DateTime(today.Year - 0, 1, 1);
var days = (today - oldYear).TotalDays;
Console.WriteLine("{0} дней.", days);