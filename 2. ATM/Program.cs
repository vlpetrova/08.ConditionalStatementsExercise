
// Print "The withdraw was successful.", if the balance is enough
//	Print "The limit was exceeded.", if the limit is exceeded
//	Print "Insufficient availability.", if the balance isn't enough
int balance = int.Parse(Console.ReadLine());
int withrow = int.Parse(Console.ReadLine());
int limit = int.Parse(Console.ReadLine());

if (balance > limit && balance > withrow && withrow < limit)
{
    Console.WriteLine("The withdraw was successful.");
}
else if (balance < limit && balance < withrow && withrow > limit)
{
    Console.WriteLine("The limit was exceeded.");
}
else if (balance < limit && balance < withrow && withrow < limit)
{
    Console.WriteLine("Insufficient availability.");
}