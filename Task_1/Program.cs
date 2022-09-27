Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = 1;
int count = 1;
while (count <=numB)
{
    result= result * numA;
    count = count + 1;
}
Console.WriteLine(result);