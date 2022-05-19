// Найти сумму чисел от 1 до А

Console.WriteLine("введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");
int index = 1;
int sum=0;
while (index <= a) 
{
    sum = sum + index;
    index++;
}
Console.WriteLine($"Сумма чисел от 1 до {a} равна {sum}");