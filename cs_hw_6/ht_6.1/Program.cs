// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

void returnArrays(int[] array_01)
{
    userArray(array_01);
    resArray(array_01);
    Console.WriteLine($"User enter: {String.Join(", ", array_01)}");
}

void resArray(int[] array)
{
    for(int idx = 0; idx < array.Length / 2; idx++)
    {
        int tmp = array[array.Length - idx - 1];
        array[array.Length - idx - 1] = array[idx];
        array[idx] = tmp;
    }
}

void userArray(int[] array)
{
    for(int idx = 0; idx < array.Length; idx++)
    {
        int nextEl = nextElArr($"Enter {idx + 1} element: ");
        array[idx] = nextEl;
    }
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
            continue;
        }
        int[] array_01 = new int[sizArr];
        returnArrays(array_01);
    }    
}