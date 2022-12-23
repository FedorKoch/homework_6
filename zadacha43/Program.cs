Console.Clear();
Console.WriteLine("введите параметры первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите параметры второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;
if(b1 == b2)
{
Console.WriteLine();
Console.WriteLine("прямые параллельны");
}
else {
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
Console.WriteLine();
Console.WriteLine("точка пересечения прямых");
Console.Write(Math.Round(x, 2));
Console.Write(" , ");
Console.Write(Math.Round(y, 2));
}


