//Напишите программу, которая на вход принимает два числа и выдаёт
//какое число большее, а какое меньшее.

Console.Write("Enter first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter secound number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if(num_1 < num_2)
{
    Console.WriteLine($"max = {num_2}, min = {num_1}");
}
else if(num_1 == num_2)
{
    Console.WriteLine($"{num_1} == {num_2}");
}
else
{
    Console.WriteLine($"max = {num_1}, min = {num_2}");
}