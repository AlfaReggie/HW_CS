// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write($"Enter count number you want test: ");
int cnt_nmb = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < cnt_nmb)
{
    Console.WriteLine($"Enter next number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
    {
        for (int j = 1; j >= num; j--)
        {
            if (j % 2 == 0)
            {
                Console.Write($"{j}, ");
            }
        }
    }
    else
    {for (int j = 1; j <= num; j++)
        {
            if (j % 2 == 0)
            {
                Console.Write($"{j}, ");
            }
        }
    }
    i++;
}
