// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int GetSum (int n)
{
    int sum = 0;
    for (int i = 0; n > 0; i++)
    {
        sum += n % 10; 
        n /= 10;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = GetSum(num);
Console.Write($"{sum}");