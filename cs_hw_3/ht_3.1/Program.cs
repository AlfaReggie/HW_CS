// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string fd_num = "0";
while (fd_num.ToString().Length < 5 || fd_num.ToString().Length > 5)
{
    Console.WriteLine("Enter a number of at least five digits or enter 'q' to stop: ");
    fd_num = Console.ReadLine();
    if (fd_num.ToString().Length < 5 || fd_num.ToString().Length > 5)
    {
        Console.WriteLine("Not five digits number");
    }
    else
    {
        try
        {
            int fd_int = Int32.Parse(fd_num);
            int tmp = 0;
            int num = fd_int;
            while (tmp.ToString().Length < 5) 
            {   
                tmp *= 10;
                tmp += num % 10;
                num /= 10;
            }
                if (fd_int == tmp)
                {
                    Console.WriteLine("да");
                }
                else
                {
                    Console.WriteLine("нет");
                }
        }
        catch (System.FormatException)
        {
            if (fd_num.ToLower() == "q")
            {
                Console.WriteLine("Ok, Bye!");
                break; 
            }
            Console.WriteLine("Enter error!");
            continue;
        }
    }
}