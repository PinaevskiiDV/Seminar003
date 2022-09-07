Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

GetDashbord(num);

void GetDashbord(int num)
{
    int count = 1;
    while(count <= Math.Abs(num))
    {
        Console.WriteLine($"Куб числа {count} = {Math.Pow(count, 3)}");
        count++;
    }
}