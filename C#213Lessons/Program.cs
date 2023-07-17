global using static System.Console;
using System.Diagnostics;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

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
/*
public struct Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Human(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Human person = new Human();
        person.Name = "1";
        person.Surname = "2";
        person.Age = 25;
        WriteLine("Name: " + person.Name);
        WriteLine("Surname: " + person.Surname);
        WriteLine("Age: " + person.Age);
    }
}
*/
/*
using Base.HumanTypes;
using Base.OrganisationTypes;
Company azure = new("Azure");
Human tom = new("Tom", azure);
tom.Print();
namespace Base
{
    namespace HumanTypes
    {
        class Human
        {
            string name;
            OrganisationTypes.Company company;
            public Human(string name, OrganisationTypes.Company company)
            {
                this.name = name;
                this.company = company;
            }
            public void Print()
            {
                Console.WriteLine($"Имя: {name}");
                company.Print();
            }
        }
    }
    namespace OrganisationTypes
    {
        class Company
        {
            string title;
            public Company(string title) => this.title = title;
            public void Print() => Console.WriteLine($"Название компании: {title}");
        }
    }
}
*/
/*
//Human human = new Human();
//human.Name = "Ted";
//human.Age = 130;
//string humanName = human.Name;
//int humanAge = human.Age;
Human human = new Human("Ted", "Smith", 23);
WriteLine(human.Age);
human.Age = 35;
WriteLine(human.Age);
human.Age = -35;
WriteLine(human.Age);
//string humanName = human.Name;
WriteLine(human.Name);

string status = Human.Pension(human.Age);
WriteLine($"{human.Age} {status}");
human.Age = 65;
string status2 = Human.Pension(human.Age);
WriteLine($"{human.Age} {status2}");
//human.Name = "Ted";
class Human
{
    private string firstName;
    private string lastName;
    private int age;
    public static int pensionAge = 65;
    public Human(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    public static string Pension(int age)
    {
        if (age >= pensionAge) return "Пенсионер!";
        else return $"Не пенсионер! До пенсии осталось {pensionAge - age}!";
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0) WriteLine("Возраст не может быть меньше 0");
            else if (value > 100) WriteLine("Возраст не может быть больше 100");
            else age = value;
        }
    }
    public string Name
    {
        get { return $"{firstName}, {lastName}"; }//get=>$"{firstName}, {lastName}}"
        init 
        {
            firstName = "Undefined";
            lastName = "Undefined";
        }
    }
}
*/
//required -- обязательные поля для заполнения.
/*
Human2 ted = new Human2("Ted", 35);
string json = JsonConvert.SerializeObject(ted);
WriteLine(json);

Human3 ted3 = new Human3("Ted");
//ted3.name = "Ted";
ted3.Print();
WriteLine(Human3.type);


class Calculator 
{
    public void Add(int a, int b) 
    {
        int res = a + b;
        WriteLine(res);
    }
    public void Add(int a, int b, int c) 
    {
        int res = a + b + c;
        WriteLine(res);
    }
    public void Add(double a, double b, double c)
    {
        double res = a + b + c;
        WriteLine(res);
    }
    public void Increment(ref int val)
    {
        val++;
        WriteLine(val);
    }
    public void Increment(int val)
    {
        val++;
        WriteLine(val);
    }
}
/*
WriteLine(Operators.Add(4, 5));
Human1 human1 = new Human1();
human1.Print();
*/
/*
class Human1 
{
    private static int retirementAge;
    static int RetirementAge => retirementAge;
    static Human1()
    {
        if (DateTime.Now.Year == 2020)
            retirementAge = 65;
        else
            retirementAge = 67;
    }
    public void Print() 
    { WriteLine(RetirementAge); }
}
class Human2 
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Human2(string name, int age) 
    {
        Name = name;
        Age = age;
    }
}
class Human3 
{
    public const string type = "Human3";
    public readonly string name = "Undefined";
    public Human3(string name) 
    {
        this.name = name;
    }
    public void Print() => WriteLine($"{type},{name}");
}
readonly struct Human4
{
    public readonly string Name { get; }
    public int Age { get; }
    public Human4(string name, int age) 
    {
        Name = name;
        Age = age;
    }
}
static class Operators 
{
    public static int Add(int x, int y) => x + y;
    public static int Substract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
}
*/

string? name = null;
PrintUpper(name!);
int? val = null;
IsNull(val);
val = 35;
IsNull(val);
PrintNullAble(null);
PrintNullAble(25);

void PrintUpper(string text) 
{
    if (text == null)WriteLine("null");
    else WriteLine(text.ToUpper());
}
void IsNull(int? obj) 
{
    if (obj == null) WriteLine("Null");
    else WriteLine(obj);
}
void PrintNullAble(int? number)
{
    if (number.HasValue) { WriteLine(number.Value); WriteLine(number); }
    else WriteLine("null");
}