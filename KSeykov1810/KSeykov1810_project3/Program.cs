double T1 = double.Parse(Console.ReadLine());
double V1 = double.Parse(Console.ReadLine());
double T2 = double.Parse(Console.ReadLine());
double V2 = double.Parse(Console.ReadLine());
double averageSpeed = (V1 * T1 + V2 * T2) / (T1 + T2);
Console.WriteLine($"{averageSpeed:F2} km/h");