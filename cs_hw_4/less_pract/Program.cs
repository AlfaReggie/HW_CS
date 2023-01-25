// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void revBinSys(int num)
{
    int tempNum = 0;
    string binNum = "";
    if(num != 0)  
    {
        tempNum = num % 2;
        binNum += tempNum;
        revBinSys(num /= 2);
    }
    Console.Write(binNum);
}

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
    revBinSys(intUsrNum);
    }
}