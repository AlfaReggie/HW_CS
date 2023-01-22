// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void evenCount(int[] array)
{
    Console.WriteLine($"User enter: {String.Join(", ", array)}");
    int evnCnt = 0;
    for(int idx = 0; idx < array.Length; idx++)
    {
        if(array[idx] % 2  == 0)
        {
            evnCnt++;
        }
    }
    Console.WriteLine($"Even count: {evnCnt}");
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
    while(true)
    {
        string elem = Console.ReadLine();
        resVal = inpValid(elem);
        if(resVal == true)
        {
            num = Int32.Parse(elem);
            break;
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
    if(res_val == true & res_num.ToString().Length == 3)
    {   
        return true;
    }   
    else
    {
        return false;
    }
}

bool sizValid(string num)
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
string arrSz = "";

while(true)
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
        bool result_01 = sizValid(arrSz);
        if(result_01 == true)
        {
            sizArr = Int32.Parse(arrSz);
        }
        else
        {
            Console.WriteLine("Error enter!");
        }

        int[] array_01 = userArray(sizArr);
        evenCount(array_01);
    }    
}