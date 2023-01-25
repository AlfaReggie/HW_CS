// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

bool inpValid(string num)
{
    bool res_val = int.TryParse(num, out int res_num);
    if(res_val == true)
    {
        return true;
    }   
    else
    {
        return false;
    }
}

void febonnachi(int size)
{
    int frstFeb = 0;
    int scndFeb = 1;
    int sum = 0;
    Console.Write($"{frstFeb} {scndFeb} ");
    for(int idx = 2; idx < size; idx++)
    {
        sum = frstFeb + scndFeb;
        frstFeb = scndFeb;
        scndFeb = sum;
        Console.Write($"{sum} ");
    }
}

int intUsrNum = 0;
string strUserNum = "";
while(true)
{
    Console.Write("\n");
    Console.WriteLine("Enter user num or enter 'q' for stop: ");
    strUserNum = Console.ReadLine();
    if(strUserNum.ToLower() == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else
    {
        bool result_01 = inpValid(strUserNum);
        if(result_01 == true)
        {
            intUsrNum = Int32.Parse(strUserNum);
        }
        else
        {
            Console.WriteLine("Error enter!");
            continue;
        }
    febonnachi(intUsrNum);
    }
}

