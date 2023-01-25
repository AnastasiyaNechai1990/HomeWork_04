//Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Нельзя использовать библиотеку Math!
//3, 5 -> 243 (3⁵)
//2, 4 -> 16



int GetRez (int num2, int num1)
{
    int rez = 1;
    for (int i = 0; i < num2; i++)
    {
        rez *= num1;
    }
    return rez;
}

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
int rez = GetRez(num2, num1);
Console.Write($"{rez}");
