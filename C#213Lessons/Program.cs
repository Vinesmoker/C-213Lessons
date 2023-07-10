global using static System.Console;
using System.Diagnostics;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
WriteLine("Eter two numbers between 0 and 10 inclusive.\n");
double num1; double num2;
for (; ; ) 
{
    Write("Enter the first number: ");
    Write("Enter the second number: ");
    if (double.TryParse(ReadLine(), out num1) && double.TryParse(ReadLine(), out num2)
        && num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
    {
        break;
    }
    else
    {
        WriteLine("Error! Enter numbers between 0 and 10!");
    }
}
double res = num1 * num2;
WriteLine($"Result is: {res}");
*/
/*
int[,,] arr = { { { 1, 2 }, { 3, 4 } }, { { 4, 5 }, { 6, 7 } }, { { 7, 8 }, { 9, 10 } }, { { 10, 11 }, { 12, 13 } } };
for (int i = 0; i < arr.GetLength(0); i++)
{
    if (i > 0) Write("{");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i % 2 == 1) Write("{");
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Write(arr[i, j, k]);
        }
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            if (i % 2 == 5) { Write("{"); }
        }
        //Write("}");
    }
    //if (i % 2 == 1) Write("}");
}
Write("}");{{{1,2},{3,4}},
{{{4,5},{6,7}},{{7,8},{9,10}},{{10,11},{12,13}}};
*/
/*
 int[,,] arr = { { { 1, 2 }, { 3, 4 } },
    { { 4, 5 }, { 6, 7 } }, { { 7, 8 },
    { 9, 10 } }, { { 10, 11 }, { 12, 13 } } };
string symbol = "{";
for (int i = 0; i < arr.GetLength(0); i++) 
{
    if (i > 0) symbol += ",";
    symbol += "{";
    for (int j = 0; j < arr.GetLength(1); j++) 
    {
        if (j > 0)symbol += ",";
        symbol += "{";
        for (int c = 0; c < arr.GetLength(2); c++) 
        {
            if (c > 0) symbol += ",";
            symbol += arr[i, j ,c];
        }
        symbol += "}";
    }
    symbol += "}";
}
symbol += "}";
WriteLine(symbol);
*/
/*
int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4};
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 0)
    {
        Write($"{numbers[i]} ");
        count++;
    }
}
WriteLine($"\n{count}");

for (int i = numbers.Length; i > 0; i--)Write($"{numbers[i - 1]} ");
WriteLine();
////////////////////////////////
int[] nums = { 54, 7, -41, 2, 4, 2, 99, 22, -9, 15, 35, -40 };
for (int i = 0; i < nums.Length; i++)
{
    for (int j = i; j < nums.Length; j++)
    {
        if (nums[j] > nums[i]) 
        {
            (nums[j], nums[i]) = (nums[i], nums[j]);
        }
    }
Write($"{nums[i]} ");
}
WriteLine();
*/
/*
void Hello() => WriteLine("Hello!");
Hello();
void PrintPerson(string name, int age = 18, string company = "HZ") 
{
    WriteLine($"Name: {name}, age: {age}, company: {company}.");
}
PrintPerson("Ted", 35, "Azure");
PrintPerson("Ted", 35);
PrintPerson("Ted");
PrintPerson("Bred", company: "Azure", age:25);
PrintPerson(company: "Azure", age: 20, name: "Bob");
*/
/*
int Sum(int x, int y) // ==  int Sum (int x, int y) => x + y;
{
    return x + y;
}
string GetMassage() => "Hello!"; // Сокращенный способ для однострочного метода.

void Increment(ref int a)
{
    a++;
    WriteLine($"The number in method increment is: {a}");
}
int a = 5;
WriteLine($"The number before increment is: {a}");
Increment(ref a);
WriteLine($"The number after increment is: {a}");

void Sum1(int x, int y, out int res)
{
    res = x + y;
}
int b;
Sum1(12, 15, out b);
WriteLine(b);

void Perimetr(int a, int b, out double per, out double ar)
{
    ar = a * b;
    per = (a + b) * 2;
}
double perim; double area;
Perimetr(10, 10, out perim, out area);
WriteLine($"{perim}, {area}");
*/
/*
void Sum(int initialValue, params int[] numbers)
{
    int result = initialValue;
    foreach (var n in numbers)
    { 
        result += n;
        WriteLine(result);
    }
}
int[] nums = { 1, 2, 3, 4, 5 };
Sum(10, nums);
Sum(1, 2, 3, 4);
Sum(1, 2, 3);
Sum(20);
*/
/*
int Factorial(int n)
{
    if (n == 0) return 1;
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}
long f = Factorial(15);
int f2 = Factorial(10);
int f3 = Factorial(6);

WriteLine(f);
WriteLine(f2);
WriteLine(f3);
*/
/*
WriteLine("Enter a quantity of Fibonacci: ");
int number = Convert.ToInt32(Console.ReadLine());
//Stopwatch stopwatch = new Stopwatch();
//stopwatch.Start();
//for (int i = 0; i < number; i++) 
//{
//    WriteLine(Fibonacci(i));
//}
//static int Fibonacci(int numbers) 
//{
//    if (numbers == 0) return 0;
//    else if (numbers == 1) return 1;
//    else return Fibonacci(numbers - 1) + Fibonacci(numbers - 2);
//}
//stopwatch.Stop();
//WriteLine("Время исполнения: " + stopwatch.Elapsed);
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
int first = 0;
int second = 1;
WriteLine(first);
for (int i = 0; i < number - 1; i++)
{
    WriteLine(second);
    int temp = first + second;
    first = second;
    second = temp;
}
stopwatch.Stop();
WriteLine("Время исполнения: " + stopwatch.Elapsed);
*/
/*
int Sum(int[] numbers) 
{
    int lim = 0;
    int res = 0;
    foreach (int n in numbers)
        if (IsPassed(n))
            res += n;
    return res;
    bool IsPassed(int number) 
    {
        return ((number > lim) && (number % 2 == 0));
    }
}
int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7 };
int[] numbers2 = { -3, -99, 100, 25, 66, 45, -34 };
WriteLine(Sum(numbers1));
WriteLine(Sum(numbers2));*/
/*
int res = op switch
{
    1 => WriteLine("1"),
    2 => WriteLine("2"),
    3 => WriteLine("3"),
};
*/


namespace ConsoleApp27
{
    internal class Human : Company
    {
        public string name;
        public int age;
        public Company company;
        public Human()
        {
            name = "undefined";
            age = 0;
            company = new Company();
        }
        public void Deconstruct(out string humanName, out int humanAge, out Company humanCompany)
        {
            humanName = name;
            humanAge = age;
            humanCompany = company;
        }
        public void Print() => Write($"Имя: {name} Возраст:{age} Компания: {company.title}");
    }
    class Company
    {
        public string title = "Unknow";
        public override string ToString()
        {
            return title;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human ted = new Human { name = "Ted", age = 34, company = { title = "Azure" } };
            (string name, int age, Company company) = ted;
            WriteLine($"{name} {age} {company}");
            ted.Print();
        }
    }
}
