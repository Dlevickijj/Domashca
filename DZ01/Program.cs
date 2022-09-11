// адача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 




Console.Clear();
Console.Write("Введите первое число: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_b = Convert.ToInt32(Console.ReadLine());

int max = num_a;
int min = num_a;

if (num_a > num_b)

{
    max = num_a;

}
if (num_a > num_b)
{
    min = num_b;
}

Console.WriteLine($"{max}   наибольшее число: ");
Console.WriteLine($"{min}   меньшее число число: ");
