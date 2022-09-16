Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int ReverseNumber(int num)
{
    int reverse = 0;
    while (num > 0)
    {
        reverse = reverse * 10 + num % 10;
        num /= 10;
    }    
    return reverse;
}
int reverse = ReverseNumber(number);
if (reverse == number)
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{
    Console.WriteLine("Данное число не является палиндромом");
}