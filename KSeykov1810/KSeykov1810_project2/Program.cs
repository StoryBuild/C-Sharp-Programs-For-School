double N = Convert.ToDouble(Console.ReadLine());
double M = Convert.ToDouble(Console.ReadLine());
double K = Convert.ToDouble(Console.ReadLine());
double priceAfterFirstIncrease = N + (M / 100 * N);
double finalPrice = priceAfterFirstIncrease + (K / 100 * priceAfterFirstIncrease);
Console.WriteLine(finalPrice);