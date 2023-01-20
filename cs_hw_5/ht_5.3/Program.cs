// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void checkAvailabil(int[] array, int findNum)
{
    if(Array.IndexOf(array, findNum) != -1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

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


int sizArr = 0;
int elem_01 = 0;
string arrSz = "";
while(true)
{
    Console.WriteLine("Enter array size or enter 'q' for stop: ");
    arrSz = Console.ReadLine();
    if(arrSz == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else
    {
        bool result_01 = inpValid(arrSz);
        if(result_01 == true)
        {
            sizArr = Int32.Parse(arrSz);
        }
        else
        {
            Console.WriteLine("Error enter!");
        }
        int[] array_01 = userArray(sizArr);
        Console.WriteLine("Enter find element: ");
        string findEl = Console.ReadLine();
        bool result_02 = inpValid(findEl);
        if(result_02 == true)
        {
            elem_01 = Int32.Parse(findEl);
        }
        else
        {
            Console.WriteLine("Error enter!");
        }
        checkAvailabil(array_01, elem_01);
    }    
}


