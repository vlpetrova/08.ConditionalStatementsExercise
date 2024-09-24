
//Summer weather can be quite unpredictable, and Victor needs your assistance. Write a program that, based on the time of day and the temperature, recommends to Victor what clothes to wear. Your friend has different plans for each stage of the day that require varied clothing, as indicated in the table.
//Two lines are read from the console:
//•	Temperature - an integer in the range [10... 42]
//•	Text, time of day - with possibilities - "Morning", "Afternoon", "Evening"

int temperature = int.Parse(Console.ReadLine());
string dayTime = Console.ReadLine();
string clothing = "";
string shoes = "";

if (dayTime == "Morning")
{
    if (temperature >= 10 && temperature <= 18)
    {
        clothing = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (temperature > 18 && temperature <= 24)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (temperature >= 25)
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }
}
if (dayTime == "Afternoon")
{
    if (temperature >= 10 && temperature <= 18)
    {
        clothing = "Shirt";
        shoes = "Moccasins";
    }
    else if (temperature > 18 && temperature <= 24)
    {
        clothing = "T-Shirt";
        shoes = "Sandals";
    }
    else if (temperature >= 25)
    {
        clothing = "Swim Suit";
        shoes = "Barefoot";
    }
}
if (dayTime == "Evening")
{
        clothing = "Shirt";
        shoes = "Moccasins";
}
Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");


