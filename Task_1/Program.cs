﻿Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i<=numB;i++)
{
    result= result * numA;
}
Console.WriteLine(result);