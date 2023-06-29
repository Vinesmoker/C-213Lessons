global using static System.Console;
using System.ComponentModel;

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


//int[,,] arr = { { { 1, 2 }, { 3, 4 } }, { { 4, 5 }, { 6, 7 } }, { { 7, 8 }, { 9, 10 } }, { { 10, 11 },  { 12, 13 } } };
////Write("{");
//for (int i = 0; i < arr.GetLength(0); i++) 
//{
//    if (i > 0) Write("{");
//    for (int j = 0; j < arr.GetLength(1); j++) 
//    {
//        if (i % 2 == 1)Write("{");
//        for (int k = 0; k < arr.GetLength(2); k++) 
//        {
//            Write(arr[i, j, k]);
//        }
//        for (int l = 0; l < arr.GetLength(1); l++)
//        {
//            if (i % 2 == 5) { Write("{"); }
//        }
//        //Write("}");
//    }
//    //if (i % 2 == 1) Write("}");
//}
////Write("}");{{{1,2},{3,4}},
//              //{{{4,5},{6,7}},{{7,8},{9,10}},{{10,11},{12,13}}};

int[,,] arr = { { { 1, 2 }, { 3, 4 } }, { { 4, 5 }, { 6, 7 } }, { { 7, 8 }, { 9, 10 } }, { { 10, 11 }, { 12, 13 } } };

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
