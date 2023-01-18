// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int digitCount(int number)
{
    int cnt = 0;
    number = Math.Abs(number);
    for(int idx = 0; idx < number.ToString().Length; idx++)
    {
        cnt++;
    }
    return cnt;
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
        int res_sum = digitCount(numb);
        Console.WriteLine($"Count digits in a number = {res_sum}");
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