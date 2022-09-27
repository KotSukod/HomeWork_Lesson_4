Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 10;
int result = 0;
int help = 0;
while (num > 0)
{
    help = num / count;
    if (help > 10) count = count * 10;

    else if (help < 10)
    {
        result = result + help;
        num = num - help * count;
        count = 1;
        help = 0;
    }
     
}
Console.WriteLine($"Сумма всеx чисел равна - {result}");

   


