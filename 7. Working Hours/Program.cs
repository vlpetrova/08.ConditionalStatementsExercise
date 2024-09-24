//checks if the company's office is open:
//Reads an hour of the day (integer number) and a day of the week (string)
//	The office's working hours are from 10 AM to 6 PM, Monday through Saturday, inclusive.
//	Print "open", if the office is open in the given hour and day of the week
//	Print "closed", if the office is closed in the given hour and day of the week
int hour = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

if (dayOfWeek == "Sunday" || hour < 10 || hour > 18)
{
    Console.WriteLine("closed");
}
else 
{
    Console.WriteLine("open");
}
