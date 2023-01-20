// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

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
        bool valRes = inpValid(randArr[idx]);
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

int[] randArr = usRandArr(12, -9, 9);
int[] resultSum = ElSum(randArr);

Console.WriteLine(string.Join(", ", randArr));
Console.WriteLine(string.Join(", ", resultSum));
