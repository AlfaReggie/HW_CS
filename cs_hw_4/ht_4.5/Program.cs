// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в степень B.

int intDigitCount(int num, int val_sqr)
{   
    if(val_sqr > 0)
    {
        int result = num;
        for(int idx = 1; idx < val_sqr; idx++)
        {
            result *= num;
        }
        return result;
    }
    else
    {
        return 1;
    }
}
double doubleDigitCount(double num, int val_sqr)
{
    double dresult = (1.0 / num - 1.0) * -1.0;
    double dnum = (1.0 / num - 1.0) * -1.0;
    
    for(int idx = 1; idx < val_sqr * -1; idx++)
    {
        dresult *= dnum;
    }
    return dresult;
}

bool inpValid(string[] numbers)
{
    try 
    {
        int[] intarr = new int[numbers.Length];

        for(int idx = 0; idx < 2; idx++)
        {
            intarr[idx] = Int32.Parse(numbers[idx]);
        }
        return true;
    }
    catch
    {
        return false;
    }
}

void cycleF(string[] numbers)
{
    bool result = inpValid(numbers);
    if(result == true)
    {
        int[] intarr = new int[numbers.Length];
        double[] doubarr = new double[numbers.Length];
        for(int idx = 0; idx < 2; idx++)
        {
            intarr[idx] = Int32.Parse(numbers[idx]);
        }
        if(intarr[1] >= 0)
        {
            int res_sqr = intDigitCount(intarr[0], intarr[1]);
            Console.WriteLine($"Count digits in a number = {res_sqr}");
        }
        else if(intarr[1] < 0)
        {
            double dnum = Double.Parse(numbers[0]);
            int dval_sqr = intarr[1];
            double dres_sqr = doubleDigitCount(dnum, dval_sqr);
            Console.WriteLine($"Count digits in a number = {dres_sqr}");
        }
    }
    else
    {
        Console.WriteLine("Enter error!");
    }
}

while(true)
{   
    Console.WriteLine("Enter number and value of square sep by a space or enter 'q' to stop: ");
    string[] user_answ = Console.ReadLine().Split();
    if(user_answ[0].ToLower() == "q")
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