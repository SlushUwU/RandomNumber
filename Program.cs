// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
int last = Convert.ToInt32(Console.ReadLine());
Random r = new Random();
int rInt = r.Next(0, last);
int range = last;
double rDouble = r.NextDouble() * range;
Console.WriteLine(rInt);
// Get 80% of the Random numer
Console.WriteLine("80% from "+ rInt+ ": " + rInt * 0.8);
// Get 20% of the Random number
Console.WriteLine("20% from " + rInt + ": " + rInt * 0.2);