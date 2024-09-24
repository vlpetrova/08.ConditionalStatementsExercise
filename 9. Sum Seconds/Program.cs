int firstAthlet = int.Parse(Console.ReadLine());
int secondAthlet = int.Parse(Console.ReadLine());
int thirdAthlet = int.Parse(Console.ReadLine());

int totalTimeSec = firstAthlet + secondAthlet + thirdAthlet;
int minutes = totalTimeSec / 60;
int seconds = totalTimeSec % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}