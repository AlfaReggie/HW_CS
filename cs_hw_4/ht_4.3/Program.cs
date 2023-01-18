// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int sequeSum(int number)
{
    int mult = 1;
    if(number <= 0)
    {
        for(int idx = -1; idx >= number; idx--)
        {
            mult *= idx;
        }
    }
    else
    {
        for(int idx = 1; idx <= number; idx++)
        {
            mult *= idx;
        }
    }
    return mult;
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

void cycleF(string number)
{    
    bool result = inpValid(number);
    if(result == true)
    {
        int numb = Int32.Parse(number);
        int res_sum = sequeSum(numb);
        Console.WriteLine(res_sum);
    }
    else
    {
        Console.WriteLine("Enter error!");
    }
}

while(true)
{   
    Console.WriteLine("Enter number for start or enter 'q' to stop: ");
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