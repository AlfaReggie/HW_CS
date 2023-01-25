// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

void copyArray(int[] copyArr, int[] usrArr)
{
    for(int idx = 0; idx < usrArr.Length; idx++)
    {
        copyArr[idx] = usrArr[idx]; 
    }
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
        int[] copyArr = new int[sizArr];

        copyArray(copyArr, userArr);

        Console.WriteLine(string.Join(", ", userArr));
        Console.WriteLine(string.Join(", ", copyArr));
    }
}