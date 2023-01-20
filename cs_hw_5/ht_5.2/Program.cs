// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] userArray(int arrSize)
{
    int[] array = new int[arrSize];
    for(int idx = 0; idx < arrSize; idx++)
    {
        int nextEl = nextElArr($"Enter {idx + 1} element: ");
        array[idx] = nextEl;
    }
    return array;
}

int nextElArr(string massage)
{
    Console.WriteLine(massage);
    bool resVal = false;
    int num = 0;
    while(resVal == false)
    {
        string elem = Console.ReadLine();
        resVal = inpValid(elem);
        if(resVal == true)
        {
            num = Int32.Parse(elem);
        }
        else
        {
            Console.WriteLine("Enter error! Try again!");
            continue;
        }      
    }
    return num;
}

bool inpValid(string num)
{
    int res_num = 0;
    try
    {
        res_num = Int32.Parse(num);
        return true;
    }
    catch
    {
        return false;
    }
}

bool checkForPos(int num)
{
    if(num < 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int[] ElSum(int[] randArr)
{
    int[] resF = {0, 0};
    for(int idx = 0; idx < randArr.Length; idx++)
    {
        bool valRes = checkForPos(randArr[idx]);
        if(valRes == false)
        {
            resF[1] += randArr[idx];
        }
        else
        {
            resF[0] += randArr[idx]; 
        }
    }
    return resF;
}

int[] userArr = userArray(12);
int[] resultSum = ElSum(userArr);

Console.WriteLine(string.Join(", ", userArr));
Console.WriteLine(string.Join(", ", resultSum));
