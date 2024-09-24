using System;

double firstNum = double.Parse(Console.ReadLine());
double secondNum = double.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();
double result = 0;

switch (mathOperator)
{
    case "+":
        result = firstNum + secondNum;
        Console.WriteLine($"{firstNum} {mathOperator} {secondNum} = {result:f2}");
        break;
    case "-":
        result = firstNum - secondNum;
        Console.WriteLine($"{firstNum} {mathOperator} {secondNum} = {result:f2}");
        break;
    case "*":
        result = firstNum * secondNum;
        Console.WriteLine($"{firstNum} {mathOperator} {secondNum} = {result:f2}");
        break;
    case "/":
        result = firstNum / secondNum;
        Console.WriteLine($"{firstNum} {mathOperator} {secondNum} = {result:f2}");
        break;
}
//if (mathOperator == "+")
//{
//    result = firstNum + secondNum;
//}
//else if (mathOperator == "-")
//{
//    result = firstNum - secondNum;
//}
//else if (mathOperator == "*")
//{
//    result = firstNum * secondNum;
//}
//else if (mathOperator == "/")
//{
//    result = firstNum / secondNum;
//}
//Console.WriteLine($"{firstNum} {mathOperator} {secondNum} = {result:F2}");


