// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

while (true)
{   
    Console.WriteLine("Enter Y if you want continue or any string if not: ");
    string next_num = Console.ReadLine();
    if (next_num.ToLower() != "y")
    {
        Console.WriteLine("Ok, Bye!");
        break;
    }
    else
    {
        Console.WriteLine("Enter weekday number: ");
        int weekdayNum = Convert.ToInt32(Console.ReadLine());
        if (weekdayNum < 1 || weekdayNum > 7)
        {
            Console.WriteLine("Not correct enter! Try again!");
            continue;
        }
        try
        {
            if (weekdayNum/6 == 1)
            {
                Console.WriteLine("Holiday!!!");
            }
            else
            {
                Console.WriteLine("Working day...");
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Not correct enter! Try again!");
            continue;
        }
    }
}   