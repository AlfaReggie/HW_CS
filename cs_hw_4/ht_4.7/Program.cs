// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] usrArr(int[] smArry, string[] inpArry)
{
    for(int idx = 0; idx < smArry.Length; idx++)
    {
        int nextNum = Int32.Parse(inpArry[idx]);
        smArry[idx] = nextNum;
    }
    return smArry;
}

bool inpValid(string[] numbers)
{
    try 
    {
        int[] intarr = new int[numbers.Length];

        for(int idx = 0; idx < 8; idx++)
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

void prntArry(int[] array)
{
    for(int idx = 0; idx < array.Length; idx++)
    {
        Console.Write($"{array[idx]}, ");
    }
}

int[] inpArr(string message)
{
    int[] array_1 = new int[8];
    Console.WriteLine(message);
    string[] userArr = Console.ReadLine().Split();
    bool result = inpValid(userArr);
    if(result == true)
    {
        array_1 = usrArr(array_1, userArr);
    }
    return array_1;
}



int[] myarray = inpArr("Enter 8 array elements separated by a space: ");
Console.WriteLine($"It's your array --> {myarray}");
Console.WriteLine("It's elements your array: ");
prntArry(myarray);


