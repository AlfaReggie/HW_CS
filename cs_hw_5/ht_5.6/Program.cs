// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] usRandArr(int arrSize, int minBorder, int maxBorde)
{
    int[] array = new int[arrSize];
    for(int idx = 0; idx < arrSize; idx++)
    {
        array[idx] = new Random().Next(minBorder, maxBorde + 1);
    }
    return array;
}

bool inpValid(int num)
{
    if(num > 9 & num < 100)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void evenCount(int[] array)
{
    Console.WriteLine($"User enter: {String.Join(", ", array)}");
    int evnCnt = 0;
    for(int idx = 0; idx < array.Length; idx++)
    {
        bool resVal = inpValid(array[idx]);
        if(resVal == true)
        {
            evnCnt++;
        }
    }
    Console.WriteLine($"Even count: {evnCnt}");
}

int[] array_01 = usRandArr(123, 0, 150);
evenCount(array_01);