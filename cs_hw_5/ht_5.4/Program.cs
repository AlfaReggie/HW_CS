// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

void returnArrays(int[] array_01, int[] array_02)
{
    Console.WriteLine($"User enter: {String.Join(", ", array_01)}");
    Console.WriteLine($"Result array: {String.Join(", ", array_02)}");
}

int[] resArray(int[] array, int size_array)
{
    if(size_array % 2 == 0)
    {
        int[] res_array = new int[size_array / 2];
        for(int idx = 0; idx < size_array / 2; idx++)
        {
            res_array[idx] = array[idx] * array[size_array - idx - 1];
        }
        return res_array;
    }
    else
    {
        int[] res_array = new int[size_array / 2 + 1];
        for(int idx = 0; idx < size_array / 2; idx++)
        {
            res_array[idx] = array[idx] * array[size_array - idx - 1];
        }
        res_array[size_array / 2] = array[size_array / 2];
        return res_array;
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
    if(arrSz.ToLower() == "q")
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
        int[] resArr = resArray(array_01, sizArr);
        returnArrays(array_01, resArr);
    }    
}