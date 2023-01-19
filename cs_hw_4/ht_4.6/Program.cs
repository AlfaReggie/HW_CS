// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumDig(int num)
{   
    int sum = 0; int nxt_iter = 0; 
    if(num < 0)
    {
        int absNum = num * -1;
        for(int idx = num.ToString().Length; idx != 2; idx--)
        {
            nxt_iter = absNum % 10;
            absNum /= 10;
            sum += nxt_iter;
        }
        int last_itr = absNum % 10;
        sum -= last_itr;
    }
    else if(num > 0)
    {
        for(int idx = num.ToString().Length; idx != 0; idx--)
        {
            nxt_iter = num % 10;
            num /= 10;
            sum += nxt_iter;
        }
    }
    else
    {
        sum = 0;
    }
    return sum;
}

bool inpValid(string numbers)
{
    try
    {
        int intNum = Int32.Parse(numbers);
        return true;
    }
    catch
    {
        return false;
    }
}

void cycleF(string numbers)
{
    bool result = inpValid(numbers);
    if(result == true)
    {
        int userNumber = Int32.Parse(numbers);
        int sumRes = sumDig(userNumber);
        Console.WriteLine(sumRes);
    }
    else
    {
        Console.WriteLine("Enter error!");
    }
}


while(true)
{   
    Console.WriteLine("Enter number or enter 'q' to stop: ");
    string user_answ = Console.ReadLine();
    if(user_answ.ToLower() == "q")
    {
        Console.WriteLine("Ok, Bye!");
        break; 
    }
    else
    {
        cycleF(user_answ);
        continue;
    }
}
