int hour = int.Parse(Console.ReadLine());
if (hour >= 4 && hour <= 9)
{
    Console.WriteLine("Good morning");
}
else if (hour > 9 && hour <= 18)
{
    Console.WriteLine("Good afternoon");
}
else if ((hour > 18 && hour <= 24) || (hour >= 0 && hour <= 4))
{
    Console.WriteLine("Good evening");
}
