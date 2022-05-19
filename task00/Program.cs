//Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine() ?? "0");
int index = 1;

while (index <= n) 
{
    Console.Write (index*index + " ");
    index++;
}