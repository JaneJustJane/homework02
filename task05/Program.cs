// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine() ?? "0");
int index = 2;
Console.WriteLine ($"Кубы чисел от 1 до {n}, заканчивающихся на четную цифру равны");
while (index <= n) 
{
    Console.Write (index*index*index + " ");
    index=index+2;
}

// решение, если искать куб любого четного числа
//int result = 1;
//if (n%2==0)
//{
   // result = n*n*n;
   // Console.WriteLine ($"Куб числа {n} = {result}");
//}
//else
//{
   // Console.WriteLine($"Число {n} нечетное");
//}