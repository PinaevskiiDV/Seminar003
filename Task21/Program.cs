Console.WriteLine("Введите x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int num1, int num2, int num3, int num4, int num5, int num6)
{
    double dist = 0;
    dist = Math.Sqrt(Math.Pow((num4 - num1), 2) + Math.Pow((num5 - num2), 2) + Math.Pow((num6 - num3), 2));
    return dist;
}
Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));
