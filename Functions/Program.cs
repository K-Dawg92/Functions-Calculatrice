using System;
using System.Numerics;
using System.Runtime.InteropServices;

static double Add(double numberx, double numbery)
{
    double result1 = numberx + numbery;
    return result1; 
}
static double substract(double numberx, double numbery)
{
    double result1 = numberx - numbery;
    return result1;
}

static double multiply(double numberx, double numbery)
{
    double result1 = numberx * numbery;
    return result1;
}
static double modulo(double numberx, double numbery)

{
    double result1 = (numberx % numbery);
    return result1;

}

static double divide(double numberx, double numbery)
{ 
double result1 = numberx / numbery;
    return result1;
}

Console.WriteLine("Please enter a number with a decimal, young Ronin");

double answer1 = Convert.ToDouble(Console.ReadLine().Replace('.',','));

Console.WriteLine("enter another number with a decimal");

double answer2 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));



Console.WriteLine("enter either +, -,*, / or %");

string Operator = Console.ReadLine();

switch (Operator)
{
    case "+":
      
        Console.WriteLine(Add(answer1, answer2));
        break;

    case "-":
        
        Console.WriteLine(substract(answer1, answer2));
        break;

    case "*":
        
        Console.WriteLine(multiply(answer1, answer2));
        break;
    case "/":
        
        Console.WriteLine(divide(answer1, answer2));
        break;
    case "%":
        modulo(answer1, answer2);
        Console.WriteLine(modulo(answer1, answer2));
        break;

}

