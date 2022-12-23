// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int thrDigNum = 0;
while (thrDigNum.ToString().Length < 3 || thrDigNum.ToString().Length > 3)
{
    Console.WriteLine("Enter three-digit number or enter enter any string to stop: ");
    try
    {
        thrDigNum = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Ok, STOP!");
        break;
    }
    if (thrDigNum.ToString().Length < 3 || thrDigNum.ToString().Length > 3)
    {
        Console.WriteLine("Error!");
    }
    else
    {
        int scndNum = 0;
        while (thrDigNum.ToString().Length >= 2)
        {
            scndNum = thrDigNum % 10;
            thrDigNum = thrDigNum / 10;
        }
        Console.WriteLine($"Secound digit of the number it's ==> {scndNum}");
        break;
    }
}

