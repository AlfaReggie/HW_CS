// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Write($"Enter count number you want test: ");
int cnt_nmb = Convert.ToInt32(Console.ReadLine());

int i = 0;
while (i < cnt_nmb)
{
    Console.Write($"Enter next number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} - EVEN number");
    }
    else
    {
        Console.WriteLine($"{num} - ODD number");
    }
        i++;
}