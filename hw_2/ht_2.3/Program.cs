// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int weekdayNum = 0;
while (weekdayNum < 1 || weekdayNum > 7)
{
    Console.WriteLine("Enter weekday number or enter enter any string to stop: ");
    try
    {
        weekdayNum = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Ok, STOP!");
        break;
    }
    if (weekdayNum < 1 || weekdayNum > 7)
    {
        Console.WriteLine("Weekday number can't < 1 and > 7");
    }
    else
    {
        if (weekdayNum == 6 || weekdayNum == 7)
        {
            Console.WriteLine("Holiday!!!");
        }
        else
        {
            Console.WriteLine("Working day...");
        }
    }
}
