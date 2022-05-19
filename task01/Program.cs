// Найти кубы чисел от 1 до N

Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine() ?? "0");
int index = 1;
Console.WriteLine ($"Кубы чисел от 1 до {n} равны");
while (index <= n) 
{
    Console.Write (index*index*index + " ");
    index++;
}