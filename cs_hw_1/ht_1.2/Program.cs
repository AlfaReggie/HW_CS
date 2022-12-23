// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int i = 0;
int max_num = 0;
while (i < 3)
{
    Console.Write($"Enter {i+1} number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > max_num)
    {
        max_num = num;
    }
        i++;
}
Console.WriteLine($"Max number = {max_num}");
