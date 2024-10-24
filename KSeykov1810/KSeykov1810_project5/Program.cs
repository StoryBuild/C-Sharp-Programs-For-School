int t = int.Parse(Console.ReadLine());
if (t <= -20)
{
    Console.WriteLine("Ice cold");
}
else if (t <= 0 && t > -20)
{
    Console.WriteLine("Cold");
}
else if (t <= 15 && t > 0)
{
    Console.WriteLine("Cool");
}
else if (t <= 25 && t > 15)
{
    Console.WriteLine("Warm");
}
else if (t > 25)
{
    Console.WriteLine("Hot");
}
