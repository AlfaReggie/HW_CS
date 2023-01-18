//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int sequeSum(int number)
{
    int sum = 0;
    if(number <= 0)
    {
        for(int idx = -1; idx >= number; idx--)
        {
            sum += idx;
        }
    }
    else
    {
        for(int idx = 1; idx <= number; idx++)
        {
            sum += idx;
        }
    }
    return sum;
}

bool inpValid(string number)
{
    try 
    {
        int numnum = Int32.Parse(number);
        return true;
    }
    catch
    {
        return false;
    }
}

void cycleF()
{    
    Console.WriteLine("Enter number: ");
    string userNum = Console.ReadLine();
    bool result = inpValid(userNum);
    if(result == true)
    {
        int numb = Int32.Parse(userNum);
        int res_sum = sequeSum(numb);
        Console.WriteLine(res_sum);
    }
    else
    {
        Console.WriteLine("Enter error111!");
    }
}

while(true)
{   
    Console.WriteLine("Enter 'n' if you want start or enter 'q' to stop: ");
    string user_answ = Console.ReadLine();
    if(user_answ.ToLower() == "q")
    {
        Console.WriteLine("Ok, Bye!");
        break; 
    }
    else if(user_answ.ToLower() == "n")
    {
        cycleF();
    }
    else
    {
        Console.WriteLine("Enter error!");
        continue;
    }
}