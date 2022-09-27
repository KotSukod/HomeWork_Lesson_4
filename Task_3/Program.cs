string []array = new string [8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива': ");
    array[i] = Console.ReadLine();
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write("]");