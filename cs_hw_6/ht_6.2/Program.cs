// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

void returnArrays(int[] array_01)
{
    userArray(array_01);
    if(array_01[0] + array_01[1] > array_01[2] && array_01[0] + array_01[2] > array_01[1] && array_01[1] + array_01[2] > array_01[0])
    {
        Console.WriteLine("This triangle can exist!");
    }
    else
    {
        Console.WriteLine("This triangle can't exist!");
    }
    Console.WriteLine($"User enter: {String.Join(", ", array_01)}");
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

int sizArr = 3;
while(true)
{
    Console.WriteLine("Enter 's' to start or enter 'q' for stop: ");
    string arrSz = Console.ReadLine();
    if(arrSz.ToLower() == "q")
    {
        Console.WriteLine("Bye!");
        break;
    }
    else if(arrSz.ToLower() == "s")
    {
        int[] array_01 = new int[sizArr];
        returnArrays(array_01);
    }    
}
