// Подсчитать сумму цифр в числе

Console.WriteLine("введите число a");
int a = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
Console.WriteLine ($"сумма цифр в числе {a} =");
while (a>0)
{
    count = count + 1;
    a=a/10;
}

Console.Write($" = {count}");