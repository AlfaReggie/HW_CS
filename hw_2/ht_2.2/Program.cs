// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int longDigNum = 0;
while (longDigNum.ToString().Length < 3)
{
    Console.WriteLine("Enter a number of at least three digits or enter enter any string to stop: ");
    try
    {
        longDigNum = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Ok, STOP!");
        break;
    }
    if (longDigNum.ToString().Length < 3)
    {
        Console.WriteLine("Number does not have a third digit!");
    }
    else
    {
        int thirdNum = 0;
        while (longDigNum.ToString().Length >= 3)
        {
            thirdNum = longDigNum % 10;
            longDigNum = longDigNum / 10;
        }
        Console.WriteLine($"Third digit of the number it's ==> {thirdNum}");
        break;
    }
}