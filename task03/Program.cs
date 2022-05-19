// Возведите число А в натуральную степень B используя цикл

Console.WriteLine ("введите число А");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine ("введите степень В, в которую Вы хотите  возвести число");
int b = int.Parse(Console.ReadLine() ?? "0");
int result = 1;
for (int i=1; i<=b; i++)
{
    result = result*a;
}
Console.Write ($"число {a} в степени {b} равно {result}");