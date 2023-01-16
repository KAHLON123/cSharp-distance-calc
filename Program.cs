//welcome
#nullable disable
Console.Clear();
Console.WriteLine("\nWelcome to the distance calculator");

//inp
Console.Write("enter x1 value: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter x2 value: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter y1 value: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter y2 value: ");
double y2 = Convert.ToDouble(Console.ReadLine());

//proc
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

//out
Console.WriteLine($"The distance between these points is {distance}");