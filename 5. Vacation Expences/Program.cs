
//calculates vacation expenses:
//	From the console read: season(string), accommodation type(string) and count of the days (integer)
//	Season will be one of the following: "Spring", "Summer", "Autumn" and "Winter"
//	Accommodation type will be one of the following: "Hotel" and "Camping
//	Based on the table below, you have to calculate expenses for the vacation with the given accommodation type, season and count of the days. 
//	For the calculation: use price per night (extracted from the table below) multiplied by count of the days.
//	Print the total expenses, formatted to the second digit after the decimal point
string season = Console.ReadLine();
string accommodation = Console.ReadLine();
int totalDays = int.Parse(Console.ReadLine());
double expences = 0;
double finalSum = 0;

if (season == "Spring")
{
    if (accommodation == "Hotel")
    {
        expences = totalDays * 30;
        finalSum = expences - (expences * 0.20);
        Console.WriteLine($"{finalSum:F2}");
    }
    else if (accommodation == "Camping")
    {
        expences = totalDays * 10;
        finalSum = expences - (expences * 0.20);
        Console.WriteLine($"{finalSum:F2}");
    }
}
if (season == "Summer")
{
    if (accommodation == "Hotel")
    {
        expences = totalDays * 50;
        finalSum = expences;
        Console.WriteLine($"{finalSum:F2}");
    }
    else if (accommodation == "Camping")
    {
        expences = totalDays * 30;
        finalSum = expences;
        Console.WriteLine($"{finalSum:F2}");
    }
}
if (season == "Autumn")
{
    if (accommodation == "Hotel")
    {
        expences = totalDays * 20;
        finalSum = expences - (expences * 0.30);
        Console.WriteLine($"{finalSum:F2}");
    }
    else if (accommodation == "Camping")
    {
        expences = totalDays * 15;
        finalSum = expences - (expences * 0.30);
        Console.WriteLine($"{finalSum:F2}");
    }
}
if (season == "Winter")
{
    if (accommodation == "Hotel")
    {
        expences = totalDays * 40;
        finalSum = expences - (expences * 0.10);
        Console.WriteLine($"{finalSum:F2}");
    }
    else if (accommodation == "Camping")
    {
        expences = totalDays * 10;
        finalSum = expences - (expences * 0.10);
        Console.WriteLine($"{finalSum:F2}");
    }
}


