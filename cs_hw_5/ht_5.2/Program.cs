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

int[] resArray(int[] usrArr, int szARR)
{
    int[] resAr = new int[szARR];
    for(int idx = 0; idx < szARR; idx++)
    {
        bool valRes = checkForPos(usrArr[idx]);
        if(valRes == false)
        {
            resAr[idx] = -usrArr[idx];
        }
        else
        {
            resAr[idx] = -usrArr[idx]; 
        }
    }
    return resAr;
}

int sizArr = 0;
string arrSz = "";

while(arrSz != "q")
{
    Console.WriteLine("Enter array size or enter 'q' for stop: ");
    arrSz = Console.ReadLine();
    if(arrSz.ToLower() == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else
    {
        bool sizeArr = inpValid(arrSz);
        if(sizeArr == true)
        {
            sizArr = Int32.Parse(arrSz);
        }
        else
        {
            Console.WriteLine("Error enter!");
        }
        int[] userArr = userArray(sizArr);
        int[] resultArr = resArray(userArr, sizArr);
        Console.WriteLine(string.Join(", ", userArr));
        Console.WriteLine(string.Join(", ", resultArr));
    }
}



