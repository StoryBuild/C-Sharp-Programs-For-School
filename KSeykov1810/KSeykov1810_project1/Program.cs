double N1 = double.Parse(Console.ReadLine());

double N2 = double.Parse(Console.ReadLine());

double N3 = double.Parse(Console.ReadLine());

double sum = N1 + N2 + N3;

double percentN1 = N1 / sum * 100;
double percentN2 = N2 / sum * 100;
double percentN3 = N3 / sum * 100;

Console.WriteLine(percentN1 + "%");
Console.WriteLine(percentN2 + "%");
Console.WriteLine(percentN3 + "%");