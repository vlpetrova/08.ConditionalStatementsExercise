//Reads 3 real numbers from the console
//Print the sign of the product of the three given numbers: "positive", "negative" or "zero"
//Note: Try to do this without multiplying the numbers.
double firstNum = double.Parse(Console.ReadLine());
double secondNum = double.Parse(Console.ReadLine());
double thirdNum = double.Parse(Console.ReadLine());

if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
{
    Console.WriteLine("zero");
}
else if (firstNum < 0 && secondNum < 0 && thirdNum < 0)
{
    Console.WriteLine("negative");
}
else if (firstNum < 0 && secondNum > 0 && thirdNum > 0)
{
    Console.WriteLine("negative");
}
else if (firstNum > 0 && secondNum < 0 && thirdNum > 0)
{
    Console.WriteLine("negative");
}
else if (firstNum > 0 && secondNum > 0 && thirdNum < 0)
{
    Console.WriteLine("negative");
}
else
{
    Console.WriteLine("positive");
}